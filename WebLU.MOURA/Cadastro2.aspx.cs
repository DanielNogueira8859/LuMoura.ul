using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLuMoura
{
    public partial class Cadastro2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int FichaCadastro(string Nome, string CPF, string Telefone, string Email, string Login, string Senha)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;");
            conn.Open();


            SqlCommand cmd = new SqlCommand("insert into Cliente output inserted.idCliente values('" + Nome + " ','" + CPF + "',' " + Telefone + " ',' " + Email + " ', getdate())", conn);
            int idCliente = Convert.ToInt32(cmd.ExecuteScalar());

            SqlCommand cmd2 = new SqlCommand("insert into Login values('" + Login + "','" + Senha + "', '" + idCliente + "' )", conn);
            cmd2.ExecuteScalar();

            conn.Close();

            return idCliente;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FichaCadastro(TextNome.Text, TextCPF.Text, TextTelefone.Text, TextEmail.Text, TextLogin.Text, TextSenha.Text);

            TextNome.Text = ""; TextCPF.Text = ""; TextTelefone.Text = ""; TextEmail.Text = ""; TextLogin.Text = ""; TextSenha.Text = "";
        }
    }
}