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
    public partial class ExcluirServico : Form
    {
        public ExcluirServico()
        {
            InitializeComponent();
        }

        #region métodos que disparam eventos
        public void BotaoBuscar()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetoIntegrador;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            {
                conn.Open();



                SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdServicos, NomeServicos, ValorServicos from servicos ORDER BY DataeHora desc", conn);



                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource bs = new BindingSource();
                bs.DataSource = dr;
                dataGridView1.DataSource = bs;
            }
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            DAL.ServicosDAL mensagem = new DAL.ServicosDAL();
            mensagem.ExcluirServico(Convert.ToInt32(textBoxId.Text));
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BotaoBuscar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
