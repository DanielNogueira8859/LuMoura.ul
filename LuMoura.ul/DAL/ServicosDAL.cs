using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoIntegrador.DAL
{

    internal class ServicosDAL
    {
        private const string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public void AdicionarServico(string nome, string descricao, decimal valor, int horario)

        {
            string textoComVirgula = valor.ToString();
            string textoComPonto = textoComVirgula.Replace(",", ".");

            /// >ATUALIZAR< /// ADICIONAR LINK DO BANCO DE DADOS///
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Servicos values ('" + nome + "','" + descricao + "', " + textoComPonto + " , " + horario + " )", conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Serviço cadastrado com sucesso!");
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void ExcluirServico(int id)

        {
            /// >ATUALIZAR< /// ADICIONAR LINK DO BANCO DE DADOS///
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from Servicos where ServicoId= "+id+"", conn);
            

            cmd.ExecuteNonQuery();
            MessageBox.Show("Serviço Cancelado!");

        }

        public void Atualizar( string nome, string descricao, decimal valor, int horario, int id)

        {
            string textoComVirgula1 = valor.ToString();
            
            string textoComPonto1 = textoComVirgula1.Replace(",", ".");

            /// >ATUALIZAR< /// ADICIONAR LINK DO BANCO DE DADOS///
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            
            SqlCommand cmd = new SqlCommand("UPDATE Servicos SET NomeServico = '"+ nome +"', DescricaoServico = '" + descricao + "', ValorServico = " + textoComPonto1 + " , DuracaoEmHoras = "+ horario +"  where ServicoID = " + id, conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Serviço atualizado com sucesso!");
        }
    }



}
    