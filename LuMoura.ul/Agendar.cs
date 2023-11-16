using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LuMoura.ul
{
    internal class Agendar
    {

        public void NomeAndTempo(string servicoSelecionado, TextBox textPreco, TextBox textDuracao)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
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

                using (SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
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

        public void exibirHora(DataGridView dataGridView2)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");



            conn.Open();



            SqlCommand cmd = new SqlCommand("SELECT * FROM Horarios WHERE Disponivel = 1", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource bs = new BindingSource();
            bs.DataSource = dr;
            dataGridView2.DataSource = bs;

        }
        public void Exibir_Servicos( ComboBox item)
        {
            // usar no senac//
            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
            // Usar em casa//
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

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

                using (SqlConnection conn1 = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
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

                                using (SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
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
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            SqlCommand cmd = new SqlCommand("insert into Agendamento values ( '" + Nome + "', '" + Telefone + "','" + Email + "', GETDATE())", conn);

        }
        
        public void Atualizar(DataGridView dataGridView1)
        {
            // usar no senac//
            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False");
            
            
            // Usar em casa//
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");



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

                SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");



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
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


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

    }
}
