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
    public partial class AdicionarServicos : Form
    {
        public AdicionarServicos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.ServicosDAL mensagem = new DAL.ServicosDAL();
            mensagem.AdicionarServico(textBoxNome.Text, textBoxDes.Text, Convert.ToDecimal(textBoxValor.Text), Convert.ToInt32(textBoxTempo.Text)) ;
            this.Hide();
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}