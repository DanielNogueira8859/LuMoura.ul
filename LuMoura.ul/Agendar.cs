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
        public void exibirHora(DataGridView dataGridView2)
        {
            SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=LuMoura.DB;Integrated Security=True;");



            conn.Open();



            SqlCommand cmd = new SqlCommand("SELECT * FROM Horarios", conn);

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
            SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=LuMoura.DB;Integrated Security=True;");

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


        public void agendar(string Dataa, string Nome, string Telefone, string Servico, string Descricao)
        {

            // usar no senac//
            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            // Usar em casa//
            SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=LuMoura.DB;Integrated Security=True;");

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Agendamentos values (2, 2,'" + Dataa + "','" + Nome+ "','"+Telefone+"','"+Servico+"','"+Descricao+"')", conn);

            cmd.ExecuteNonQuery();
                
        }

        public void Cadastrar(string Nome, string Telefone, string Email)
        {
            // usar no senac//
            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            // Usar em casa//
            SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=LuMoura.DB;Integrated Security=True;");

            SqlCommand cmd = new SqlCommand("insert into Agendamento values ( '" + Nome + "', '" + Telefone + "','" + Email + "', GETDATE())", conn);

        }
        
        public void Atualizar(DataGridView dataGridView1)
        {
            // usar no senac//
            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False");
            
            
            // Usar em casa//
            SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=LuMoura.DB;Integrated Security=True;");



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

                SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=LuMoura.DB;Integrated Security=True;");



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
            SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=LuMoura.DB;Integrated Security=True;");


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
