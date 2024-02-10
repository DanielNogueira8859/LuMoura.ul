using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLuMoura
{
    public partial class Cadastro2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ErrorMessageLabel.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Verifica se o login já existe no banco de dados
            if (LoginExists(TextLogin.Text))
            {
                ErrorMessageLabel.Text = "Este login já está em uso. Por favor, escolha outro.";
                return;
            }

            // Se o login não existe, continua com o processo de cadastro
            int idCliente = FichaCadastro(TextNome.Text, TextCPF.Text, TextTelefone.Text, TextEmail.Text, TextLogin.Text, TextSenha.Text);

            TextNome.Text = ""; TextCPF.Text = ""; TextTelefone.Text = ""; TextEmail.Text = ""; TextLogin.Text = ""; TextSenha.Text = "";
            Response.Redirect("Webform4.aspx");
        }
        private bool LoginExists(string login)
        {
            // Conectar ao banco de dados
            using (SqlConnection conn = new SqlConnection(@"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;"))
            {
                conn.Open();

                // Consulta para verificar se o login já existe
                string query = "SELECT COUNT(*) FROM Login WHERE Login = @Login";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Login", login);

                    // Se o login já existe, retorna true
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private bool ValidateForm()
        {
            // Verifica se os campos estão preenchidos
            if (string.IsNullOrEmpty(TextNome.Text) || string.IsNullOrEmpty(TextCPF.Text) || string.IsNullOrEmpty(TextTelefone.Text) ||
                string.IsNullOrEmpty(TextEmail.Text) || string.IsNullOrEmpty(TextLogin.Text) || string.IsNullOrEmpty(TextSenha.Text))
            {
                // Exibe uma mensagem de erro
                ShowErrorMessage("Todos os campos são obrigatórios.");
                return false;
            }

            // Validação do telefone
            if (!IsValidPhoneNumber(TextTelefone.Text))
            {
                ShowErrorMessage("Número de telefone inválido. Use o formato (99) 99999-9999.");
                return false;
            }

            // Validação do CPF
            if (!IsValidCPF(TextCPF.Text))
            {
                ShowErrorMessage("CPF inválido. Use o formato 999.999.999-99.");
                return false;
            }

            // Validação do e-mail
            if (!IsValidEmail(TextEmail.Text))
            {
                ShowErrorMessage("E-mail inválido.");
                return false;
            }

            // Validação da senha
            if (!IsStrongPassword(TextSenha.Text))
            {
                ShowErrorMessage("A senha deve conter pelo menos 8 caracteres, incluindo letras maiúsculas, minúsculas, números e caracteres especiais.");
                return false;
            }

            return true;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\(\d{2}\) \d{5}-\d{4}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private bool IsValidCPF(string cpf)
        {
            string pattern = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
            return Regex.IsMatch(cpf, pattern);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsStrongPassword(string password)
        {
            return password.Length >= 8 && Regex.IsMatch(password, @"[A-Z]") && Regex.IsMatch(password, @"[a-z]") && Regex.IsMatch(password, @"\d") && Regex.IsMatch(password, @"[!@#$%^&*(),.?""':{}|<>]");
        }

        private void ShowErrorMessage(string message)
        {
            // Adicione um controle Label ou use um controle existente para exibir a mensagem de erro
            // Certifique-se de definir a propriedade CssClass para estilizar a mensagem de erro conforme necessário
            ErrorMessageLabel.Text = message;
            ErrorMessageLabel.Visible = true; // Torne a mensagem de erro visível
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
    }
}