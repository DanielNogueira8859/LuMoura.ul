using LuMoura.ul.DAL;
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
    public partial class AtualizarAgendamento : Form
    {
        //usar senac
        private const string connectionString = "Data Source=FAC0539709W10-1;Initial Catalog=LuMoura.DB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;";

        //usar em casa
        //private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LuMoura.DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";


        public AtualizarAgendamento()
        {
            InitializeComponent();


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarAgendamento_Load(object sender, EventArgs e)
        {


           

           
        }
        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboServicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = monthCalendar2.SelectionStart;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora1(dataGridView2, dataFormatada);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }


        private void button5_Click(object sender, EventArgs e)
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

        private void PreencherInformacoes()
        {
            //if (dataGridView2.SelectedRows.Count > 0)
            //{
            //    int rowIndex = dataGridView2.SelectedRows[0].Index;

            //    // Obtém a data selecionada do MonthCalendar2
            //    DateTime dataSelecionada = monthCalendar2.SelectionStart;

            //    // Obtém o valor da coluna Hora da linha selecionada
            //    string horaSelecionada = dataGridView2.Rows[rowIndex].Cells["Hora"].Value.ToString();

            //    // Recupera as informações do serviço selecionado no ComboBox
            //    string servicoSelecionado = comboServicos.SelectedItem?.ToString();
            //    if (string.IsNullOrEmpty(servicoSelecionado))
            //    {
            //        MessageBox.Show("Selecione um serviço primeiro.");
            //        return;
            //    }

            //    // Obtém as informações do serviço do banco de dados com base no serviço selecionado
            //    AgendamentoService agendamentoService = new AgendamentoService();
            //    agendamentoService.NomeAndTempo(servicoSelecionado, textPreco, textDuracao);

            //    // Preenche as TextBox com as informações obtidas
            //    textData.Text = dataSelecionada.ToString("yyyy-MM-dd");
            //    textHorario.Text = horaSelecionada;
            //}
            //else
            //{
            //    MessageBox.Show("Selecione um horário primeiro.");
            //}
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void comboServicos_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar2_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = monthCalendar2.SelectionStart;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora1(dataGridView2, dataFormatada);
        }

        private void textNome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textDescricao_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textTelefone_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textDuracao_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textPreco_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            PreencherInformacoes();
        }

        private void textHorario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textData_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtém o AgendamentoID da linha selecionada no dataGridView1
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    int agendamentoID = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["AgendamentoID"].Value);

                    // Obtém os novos valores dos controles
                    string novoNome = textNome.Text;
                    string novoTelefone = textTelefone.Text;
                    string novaDescricao = textDescricao.Text;
                    string novoServico = comboServicos.Text;

                    // Obtém a nova data selecionada no monthCalendar1
                    DateTime novaDataSelecionada = monthCalendar1.SelectionStart;
                    string novaDataFormatada = novaDataSelecionada.ToString("yyyy-MM-dd");

                    // Obtém o novo horário selecionado na dataGridView2
                    int novoHorarioID = 0;
                    if (dataGridView2.SelectedRows.Count > 0)
                    {
                        int horarioRowIndex = dataGridView2.SelectedRows[0].Index;
                        novoHorarioID = Convert.ToInt32(dataGridView2.Rows[horarioRowIndex].Cells["HorarioID"].Value);
                    }
                    else
                    {
                        MessageBox.Show("Selecione um novo horário antes de atualizar.");
                        return;
                    }

                    // Chama o método para atualizar o agendamento
                    AgendamentoService agendamentoService = new AgendamentoService();
                    agendamentoService.AtualizarAgendamento(agendamentoID, novoNome, novoTelefone, novaDescricao, novoServico, novaDataFormatada, novoHorarioID);

                    MessageBox.Show("Agendamento atualizado com sucesso.");
                    AgendamentoService agendamentoService1 = new AgendamentoService();
                    agendamentoService1.ExibirAgendaTudo(dataGridView1);

                    DateTime dataSelecionada = monthCalendar2.SelectionStart;
                    string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
                    AgendamentoService horario = new AgendamentoService();
                    horario.exibirHora1(dataGridView2, dataFormatada);
                    textNome.Text = "";
                    textDescricao.Text = "";
                    textTelefone.Text = "";
                    textData.Text = "";
                    textHorario.Text = "";
                    textPreco.Text = "";
                    textDuracao.Text = "";

                }
                else
                {
                    MessageBox.Show("Selecione um agendamento antes de atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar agendamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Obtém o valor da coluna AgendamentoID da linha selecionada
                int agendamentoID = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["AgendamentoID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Verifica se realmente deseja excluir o agendamento
                    DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este agendamento?", "Confirmação", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM Agendamentos WHERE AgendamentoID = @AgendamentoID", conn))
                        {
                            cmdDelete.Parameters.AddWithValue("@AgendamentoID", agendamentoID);

                            int rowsAffected = cmdDelete.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Agendamento excluído com sucesso!");
                                // Limpa os campos após a exclusão
                                textNome.Text = "";
                                textTelefone.Text = "";
                                textDescricao.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível excluir o agendamento.");
                            }
                        }
                    }
                }
            }

            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaTudo(dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Obtém o valor da coluna AgendamentoID da linha selecionada
                int agendamentoID = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["AgendamentoID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Agendamentos WHERE AgendamentoID = @AgendamentoID", conn))
                    {
                        cmd.Parameters.AddWithValue("@AgendamentoID", agendamentoID);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                textNome.Text = dr["NomeCliente"].ToString();
                                textTelefone.Text = dr["Telefone"].ToString();
                                textDescricao.Text = dr["Descricao"].ToString();
                                comboServicos.Text = dr["Servico"].ToString();
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaServico(dataGridView1, comboBox1.Text);
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaDescricao(dataGridView1, textBox5.Text);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = monthCalendar1.SelectionStart;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");

            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaData(dataGridView1, dataFormatada);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

            // Remove caracteres não numéricos
            string currentText = new string(textBox4.Text.Where(char.IsDigit).ToArray());

            // Obtém a posição atual do cursor
            int cursorPosition = textBox4.SelectionStart;

            // Remove o evento TextChanged para evitar um loop infinito
            textBox4.TextChanged -= textBox4_TextChanged;

            // Formata o número de telefone
            if (currentText.Length >= 1)
            {
                textBox4.Text = string.Format("({0}", currentText.Substring(0, Math.Min(2, currentText.Length)));

                if (currentText.Length > 2)
                {
                    textBox4.Text += string.Format(") {0}", currentText.Substring(2, Math.Min(5, currentText.Length - 2)));

                    if (currentText.Length > 7)
                    {
                        textBox4.Text += string.Format("-{0}", currentText.Substring(7, Math.Min(4, currentText.Length - 7)));
                    }
                }
            }

            // Restaura o evento TextChanged
            textBox4.TextChanged += textBox4_TextChanged;

            // Define a posição do cursor após a formatação
            textBox4.SelectionStart = cursorPosition + 1;

            // Chama o método para exibir a agenda com base no telefone
            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaTelefone(dataGridView1, textBox4.Text);

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaNome(dataGridView1, textBox3.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarAgendamento_Load_1(object sender, EventArgs e)
        {
            DateTime dataSelecionada = monthCalendar2.SelectionStart;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora1(dataGridView2, dataFormatada);


            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaTudo(dataGridView1);
            string servicoSelecionado = comboBox1.SelectedItem?.ToString();

            // Verifica se há um item selecionado antes de chamar o método
            if (!string.IsNullOrEmpty(servicoSelecionado))
            {
                MessageBox.Show("nao");

            }

            else
            {
                AgendamentoService agendar = new AgendamentoService();
                agendar.Exibir_Servicos(comboBox1);
                agendar.Exibir_Servicos(comboServicos);
            }
        }
    }
}
