using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;
using Bunifu.UI.WinForms.Helpers.Transitions;
using static WebLuMoura.Calendario;
using MySqlX.XDevAPI.Common;

namespace WebLuMoura
{
    public partial class Calendario : System.Web.UI.Page
    {
       
        private const string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1Nome.ReadOnly = true;
            TextBox2Telefone.ReadOnly = true;

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
                        TextBox1Nome.Text = clienteData.Rows[0]["Nome"].ToString();
                        TextBox2Telefone.Text = clienteData.Rows[0]["Telefone"].ToString();
                    }
                }
                else
                {
                    // Redireciona para a página de login se o IdCliente não estiver na sessão
                    //Response.Redirect("LoginUsuarioWeb.aspx");
                }

                // Vamos assumir que você quer buscar os horários para a data atual
                DateTime dataSelecionada = DateTime.Today;
                ExibirHorarios(dataSelecionada);
                PopulaDropDownList();
            }
        }

        protected void TextBox3Observacao_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = TextBox3Observacao.Text;
            Session["DescricaoCliente"] = textoDigitado;

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
                    }
                }
            }

            return clienteData;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;
            ExibirHorarios(selectedDate);

            // Remova a seguinte linha para evitar criar uma nova instância local
            // Armazene a data selecionada na Session
            Session["DateTime"] = selectedDate;

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Adicione aqui o código que você deseja executar quando uma linha do GridView é selecionada


        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EnviarDados")
            {
                string rowIndex = e.CommandArgument.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT HorarioID FROM Horarios WHERE Hora = @Horario";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Horario", rowIndex);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Remova a seguinte linha para evitar criar uma nova instância local
                            // ServicoInfo servicoInfo = new ServicoInfo();
                            Session["IdHorario"] = Convert.ToInt32(result);

                        }
                    }
                }
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            // Adicione aqui o código que você deseja executar quando uma linha do GridView é gerada
        }

        private void ExibirHorarios(DateTime dataSelecionada)
        {
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

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string servicoSelecionado = DropDownList1.SelectedItem.Text;
            Session["Servico"] = servicoSelecionado;

            // Chama a função para obter preço e duração e atualizar os Labels
            PecoAndDuracao(servicoSelecionado, LabelPreco, LabelDuracao);

            if (DropDownList1 != null)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Use parâmetros para evitar problemas de SQL Injection
                    SqlCommand cmd = new SqlCommand("SELECT ServicoID FROM Servicos WHERE NomeServico = @NomeServico", conn);
                    cmd.Parameters.AddWithValue("@NomeServico", servicoSelecionado);

                    // Execute a consulta e leia o resultado
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Corrija a sintaxe para criar uma instância do objeto ServicoInfo
                        

                        Session["ServicoID"] = result;

                        // Agora você pode usar servicoInfo.ServicoID conforme necessário
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

                DropDownList1.Items.Clear();
                while (reader.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = reader["NomeServico"].ToString();
                    item.Value = reader["NomeServico"].ToString();
                    DropDownList1.Items.Add(item);
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

                        label1.Text = $"Preço: {preco:C}";
                        label2.Text = $"Duração: {duracao} horas";
                    }
                    else
                    {
                        label1.Text = "Serviço não encontrado!";
                        label2.Text = string.Empty;
                    }
                }
            }
        }

        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {
            // Adicione aqui o código que você deseja executar quando a seleção do calendário é alterada
        }

        protected void BtnAgendar_Click(object sender, EventArgs e)
        {

            try
            {
                // Crie a string SQL com parâmetros
                string sql = "INSERT INTO Agendamentos (FK_ServicoID, FK_HorarioID, DataAgendamento, NomeCliente, Telefone, Servico, Descricao) " +
              "VALUES (@FK_ServicoID, @FK_HorarioID, @DataAgendamento, @NomeCliente, @TelefoneCliente, @Servico, @Descricao)";

                // Crie e abra a conexão
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Crie e configure o comando SQL
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {

                        // Adicione parâmetros ao comando

                        // Adicione parâmetros ao comando
                        cmd.Parameters.AddWithValue("@FK_ServicoID", (int?)Session["ServicoID"]);
                        cmd.Parameters.AddWithValue("@FK_HorarioID", (int?)Session["IdHorario"]);
                        cmd.Parameters.AddWithValue("@DataAgendamento", (DateTime)Session["DateTime"]);
                        cmd.Parameters.AddWithValue("@NomeCliente", TextBox1Nome.Text);
                        cmd.Parameters.AddWithValue("@TelefoneCliente", TextBox2Telefone.Text);
                        cmd.Parameters.AddWithValue("@Servico", (string)Session["Servico"]);
                        cmd.Parameters.AddWithValue("@Descricao", (string)Session["DescricaoCliente"]);

                        // Execute o comando SQL
                        cmd.ExecuteNonQuery();
                    }
                }

                // Operação bem-sucedida, faça algo se necessário
            }
            catch (Exception ex)
            {
                // Trate a exceção - registre, exiba uma mensagem de erro, etc.
                // Por exemplo:
                Response.Write("Ocorreu um erro: " + ex.Message);
            }
        }
    }

        
    
}
