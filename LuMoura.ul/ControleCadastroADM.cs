using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuMoura.ul
{
    public partial class ControleCadastroADM : Form
    {
        public ControleCadastroADM()
        {
            InitializeComponent();
        }

        public void Atualizar(string Nome, string CPF, string Telefone, string Email)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Lu_Moura; Integrated Security = True; Connect Timeout = 30; Encrypt = False");
            conn.Open();

            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //conn.Open();

            SqlCommand cmd = new SqlCommand("Update Cliente set Nome = '" + Nome + " ', CPF = '" + CPF + "',Telefone = '" + Telefone + "', Email = '" + Email + "' where IdCliente = '" + TxtCodigo.Text + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Atualizado");

            TxtNome.Text = ""; TxtCPF.Text = ""; TxtTelefone.Text = ""; TxtEmail.Text = ""; TxtCodigo.Text = "";
        }

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            {

                CadastroDAL objdal = new CadastroDAL();
                objdal.FichaCadastro(TxtNome.Text, TxtCPF.Text, TxtTelefone.Text, TxtEmail.Text);
                TxtNome.Text = ""; TxtCPF.Text = ""; TxtTelefone.Text = ""; TxtEmail.Text = ""; TxtCodigo.Text = "";

                dataGridView1.Visible = false;
                dataGridView1.Visible = true;

            }
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            //Buscar


            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Lu_Moura; Integrated Security = True; Connect Timeout = 30; Encrypt = False");
            conn.Open();

            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Cliente where idCliente= '" + TxtCodigo.Text + "'", conn);

            //var dr = cmd.ExecuteReader();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr == null)
            {
                MessageBox.Show("Cliente não Encontrado!");
            }

            else
            {
                if (dr.Read())
                {

                    TxtNome.Text = dr["Nome"].ToString();
                    TxtCPF.Text = dr["CPF"].ToString();
                    TxtTelefone.Text = dr["Telefone"].ToString();
                    TxtEmail.Text = dr["Email"].ToString();

                }

            }
        }

        private void BtAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar(TxtNome.Text, TxtCPF.Text, TxtTelefone.Text, TxtEmail.Text);

            dataGridView1.Visible = false;
            dataGridView1.Visible = true;
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {

            int IdCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCliente"].Value);

            using (SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Lu_Moura; Integrated Security = True; Connect Timeout = 30; Encrypt = False"))


            //using (SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE IdCliente = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", IdCliente);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);


                        MessageBox.Show("Cadastro Excluído com Sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao Excluir o Cadastro.");
                    }

                    TxtNome.Text = ""; TxtCPF.Text = ""; TxtTelefone.Text = ""; TxtEmail.Text = ""; TxtCodigo.Text = ""; TxtCodigo.Text = "";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Lu_Moura; Integrated Security = True; Connect Timeout = 30; Encrypt = False");
            conn.Open();

            //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource bs = new BindingSource();
            bs.DataSource = dr;
            dataGridView1.DataSource = bs;
        }
    }
}
