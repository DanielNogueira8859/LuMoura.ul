using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LuMoura.Web
{
    public partial class Pagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.QueryString.HasKeys())
            {
                // Obtém o valor associado à chave "chave"
                string valorChave = Request.QueryString["chave"];

                // Exibe o valor na página
                resultadoLabel.Text = "Valor da chave: " + valorChave;
            }

            // Redirecionar para outra página com um novo parâmetro
            Response.Redirect("WebForm1.aspx?novaChave=20");
            // Ou redirecionar para outra página sem adicionar parâmetros
            // Response.Redirect("OutraPagina.aspx");

            // Importante: a execução não continua aqui após o redirecionamento

        }
    }
}