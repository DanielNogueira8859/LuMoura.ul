using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebLuMoura
{
	public partial class LoginUsuarioWeb : System.Web.UI.Page
	{

        private const string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";

        protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void TextLogin_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextSenha_TextChanged(object sender, EventArgs e)
        {

        }
        private int AutenticarUsuario(string usuario, string senha)
        {
            // Aqui você deve implementar a consulta SQL para autenticação
            // Retorna o IdCliente se a autenticação for bem-sucedida, senão, retorna 0
            // Certifique-se de utilizar parâmetros para evitar injeção de SQL
            // Exemplo usando um SqlConnection e SqlCommand:

            int idCliente = 0;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string consulta = "SELECT FKCliente FROM Login WHERE Login = @Usuario AND Senha = @Senha";

                using (SqlCommand comando = new SqlCommand(consulta, conexao))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.Parameters.AddWithValue("@Senha", senha);

                    conexao.Open();
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        idCliente = Convert.ToInt32(resultado);
                    }
                }
            }

            return idCliente;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Lu_Moura; Integrated Security = True; Connect Timeout = 30; Encrypt = False";

            //string connectionString = @"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string connectionString = (@"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;");

            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    if (string.IsNullOrWhiteSpace(TextLogin.Text) || string.IsNullOrWhiteSpace(TextSenha.Text))
                    {

                    }

                    string query = "SELECT * FROM Login WHERE Login = @Login AND Senha = @Senha";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", TextLogin.Text);
                        command.Parameters.AddWithValue("@Senha", TextSenha.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                string usuario = TextLogin.Text;
                                string senha = TextSenha.Text;
                                int idCliente = AutenticarUsuario(usuario, senha);

                                if (idCliente > 0)
                                {
                                    // Autenticação bem-sucedida
                                    Session["IdCliente"] = idCliente;
                                    Response.Redirect("Calendar.aspx");
                                }
                                else
                                {
                                    // Autenticação falhou
                                    string mensagem = "alert('Login ou senha errado.');"; ScriptManager.RegisterStartupScript(this, this.GetType(), "exemploScript", mensagem, true);

                                }
                                
                                
                            }
                            else
                            {
                                string mensagem = "alert('Login ou senha errado.');"; ScriptManager.RegisterStartupScript(this, this.GetType(), "exemploScript", mensagem, true);
                            }
                        }
                    }
                }


            }
        }
    }
}