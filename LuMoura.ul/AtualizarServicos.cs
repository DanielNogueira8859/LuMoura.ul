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

namespace ProjetoIntegrador
{
    public partial class AtualizarServicos : Form
    {
        public AtualizarServicos()
        {
            InitializeComponent();
        }

        #region métodos que disparam eventos
        public void BotaoBuscar()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


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
            BotaoBuscar();  
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            DAL.ServicosDAL mensagem = new DAL.ServicosDAL();
            mensagem.Atualizar( textBoxNome.Text, textBoxDes.Text, Convert.ToDecimal(textBoxValor.Text), Convert.ToInt32(textBoxTempo.Text), Convert.ToInt32(textBoxID.Text));
            this.Hide();
        }
    }
}
