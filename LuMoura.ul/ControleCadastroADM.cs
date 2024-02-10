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
            SqlConnection conn = new SqlConnection(@"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;");
            conn.Open();

            SqlCommand cmd = new SqlCommand("Update Cliente set Nome = '" + Nome + " ', CPF = '" + CPF + "',Telefone = '" + Telefone + "', Email = '" + Email + "' where IdCliente = '" + TxtCodigo.Text + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Atualizado");

            TxtNome.Text = ""; TxtCPF.Text = ""; TxtTelefone.Text = ""; TxtEmail.Text = ""; TxtCodigo.Text = "";
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
           
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            //Buscar


           

        }

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            


        }

        private void BtMenu_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();

            //fecha a pagina
            this.Hide();
        }

        private void BtAtualizar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void BtMenu_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtCadastrar_Click_1(object sender, EventArgs e)
        {
            CadastroDAL objdal = new CadastroDAL();
            objdal.FichaCadastro(TxtNome.Text, TxtCPF.Text, TxtTelefone.Text, TxtEmail.Text); TxtCodigo.Text = "";

            TxtNome.Text = ""; TxtCPF.Text = ""; TxtTelefone.Text = ""; TxtEmail.Text = ""; TxtCodigo.Text = "";
        }

        private void BtExcluir_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string loginSql = "DELETE FROM Cliente WHERE idCliente = @IdCliente";
                using (SqlCommand loginCmd = new SqlCommand(loginSql, conn))
                {
                    loginCmd.Parameters.AddWithValue("@IdCliente", int.Parse(TxtCodigo.Text));
                    loginCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Dados Excluidos com Sucesso.");

                conn.Close();

                TxtNome.Text = ""; TxtCPF.Text = ""; TxtTelefone.Text = ""; TxtEmail.Text = ""; TxtCodigo.Text = "";
            }
        }

        private void BtBuscar_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;");
            conn.Open();

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

            TxtNome.Text = ""; TxtCPF.Text = ""; TxtTelefone.Text = ""; TxtEmail.Text = "";
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource bs = new BindingSource();
            bs.DataSource = dr;
            dataGridView1.DataSource = bs;
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}