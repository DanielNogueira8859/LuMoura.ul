using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLuMoura
{
    public partial class LoginGS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Logado"] == null)
            {
                if (Convert.ToBoolean(Session["Logado"]) != true)
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void BtnLogar_Click(object sender, EventArgs e)
        {
            Session["Logado"] = true;
            Session["nivelAcesso"] = "a";
            Session["email"] = "gustavo.garcia22@gmail.com";

            Response.Redirect("Index.aspx");
        }
    }
}