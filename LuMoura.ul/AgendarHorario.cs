using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuMoura.ul
{
    public partial class AgendarHorario : Form
    {
        private readonly string connectionString ="Data Source=FAC0539709W10-1;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public AgendarHorario()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            Agendar horario = new Agendar();
            horario.Exibir(dataGridView1, textNome.Text);

        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboServiço_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtém o item selecionado no ComboBox
            string servicoSelecionado = comboServiço.SelectedItem?.ToString();

            // Verifica se há um item selecionado antes de chamar o método
            if (!string.IsNullOrEmpty(servicoSelecionado))
            {
                comboServiço.Text = servicoSelecionado;

                Agendar agendar = new Agendar();
                agendar.NomeAndTempo(servicoSelecionado, textPreco, textDuracao);
            }
            else
            {
                MessageBox.Show("Serviço não selecionado!");
            }
        }


        private void BtnCadastar_Click(object sender, EventArgs e)
        {
            DateTime dataSelecionada = monthCalendar1.SelectionStart;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd HH:mm:ss");

            Agendar agendar = new Agendar();
            agendar.agendar(dataFormatada, textNome.Text, textTelefone.Text, comboServiço.Text, textDescricao.Text, dataGridView2, comboServiço.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textDescricao_TextChanged(object sender, EventArgs e)
        {
            //Agendar agendar = new Agendar();
            //agendar.agendar(textNome.Text, textTelefone.Text,comboServiço.Text, textDescricao.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControleCadastroADM controleCadastroADM = new ControleCadastroADM();
            controleCadastroADM.Show();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agendar agendar = new Agendar();
            agendar.Atualizar(dataGridView1);
        }

        private void AgendarHorario_Load(object sender, EventArgs e)
        {

            Agendar horario = new Agendar();
            horario.exibirHora(dataGridView2);

            string servicoSelecionado = comboServiço.SelectedItem?.ToString();

            // Verifica se há um item selecionado antes de chamar o método
            if (!string.IsNullOrEmpty(servicoSelecionado))
            {
                MessageBox.Show("nao");

            }

            else
            {
                Agendar agendar = new Agendar();
                agendar.Exibir_Servicos(comboServiço);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int idCliente = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["IdCliente"].Value);

                SqlConnection conn = new SqlConnection(@"Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;");

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE IdCliente = @IdCliente", conn);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.ExecuteNonQuery();
                
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            textNome.Text = dr["Nome"].ToString();
                            textTelefone.Text = dr["Telefone"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cliente não Encontrado!");
                        }

                    
                
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textData_TextChanged(object sender, EventArgs e)
        {

        }

        private void textHorario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDuracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Agendar agendar = new Agendar();
            string dataFormatada = agendar.Completar(monthCalendar1.SelectionStart, dataGridView2, textHorario);
            textData.Text = dataFormatada;

            Agendar horario = new Agendar();
            horario.exibirHora(dataGridView2);



        }

        private void button7_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();

            //fecha a pagina
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}