
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LuMoura.ul
{
    internal class CadastroDAL
    {
       
            public int FichaCadastro(string Nome, string CPF, string Telefone, string Email)
            {
                //SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Lu_Moura; Integrated Security = True; Connect Timeout = 30; Encrypt = False");
                //conn.Open();

                SqlConnection conn = new SqlConnection(@"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;");
                conn.Open();


                SqlCommand cmd = new SqlCommand("insert into Cliente output inserted.idCliente values('" + Nome + " ','" + CPF + "',' " + Telefone + " ',' " + Email + " ', getdate())", conn);
                int idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                 
                conn.Close();            

            MessageBox.Show("dados salvo");          

            return idCliente;
            }
      







    }
}
