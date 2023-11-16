
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuMoura.ul
{
    internal class CadastroDAL
    {
       
            public int FichaCadastro(string Nome, string CPF, string Telefone, string Email)
            {
                SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Lu_Moura; Integrated Security = True; Connect Timeout = 30; Encrypt = False");
                conn.Open();

                //SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False");
                //conn.Open();


                SqlCommand cmd = new SqlCommand("insert into Cliente output inserted.idCliente values('" + Nome + " ','" + CPF + "',' " + Telefone + " ',' " + Email + " ', getdate())", conn);
                int idCliente = Convert.ToInt32(cmd.ExecuteScalar());

            //bfdbfgbgbvbv
                 
                conn.Close();

            

            MessageBox.Show("dados salvo");

          

            return idCliente;


            }
       







    }
}
