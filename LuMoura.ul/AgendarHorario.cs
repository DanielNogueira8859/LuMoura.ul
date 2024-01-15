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
using LuMoura.ul.DAL;
using static Jenga.Theme;

namespace LuMoura.ul
{
    public partial class AgendarHorario : Form
    {
        //usar em casa
        private const string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";

        // usar senac
        //private const string connectionString = "Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;";

        private Dictionary<string, List<string>> horariosDisponiveis = new Dictionary<string, List<string>>();



        public AgendarHorario()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            AgendamentoService horario = new AgendamentoService();
            horario.Exibir(guna2DataGridView1, guna2TextNome.Text);

        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboServiço_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void BtnCadastar_Click(object sender, EventArgs e)
        {

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



        private void AgendarHorario_Load(object sender, EventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePicker1.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora(guna2DataGridView2, dataFormatada);

            // Certifique-se de inicializar horariosDisponiveis
            horariosDisponiveis = new Dictionary<string, List<string>>();

            string servicoSelecionado = guna2ComboServicos.SelectedItem?.ToString();

            // Verifica se há um item selecionado antes de chamar o método
            if (!string.IsNullOrEmpty(servicoSelecionado))
            {
                MessageBox.Show("nao");
            }
            else
            {
                AgendamentoService agendar = new AgendamentoService();
                agendar.Exibir_Servicos(guna2ComboServicos);
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






        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastar_Click_1(object sender, EventArgs e)
        {

            try
            {
                int coluna = guna2DataGridView2.SelectedRows.Count;
                DateTime dataSelecionada = guna2DateTimePicker1.Value;
                string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");

                AgendamentoService agendar = new AgendamentoService();
                agendar.agendar(dataFormatada, guna2TextNome.Text, guna2TextTelefone.Text, guna2ComboServicos.Text, guna2TextDescricao.Text, guna2DataGridView2, guna2ComboServicos.Text);

                MessageBox.Show("Horário agendado com sucesso.");

                // Lógica para exibir a hora após o agendamento
                AgendamentoService horario = new AgendamentoService();
                horario.exibirHora(guna2DataGridView2, dataFormatada);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao agendar horário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();

            //fecha a pagina
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarAgendamento atualizarAgendamento = new AtualizarAgendamento();
            atualizarAgendamento.Show();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged_1(object sender, EventArgs e)
        {
            AgendamentoService horario = new AgendamentoService();
            horario.Exibir(guna2DataGridView1, guna2TextNome.Text);
        }

        private void textTelefone_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textDescricao_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboServiço_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textData_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textHorario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textDuracao_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textPreco_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1.SelectedRows[0].Index;
                int idCliente = Convert.ToInt32(guna2DataGridView1.Rows[rowIndex].Cells["IdCliente"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE IdCliente = @IdCliente", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                guna2TextNome.Text = dr["Nome"].ToString();
                                guna2TextTelefone.Text = dr["Telefone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Cliente não Encontrado!");
                            }
                        }
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            AgendamentoService agendar = new AgendamentoService();
            agendar.Atualizar(guna2DataGridView1);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ControleCadastroADM controleCadastroADM = new ControleCadastroADM();
            controleCadastroADM.Show();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void AgendarHorario_Load_1(object sender, EventArgs e)
        {

            DateTime dataSelecionada = guna2DateTimePicker1.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora(guna2DataGridView2, dataFormatada);




            string servicoSelecionado = guna2ComboServicos.SelectedItem?.ToString();

            // Verifica se há um item selecionado antes de chamar o método
            if (!string.IsNullOrEmpty(servicoSelecionado))
            {
                MessageBox.Show("nao");

            }

            else
            {
                AgendamentoService agendar = new AgendamentoService();
                agendar.Exibir_Servicos(guna2ComboServicos);

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePicker1.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora(guna2DataGridView2, dataFormatada);

        }

        private void AgendarHorario_Load_2(object sender, EventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePicker1.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora(guna2DataGridView2, dataFormatada);




            string servicoSelecionado = guna2ComboServicos.SelectedItem?.ToString();

            // Verifica se há um item selecionado antes de chamar o método
            if (!string.IsNullOrEmpty(servicoSelecionado))
            {
                MessageBox.Show("nao");

            }

            else
            {
                AgendamentoService agendar = new AgendamentoService();
                agendar.Exibir_Servicos(guna2ComboServicos);

            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ControleCadastroADM controleCadastroADM = new ControleCadastroADM();
            controleCadastroADM.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ControleCadastroADM controleCadastroADM = new ControleCadastroADM();
            controleCadastroADM.Show();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            AgendamentoService agendar = new AgendamentoService();
            agendar.Atualizar(guna2DataGridView1);
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1.SelectedRows[0].Index;
                int idCliente = Convert.ToInt32(guna2DataGridView1.Rows[rowIndex].Cells["IdCliente"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE IdCliente = @IdCliente", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                guna2TextNome.Text = dr["Nome"].ToString();
                                guna2TextTelefone.Text = dr["Telefone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Cliente não Encontrado!");
                            }
                        }
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void monthCalendar1_DateChanged_2(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePicker1.Value;
            string dataFormatada = dataSelecionada.ToString("dd/MM/yyyy");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora(guna2DataGridView2, dataFormatada);
        }

        private void textDuracao_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void textData_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void comboServiço_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void textHorario_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void textPreco_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void BtnCadastar_Click_2(object sender, EventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePicker1.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd HH:mm:s");

            AgendamentoService agendar = new AgendamentoService();
            agendar.agendar(dataFormatada, guna2TextNome.Text, guna2TextTelefone.Text, guna2ComboServicos.Text, guna2TextDescricao.Text, guna2DataGridView2, guna2ComboServicos.Text);
        }

        private void button6_Click_2(object sender, EventArgs e)
        {

        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();

            //fecha a pagina
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void textDescricao_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void textTelefone_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void textNome_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AgendamentoService agendar = new AgendamentoService();
            agendar.Atualizar(guna2DataGridView1);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1.SelectedRows[0].Index;
                int idCliente = Convert.ToInt32(guna2DataGridView1.Rows[rowIndex].Cells["IdCliente"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE IdCliente = @IdCliente", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                guna2TextNome.Text = dr["Nome"].ToString();
                                guna2TextTelefone.Text = dr["Telefone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Cliente não Encontrado!");
                            }
                        }
                    }
                }
            }
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            AgendamentoService horario = new AgendamentoService();
            horario.Exibir(guna2DataGridView1, guna2TextNome.Text);
        }

        private void guna2TextNome_TextChanged(object sender, EventArgs e)
        {
            AgendamentoService horario = new AgendamentoService();
            horario.Exibir(guna2DataGridView1, guna2TextNome.Text);
        }

        private void guna2ComboServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtém o item selecionado no ComboBox
            string servicoSelecionado = guna2ComboServicos.SelectedItem?.ToString();

            // Verifica se há um item selecionado antes de chamar o método
            if (!string.IsNullOrEmpty(servicoSelecionado))
            {
                guna2ComboServicos.Text = servicoSelecionado;

                // Cria um novo TextBox e atribui o texto do Guna2TextBox


                AgendamentoService agendar = new AgendamentoService();
                agendar.NomeAndTempo(servicoSelecionado, guna2TextPreco, guna2TextDuracao);
            }
            else
            {
                MessageBox.Show("Serviço não selecionado!");
            }
        }


        private void guna2TextData_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextHorario_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextDuracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AtualizarAgendamento atualizarAgendamento = new AtualizarAgendamento();
            atualizarAgendamento.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();

            //fecha a pagina
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {


            //AgendamentoService agendar = new AgendamentoService();
            //string dataFormatada = agendar.Completar(guna2DateTimePicker1.Value, guna2TextHorario);
            //guna2TextData.Text = dataFormatada;


            //AgendamentoService horario = new AgendamentoService();
            //horario.exibirHora(guna2DataGridView2, dataFormatada);
        }



        private void guna2Button7_Click(object sender, EventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePicker1.Value;
            string dataFormatada = dataSelecionada.ToString("dd/MM/yyyy");

            AgendamentoService agendar = new AgendamentoService();
            agendar.agendar(dataFormatada, guna2TextNome.Text, guna2TextTelefone.Text, guna2ComboServicos.Text, guna2TextDescricao.Text, guna2DataGridView2, guna2ComboServicos.Text);
        }

        private void guna2TextTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}