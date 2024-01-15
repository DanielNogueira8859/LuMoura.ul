using ProjetoIntegrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuMoura.ul
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AdicionarServicos form = new AdicionarServicos();
            form.Show();

            //fecha a pagina
            this.Hide();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            ControleCadastroADM form = new ControleCadastroADM();
            form.Show();

            //fecha a pagina
            this.Hide();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            AgendarHorario form = new AgendarHorario();
            form.Show();

            //fecha a pagina
            this.Hide();
        }
    }
}
