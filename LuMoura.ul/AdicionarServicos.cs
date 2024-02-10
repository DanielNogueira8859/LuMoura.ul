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
    public partial class AdicionarServicos : Form
    {
        public AdicionarServicos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            //fecha a pagina
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtAtualizar_Click(object sender, EventArgs e)
        {
            DAL.ServicosDAL mensagem = new DAL.ServicosDAL();
            mensagem.AdicionarServico(textBoxNome.Text, textBoxDes.Text, Convert.ToDecimal(textBoxValor.Text), Convert.ToInt32(textBoxTempo.Text));
           
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarServicos_Load(object sender, EventArgs e)
        {

        }
    }
}