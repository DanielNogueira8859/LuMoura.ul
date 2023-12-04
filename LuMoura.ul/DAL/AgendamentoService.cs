using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Transactions;

namespace LuMoura.ul.DAL
{
    internal class AgendamentoService

    {

        public class ServicoInfo
        {
            public decimal Preco { get; set; }
            public decimal Duracao { get; set; }
        }



        //usar em casa
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LuMoura.DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        // usar senac
        //private const string connectionString = "Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;";

        public void NomeAndTempo(string servicoSelecionado, TextBox textPreco, TextBox textDuracao)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Use parâmetros SQL para evitar problemas de SQL Injection
                SqlCommand cmd = new SqlCommand("SELECT ValorServico, DuracaoEmHoras FROM Servicos WHERE NomeServico = @NomeServico", conn);
                cmd.Parameters.AddWithValue("@NomeServico", servicoSelecionado);
                SqlCommand cmd1 = new SqlCommand("SELECT ValorServico, DuracaoEmHoras FROM Servicos WHERE NomeServico = @NomeServico", conn);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // Lê os valores do resultado da consulta e os exibe nos controles TextBox
                        decimal preco = Convert.ToDecimal(dr["ValorServico"]);
                        decimal duracao = Convert.ToDecimal(dr["DuracaoEmHoras"]);

                        // Atualiza os controles de interface do usuário com as informações do serviço
                        textPreco.Text = preco.ToString();
                        textDuracao.Text = duracao.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Serviço não encontrado!");
                    }
                }
            }
        }


        public string Completar(DateTime dataSelecionada, DataGridView dataGridView, TextBox textHorario)
        {
            string dataFormatada = dataSelecionada.ToString("dd-MM-yyyy");

            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                int HorarioID = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells["HorarioID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Horarios WHERE HorarioID = @HorarioID", conn))
                    {
                        cmd.Parameters.AddWithValue("@HorarioID", HorarioID);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                textHorario.Text = dr["Hora"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Horário não encontrado!");
                            }
                        }
                    }
                }
            }
            return dataFormatada;
        }

        public void exibirHora(DataGridView dataGridView2, string data)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Substitua 'sua_data_selecionada' pela data desejada
                string dataSelecionada = data;  // Substitua isso pela sua lógica para obter a data desejada

                // Utilizando um parâmetro para evitar problemas de SQL Injection
                string query = "SELECT Horarios.HorarioID, Horarios.Hora, Horarios.Disponivel " +
                               "FROM Horarios " +
                               "LEFT JOIN Agendamentos ON Horarios.HorarioID = Agendamentos.FK_HorarioID AND Agendamentos.DataAgendamento = @DataAgenda " +
                               "WHERE Agendamentos.AgendamentoID IS NULL OR Horarios.Disponivel = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DataAgenda", dataSelecionada);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView2.DataSource = dt;
                    }
                }
            }
        }

        public void Exibir_Servicos(ComboBox item)
        {
            //usar na minha casa
            SqlConnection conn = new SqlConnection(connectionString);

            // usar no senac//
            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            // Usar em Semac//
            //SqlConnection conn = new SqlConnection("Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;");

            conn.Open();

            // Use parâmetros SQL para evitar problemas de SQL Injection
            SqlCommand cmd = new SqlCommand("SELECT * FROM Servicos", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            item.Items.Clear();
            while (reader.Read())
            {

                item.Items.Add(reader["NomeServico"].ToString());

            }
        }


        public void agendar(string Dataa, string Nome, string Telefone, string Servico, string Descricao, DataGridView dataGridView, string nomeServico)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                int HorarioID = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells["HorarioID"].Value);

                using (SqlConnection conn1 = new SqlConnection(connectionString))
                {
                    conn1.Open();

                    // Consulta para obter informações do serviço
                    using (SqlCommand cmd2 = new SqlCommand("SELECT ServicoID, ValorServico, DuracaoEmHoras FROM Servicos WHERE NomeServico = @NomeServico", conn1))
                    {
                        cmd2.Parameters.AddWithValue("@NomeServico", nomeServico);

                        using (SqlDataReader dr = cmd2.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                int servicoID = Convert.ToInt32(dr["ServicoID"]);
                                decimal duracaoServico = Convert.ToDecimal(dr["DuracaoEmHoras"]);

                                using (SqlConnection conn = new SqlConnection(connectionString))
                                {
                                    conn.Open();
                                    using (SqlTransaction transaction = conn.BeginTransaction())
                                    {
                                        try
                                        {
                                            // 1. Consulta para inserir no banco de dados
                                            for (int i = 0; i < duracaoServico; i++)
                                            {
                                                using (SqlCommand cmd = new SqlCommand("INSERT INTO Agendamentos VALUES (@ServicoID, @HorarioID, @Dataa, @Nome, @Telefone, @Servico, @Descricao)", conn, transaction))
                                                {
                                                    cmd.Parameters.AddWithValue("@ServicoID", servicoID);
                                                    cmd.Parameters.AddWithValue("@HorarioID", HorarioID + i); // Adiciona o índice para representar cada hora
                                                    cmd.Parameters.AddWithValue("@Dataa", Dataa);
                                                    cmd.Parameters.AddWithValue("@Nome", Nome);
                                                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                                                    cmd.Parameters.AddWithValue("@Servico", Servico);
                                                    cmd.Parameters.AddWithValue("@Descricao", Descricao);

                                                    cmd.ExecuteNonQuery();
                                                }

                                                // 2. Consulta para atualizar a disponibilidade na tabela de Horarios
                                                using (SqlCommand cmdUpdate = new SqlCommand("UPDATE Horarios SET Disponivel = 0 WHERE HorarioID = @HorarioID", conn, transaction))
                                                {
                                                    cmdUpdate.Parameters.AddWithValue("@HorarioID", HorarioID + i);
                                                    cmdUpdate.ExecuteNonQuery();
                                                }
                                            }

                                            transaction.Commit(); // Confirma as alterações no banco de dados
                                        }
                                        catch (Exception ex)
                                        {
                                            transaction.Rollback(); // Desfaz as alterações se ocorrer um erro
                                            MessageBox.Show("Erro ao cadastrar agendamento: " + ex.Message);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Serviço não encontrado!");
                            }
                        }
                    }
                }
            }
        }


        public void Cadastrar(string Nome, string Telefone, string Email)
        {
            // usar no senac//
            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            // Usar em casa//
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("insert into Agendamento values ( '" + Nome + "', '" + Telefone + "','" + Email + "', GETDATE())", conn);

        }

        public void Atualizar(DataGridView dataGridView1)
        {
            // usar no senac//
            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False");


            // Usar em casa//
            SqlConnection conn = new SqlConnection(connectionString);



            conn.Open();



            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource bs = new BindingSource();
            bs.DataSource = dr;
            dataGridView1.DataSource = bs;


        }
        public void itemSelecionado(DataGridViewRow dataGridView1)
        {
            if (dataGridView1 != null)
            {

                SqlConnection conn = new SqlConnection(connectionString);



                conn.Open();
                // Agora você pode acessar os valores da linha selecionada, por exemplo:
                string valorDaColuna1 = dataGridView1.Cells["Nome"].Value.ToString();
                string valorDaColuna2 = dataGridView1.Cells["Telefone"].Value.ToString();
                // Faça o que precisar com os valores obtidos

                MessageBox.Show("seu nome é ", valorDaColuna1);
            }

        }

        public void Exibir(DataGridView dataGridView1, string nome)
        {
            //usar senac//

            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False");

            // Usar em casa//
            SqlConnection conn = new SqlConnection(connectionString);


            conn.Open();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE Nome LIKE '%" + nome + "%'", conn);



            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE Nome LIKE '%" + nome + "%'", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dr;
                dataGridView1.DataSource = bs;
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }

        public void ExibirAgendaTudo(DataGridView dataGridView1)

        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Agendamentos ", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dr;
                dataGridView1.DataSource = bs;
            }
            else
            {
                MessageBox.Show("Serviço nao encontrado");
            }


        }

        public void ExibirAgendaData(DataGridView dataGridView1, string data)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Utilizando parâmetros SQL para evitar problemas de SQL Injection
                string query = "SELECT * FROM Agendamentos WHERE CONVERT(DATE, DataAgendamento) = @Data";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Convertendo a string data para DateTime
                    DateTime dataSelecionada = DateTime.Parse(data);
                    // Adicionando o valor correto como parâmetro
                    cmd.Parameters.AddWithValue("@Data", dataSelecionada.Date);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum agendamento encontrado para a data selecionada.");
                    }
                }
            }
        }

        public void ExibirAgendaNome(DataGridView dataGridView1, string nome)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Utilizando parâmetros SQL para evitar problemas de SQL Injection
                string query = "SELECT * FROM Agendamentos WHERE NomeCliente LIKE @Nome";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Adicionando o valor correto como parâmetro
                    cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum agendamento encontrado para o nome informado.");
                    }
                }
            }

        }

        public void ExibirAgendaTelefone(DataGridView dataGridView1, string nome)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Utilizando parâmetros SQL para evitar problemas de SQL Injection
                string query = "SELECT * FROM Agendamentos WHERE Telefone LIKE @Nome";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Adicionando o valor correto como parâmetro
                    cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum agendamento encontrado para o Telefone informado.");
                    }
                }
            }

        }

        public void ExibirAgendaDescricao(DataGridView dataGridView1, string nome)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Utilizando parâmetros SQL para evitar problemas de SQL Injection
                string query = "SELECT * FROM Agendamentos WHERE Descricao LIKE @Nome";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Adicionando o valor correto como parâmetro
                    cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum agendamento encontrado para a descrição informada.");
                    }
                }
            }

        }


        public void ExibirAgendaServico(DataGridView dataGridView1, string nome)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Utilizando parâmetros SQL para evitar problemas de SQL Injection
                string query = "SELECT * FROM Agendamentos WHERE Servico LIKE @Nome";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Adicionando o valor correto como parâmetro
                    cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum agendamento encontrado para a descrição informada.");
                    }
                }
            }

        }

        public void exibirHora1(DataGridView dataGridView2, string data)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Substitua 'sua_data_selecionada' pela data desejada
                string dataSelecionada = data;  // Substitua isso pela sua lógica para obter a data desejada

                // Utilizando um parâmetro para evitar problemas de SQL Injection
                string query = "SELECT Horarios.HorarioID, Horarios.Hora, Horarios.Disponivel " +
                               "FROM Horarios " +
                               "LEFT JOIN Agendamentos ON Horarios.HorarioID = Agendamentos.FK_HorarioID AND Agendamentos.DataAgendamento = @DataAgenda " +
                               "WHERE Agendamentos.AgendamentoID IS NULL OR Horarios.Disponivel = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DataAgenda", dataSelecionada);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView2.DataSource = dt;
                    }
                }
            }



        }

        public void AtualizarAgendamento(int agendamentoID, string novoNome, string novoTelefone, string novaDescricao, string novoServico, string novaData, int novoHorarioID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        AtualizarInformacoesAgendamento(conn, transaction, agendamentoID, novoNome, novoTelefone, novaDescricao, novoServico, novaData, novoHorarioID);
                        AtualizarDisponibilidadeHorarios(conn, transaction, agendamentoID, novoHorarioID);

                        transaction.Commit(); // Confirma as alterações no banco de dados
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Desfaz as alterações se ocorrer um erro
                        MessageBox.Show("Erro ao atualizar agendamento: " + ex.Message);
                    }
                }
            }
        }

        private void AtualizarInformacoesAgendamento(SqlConnection conn, SqlTransaction transaction, int agendamentoID, string novoNome, string novoTelefone, string novaDescricao, string novoServico, string novaData, int novoHorarioID)
        {
            using (SqlCommand cmdUpdate = new SqlCommand("UPDATE Agendamentos SET NomeCliente = @NovoNome, Telefone = @NovoTelefone, Descricao = @NovaDescricao, Servico = @NovoServico, DataAgendamento = @NovaData, FK_HorarioID = @NovoHorarioID WHERE AgendamentoID = @AgendamentoID", conn, transaction))
            {
                cmdUpdate.Parameters.AddWithValue("@AgendamentoID", agendamentoID);
                cmdUpdate.Parameters.AddWithValue("@NovoNome", novoNome);
                cmdUpdate.Parameters.AddWithValue("@NovoTelefone", novoTelefone);
                cmdUpdate.Parameters.AddWithValue("@NovaDescricao", novaDescricao);
                cmdUpdate.Parameters.AddWithValue("@NovoServico", novoServico);
                cmdUpdate.Parameters.AddWithValue("@NovaData", novaData);
                cmdUpdate.Parameters.AddWithValue("@NovoHorarioID", novoHorarioID);

                cmdUpdate.ExecuteNonQuery();
            }
        }

        private void AtualizarDisponibilidadeHorarios(SqlConnection conn, SqlTransaction transaction, int agendamentoID, int novoHorarioID)
        {
            // Marca o horário anterior como disponível
            using (SqlCommand cmdUpdateAnterior = new SqlCommand("UPDATE Horarios SET Disponivel = 1 WHERE HorarioID IN (SELECT FK_HorarioID FROM Agendamentos WHERE AgendamentoID = @AgendamentoID)", conn, transaction))
            {
                cmdUpdateAnterior.Parameters.AddWithValue("@AgendamentoID", agendamentoID);
                cmdUpdateAnterior.ExecuteNonQuery();
            }

            // Marca o novo horário como indisponível
            using (SqlCommand cmdUpdateNovo = new SqlCommand("UPDATE Horarios SET Disponivel = 0 WHERE HorarioID = @NovoHorarioID", conn, transaction))
            {
                cmdUpdateNovo.Parameters.AddWithValue("@NovoHorarioID", novoHorarioID);
                cmdUpdateNovo.ExecuteNonQuery();
            }
        }











    }

}

