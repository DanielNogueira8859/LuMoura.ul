using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LuMoura.ul;

namespace ProjetoIntegrador
{
    public partial class AtualizarServicos : Form
    {
        private const string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";

        public AtualizarServicos()
        {
            InitializeComponent();
        }

        #region métodos que disparam eventos
        public void BotaoBuscar()
        {
            SqlConnection conn = new SqlConnection(connectionString);


            {
                conn.Open();



                SqlCommand cmd = new SqlCommand("SELECT ServicoID, NomeServico, ValorServico from Servicos ORDER BY NomeServico desc", conn);



                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource bs = new BindingSource();
                bs.DataSource = dr;
                dataGridView1.DataSource = bs;
            }
        }
        #endregion


        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            BotaoBuscar();

        }
        
        private void BtAtualizar_Click(object sender, EventArgs e)
        {
            DAL.ServicosDAL mensagem = new DAL.ServicosDAL();
            mensagem.Atualizar(textBoxNome2.Text, textBoxDes1.Text, Convert.ToDecimal(textBoxValor1.Text), Convert.ToInt32(textBoxTempo1.Text), Convert.ToInt32(textBoxID1.Text));
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxValor1.Text, out int servicoIdToDelete))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Use parameterized query to avoid SQL injection
                        string deleteQuery = "DELETE FROM Servicos WHERE ServicoID = @ServicoID";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ServicoID", servicoIdToDelete);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Serviço Cancelado!");
                                // Optionally, you may rebind the grid or update the display after deletion
                                BotaoBuscar();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum serviço encontrado com o ID fornecido.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Informe um valor numérico válido para o ID do serviço.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar o serviço: " + ex.ToString());
            }
        }

    }
}
