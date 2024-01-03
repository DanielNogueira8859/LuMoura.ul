using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLuMoura
{
    public partial class WebLuMoura1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idQVeioDaUrl = Request.QueryString["id"].ToString();

            LblId.Text = idQVeioDaUrl;



        }

        protected void BtnCadastra_Click(object sender, EventArgs e)
        {
            string nome = TxtNome.Text;
            string sobrenome = TxtSobreNome.Text;
            string endereco = TxtBox1.Text;
            string senha = TxtSenha.Text;
            string confirmar = TextConfirmar.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (Nome, SobreNome, Endereco, Senha, Confirmar) VALUES (@nome, @sobrenome, @endereco, @senha, @confirmar)",
                conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@confirmar", confirmar);

            cmd.ExecuteNonQuery();

            // Iniciar o load
            System.Threading.Thread.Sleep(5000);


            conn.Close();

            Response.Redirect("webform1.aspx?id=2");
            //Server.Transfer("https://google.com"); utilizado mais para WebForm
        }
    }
  }
