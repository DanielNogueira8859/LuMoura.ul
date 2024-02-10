using MySqlX.XDevAPI.Common;
using ServiceStack.Script;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebLuMoura
{
    public partial class Calendar : System.Web.UI.Page
    {
        private const string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            txtNome.ReadOnly = true;
            txtTelefone.ReadOnly = true;

            if (!IsPostBack)
            {
                // Verifica se o IdCliente está na sessão
                if (Session["IdCliente"] != null)
                {
                    int idCliente = (int)Session["IdCliente"];

                    // Aqui você deve realizar outra consulta SQL para obter os detalhes do cliente
                    // com base no IdCliente
                    DataTable clienteData = ObterDetalhesCliente(idCliente);

                    if (clienteData.Rows.Count > 0)
                    {
                        // Agora você pode usar os dados do cliente como necessário
                        txtNome.Text = clienteData.Rows[0]["Nome"].ToString();
                        txtTelefone.Text = clienteData.Rows[0]["Telefone"].ToString();
                        

                    }
                }
                else
                {
                    // Redireciona para a página de login se o IdCliente não estiver na sessão
                    Response.Redirect("LoginUsuarioWeb.aspx");
                }

                // Vamos assumir que você quer buscar os horários para a data atual
                PopulaDropDownList();
                ddlServicos.SelectedIndex = 0;
                Session["DescricaoCliente"] = "";

            }
        }
        private DataTable ObterDetalhesCliente(int idCliente)
        {
            DataTable clienteData = new DataTable();

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM Cliente WHERE IdCliente = @IdCliente";

                using (SqlCommand comando = new SqlCommand(consulta, conexao))
                {
                    comando.Parameters.AddWithValue("@IdCliente", idCliente);

                    conexao.Open();

                    using (SqlDataReader leitor = comando.ExecuteReader())
                    {
                        clienteData.Load(leitor);
                        Session["Nome"] = clienteData.Rows[0]["Nome"].ToString();
                        Session["Telefone"] = clienteData.Rows[0]["Telefone"].ToString();
                        Session["Email"] = clienteData.Rows[0]["Email"].ToString();
                    }
                }
            }

            return clienteData;
        }

        public List<Horario> ExecutarConsulta(DateTime dataSelecionada)
        {
            List<Horario> horarios = new List<Horario>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Horarios.HorarioID, Horarios.Hora, Horarios.Disponivel " +
                               "FROM Horarios " +
                               "LEFT JOIN Agendamentos ON Horarios.HorarioID = Agendamentos.FK_HorarioID AND Agendamentos.DataAgendamento = CONVERT(DATE, @DataAgenda) " +
                               "WHERE Agendamentos.AgendamentoID IS NULL OR Horarios.Disponivel = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DataAgenda", dataSelecionada);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Horario horario = new Horario
                            {
                                HorarioID = Convert.ToInt32(reader["HorarioID"]),
                                Hora = reader["Hora"].ToString()
                            };

                            horarios.Add(horario);
                        }
                    }
                }
            }

            return horarios;
        }

        public IEnumerable<Horario> ObterHorariosDisponiveis()
        {
            DateTime dataSelecionada = Session["DateTime"] != null ? (DateTime)Session["DateTime"] : DateTime.Now;
            return ExecutarConsulta(dataSelecionada);
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;
            List<Horario> horarios = ExecutarConsulta(selectedDate);

            // Armazene a data selecionada na Session
            Session["DateTime"] = selectedDate;

            DateTime dateTimeValue = (DateTime)Session["DateTime"];
             string data =dateTimeValue.ToString("dd/MM/yyyy");
            Label1.Text = $"Data selecionada: {data}";



            // Atualize a fonte de dados do Repeater
            rptHorarios.DataSource = horarios;
            rptHorarios.DataBind();

            // Exiba ou oculte o Label com base nos horários disponíveis
            lblSemHorarios.Visible = horarios.Count == 0;


            // Se nenhum horário estiver disponível, exiba a mensagem
            if (horarios.Count == 0)
            {
                lblSemHorarios.Visible = true;
                lblSelecionarHorario.Visible = false;
                

            }
            else
            {
                lblSemHorarios.Visible = false;
                lblSelecionarHorario.Visible = false;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string servicoSelecionado = ddlServicos.SelectedItem.Text;
            Session["Servico"] = servicoSelecionado;

            // Chama a função para obter preço e duração e atualizar os Labels
            PecoAndDuracao(servicoSelecionado, lblLabel3, lblLabel4);

            if (ddlServicos != null)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Use parâmetros para evitar problemas de SQL Injection
                    SqlCommand cmd = new SqlCommand("SELECT ServicoID, DuracaoEmHoras FROM Servicos WHERE NomeServico = @NomeServico", conn);
                    cmd.Parameters.AddWithValue("@NomeServico", servicoSelecionado);

                    // Execute a consulta e leia o resultado
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Certifique-se de ajustar os tipos de dados conforme necessário
                        int servicoID = reader.GetInt32(0);
                        decimal duracaoEmHoras = reader.GetDecimal(1);

                        // Atualize as sessões
                        Session["ServicoID"] = servicoID;
                        Session["DuracaoEmHoras"] = duracaoEmHoras;
                        
                        // Agora você pode usar servicoID e duracaoEmHoras conforme necessário
                    }
                    reader.Close();
                }
            }
        }
        public void PecoAndDuracao(string servicoSelecionado, Label label1, Label label2)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT ValorServico, DuracaoEmHoras FROM Servicos WHERE NomeServico = @NomeServico", conn);
                cmd.Parameters.AddWithValue("@NomeServico", servicoSelecionado);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        decimal preco = Convert.ToDecimal(dr["ValorServico"]);
                        decimal duracao = Convert.ToDecimal(dr["DuracaoEmHoras"]);

                        lblLabel3.Text = $"Preço: {preco:C}";
                        lblLabel4.Text = $"Duração: {duracao} horas";
                        
                    }
                    else
                    {
                        lblLabel3.Text = "Serviço não encontrado!";
                        lblLabel4.Text = string.Empty;
                    }
                }
            }
        }

        protected void PopulaDropDownList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT NomeServico FROM Servicos", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                ddlServicos.Items.Clear();

                // Adicione a opção "Selecione um serviço" primeiro
                ddlServicos.Items.Add(new ListItem("Selecione um serviço", ""));

                while (reader.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = reader["NomeServico"].ToString();
                    item.Value = reader["NomeServico"].ToString();
                    ddlServicos.Items.Add(item);
                }

                // Defina a opção padrão como "Selecione um serviço"
                ddlServicos.SelectedIndex = 0;
            }
        }

        protected void rptHorarios_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                // Lógica para exibir ou ocultar o Label com base nos horários disponíveis
                lblSemHorarios.Visible = false;
            }
            else if (e.Item.ItemType == ListItemType.Footer)
            {
                // Lógica para exibir ou ocultar o Label com base nos horários disponíveis
                lblSemHorarios.Visible = rptHorarios.Items.Count == 0;
            }
        }

        protected void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtDescricao.Text;

            if (textoDigitado == null)
            {
                Session["DescricaoCliente"] = "";
            }
            else
            {
                Session["DescricaoCliente"] = textoDigitado;
            }

            

        }

        protected void rptHorarios_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "EnviarDados")
            {
                string ID = e.CommandArgument.ToString();
                Session["IdHorario"] = Convert.ToInt32(ID);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Suponha que você tenha uma tabela chamada 'Horarios' com uma coluna 'Horas'
                    string query = "SELECT Hora FROM Horarios WHERE HorarioID = @HorarioID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HorarioID", (int)Session["IdHorario"]);

                        // Execute a consulta e obtenha o resultado
                        object result = command.ExecuteScalar();

                        // Faça algo com o resultado (neste exemplo, apenas imprime no console)
                        if (result != null)
                        {
                            string horas = result.ToString();
                            Session["HoraMarcada"] = horas;
                            string hora = (string)Session["HoraMarcada"];
                            Label2.Text = $"Horario Escolhido: {hora}";
                        }
                        else
                        {
                            Console.WriteLine("ID não encontrado no banco de dados.");
                        }
                    }
                }
            }
        }

        protected void BtnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
               


                // Certifique-se de que as sessões necessárias estão disponíveis
                if (Session["ServicoID"] == null || Session["IdHorario"] == null || Session["DateTime"] == null ||
                    Session["Servico"] == null ||
                    Session["Nome"] == null || Session["Telefone"] == null ||
                    Session["DuracaoEmHoras"] == null)
                {
                    // Lidar com o caso em que as sessões não estão definidas
                    string mensagem = "alert('Preencha e selecione todos os campos antes de agendar um horario');"; ScriptManager.RegisterStartupScript(this, this.GetType(), "exemploScript", mensagem, true);                  
                    return;
                }

                // Coletar dados das sessões
                int servicoID = (int)Session["ServicoID"];
                int idHorario = (int)Session["IdHorario"];
                DateTime dataAgendamento = (DateTime)Session["DateTime"];
                string nomeCliente = (string)Session["Nome"];
                string telefoneCliente = (string)Session["Telefone"];
                string servico = (string)Session["Servico"];
                string descricaoCliente = (string)Session["DescricaoCliente"];
                decimal duracaoEmHoras = (decimal)Session["DuracaoEmHoras"];

                // Crie a string SQL com parâmetros
                string sqlInsert = "INSERT INTO Agendamentos (FK_ServicoID, FK_HorarioID, DataAgendamento, NomeCliente, Telefone, Servico, Descricao) " +
                                    "VALUES (@FK_ServicoID, @FK_HorarioID, @DataAgendamento, @NomeCliente, @TelefoneCliente, @Servico, @Descricao)";

                string sqlUpdate = "UPDATE Horarios SET Disponivel = 0 WHERE HorarioID = @HorarioID";

                // Crie e abra a conexão
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Inicia a transação
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Consulta para inserir no banco de dados
                            for (int i = 0; i < duracaoEmHoras; i++)
                            {
                                using (SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn, transaction))
                                {
                                    cmdInsert.Parameters.AddWithValue("@FK_ServicoID", servicoID);
                                    cmdInsert.Parameters.AddWithValue("@FK_HorarioID", idHorario + i); // Adiciona o índice para representar cada hora
                                    cmdInsert.Parameters.AddWithValue("@DataAgendamento", dataAgendamento);
                                    cmdInsert.Parameters.AddWithValue("@NomeCliente", nomeCliente);
                                    cmdInsert.Parameters.AddWithValue("@TelefoneCliente", telefoneCliente);
                                    cmdInsert.Parameters.AddWithValue("@Servico", servico);
                                    cmdInsert.Parameters.AddWithValue("@Descricao", descricaoCliente);

                                    cmdInsert.ExecuteNonQuery();
                                }

                                // 2. Consulta para atualizar a disponibilidade na tabela de Horarios
                                using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn, transaction))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@HorarioID", idHorario + i);
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            try
                            {
                                string mensagem = "alert('Horário agendado com sucesso!!');";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "exemploScript", mensagem, true);
                                transaction.Commit(); // Confirma as alterações no banco de dados

                                // Adiciona um script para esperar 2 segundos e, em seguida, recarregar a página
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "reloadScript", "setTimeout(function() { location.reload(); }, 200);", true);
                            }


                            catch
                            {
                                string erro  = "alert('Algo deu errado, tente novamente mais tarde');";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "exemploScript", erro, true);

                            }


                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Desfaz as alterações se ocorrer um erro

                            // Exibir mensagem de erro específica com base no tipo de exceção
                            if (ex is SqlException && ((SqlException)ex).Number == 2627)
                            {
                                // Número 2627 é violação de chave única (duplicidade)
                                
                                string mensagem = "alert('Erro: O horário já está agendado. Por favor, escolha outro horário.');"; ScriptManager.RegisterStartupScript(this, this.GetType(), "exemploScript", mensagem, true);

                            }
                            else
                            {
                                string mensagem = "alert('Erro ao cadastrar agendamento:');"; ScriptManager.RegisterStartupScript(this, this.GetType(), "exemploScript", mensagem, true);
                              
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção - registre, exiba uma mensagem de erro, etc.
                // Por exemplo:              
                string mensagem = "alert('Ocorreu um erro:');"; ScriptManager.RegisterStartupScript(this, this.GetType(), "exemploScript", mensagem, true);

            }
        }


        protected void EnviarMensagemWhatsApp()
        {
            // Obter os valores dos campos do formulário
            // Obter os valores dos campos do formulário
            string name = (string)Session["Nome"];
            string email = (string)Session["Email"];
            string phone = (string)Session["Telefone"];
            string service = (string)Session["Servico"];
            DateTime Date = (DateTime)Session["DateTime"];
            string HoraMarcada = (string)Session["HoraMarcada"];

            
            string cleanedPhone = new string(phone.Where(char.IsDigit).ToArray());


            // Verificar se o número de telefone já está no formato desejado
            if (!phone.StartsWith("+55"))
            {
                // Formatar o número de telefone no padrão desejado
                cleanedPhone = "55" + cleanedPhone;
            }
            phone = $"+{cleanedPhone.Substring(0, 2)} ({cleanedPhone.Substring(2, 2)}) {cleanedPhone.Substring(4, 5)}-{cleanedPhone.Substring(9)}";

            // Construir a mensagem com os dados do formulário
            string message = $"Prezado(a) {name},\n\nAgradecemos sinceramente por escolher os nossos serviços e por agendar conosco. Estamos ansiosos para fornecer a você uma experiência excepcional e garantir a satisfação dos nossos clientes.\n\nSegue abaixo os detalhes do seu agendamento:\n\n- **Serviço Agendado:** {service}\n- **Data do Agendamento:** {Date}\n- **Horário do Agendamento:** {HoraMarcada}\n\nPedimos a gentileza de se atentar aos seguintes pontos:\n\n1. **Chegada Pontual:** Recomendamos chegar com antecedência para garantir o máximo aproveitamento do seu tempo conosco.\n\n2. **Desmarcação ou Reagendamento:** Caso haja a necessidade de desmarcar ou reagendar o serviço, solicitamos a gentileza de nos informar com pelo menos 24 horas de antecedência. Valorizamos o seu tempo e esforçamo-nos para atender às suas necessidades da melhor maneira possível.\n\n3. **Informações Adicionais:** Se houver qualquer informação adicional que gostaria de compartilhar conosco ou alguma solicitação especial, por favor, sinta-se à vontade para entrar em contato.\n\nEstamos comprometidos em oferecer um serviço de qualidade e proporcionar uma experiência agradável. Se houver mais alguma dúvida ou se precisar de assistência, não hesite em entrar em contato conosco.\n\nAgradecemos novamente pela confiança e pela oportunidade de atendê-lo(a).\n\nAtenciosamente,\n\nJanina\nLU MOURA\n11 - 1234567-1234";


            // Codificar a mensagem para ser incluída no link
            string encodedMessage = Server.UrlEncode(message);

            // Construir o link do WhatsApp com a mensagem e o número de telefone desejado
            string whatsappLink = $"https://api.whatsapp.com/send?phone={phone}&text={encodedMessage}";

            // Redirecionar para o link do WhatsApp
            Response.Redirect(whatsappLink);

            // Encerrar a execução da página
        }
    }

    public class Horario
    {
        public int HorarioID { get; set; }
        public string Hora { get; set; }
    }
}
