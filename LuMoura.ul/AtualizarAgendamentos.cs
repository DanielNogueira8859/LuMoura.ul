using Guna.UI2.WinForms;
using LuMoura.ul.DAL;
using ProjetoIntegrador;
using ServiceStack;
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
using static Jenga.Theme;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LuMoura.ul
{
    public partial class AtualizarAgendamentos : Form
    {
        private const string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";
        private const int larguraOriginalDoFormulario = 1126;
        private const int alturaOriginalDoFormulario = 559;

        public AtualizarAgendamentos()
        {
            InitializeComponent();
            AdicionarBotoes();
            AjustarLayout();
            AdicionarDataGrids();
            AdicionarTexts();
            AdicionarHtmls();
            AdicionarCombos();
            AdicionarAgendads();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePicker1Alterar.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora1(guna2DataGridView2Alterar, dataFormatada);


            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaTudo(guna2DataGridView1Pesquisa);
            string servicoSelecionado = guna2ComboBox1PesquisaServico.SelectedItem?.ToString();

            // Verifica se há um item selecionado antes de chamar o método
            if (!string.IsNullOrEmpty(servicoSelecionado))
            {
                MessageBox.Show("nao");

            }

            else
            {
                AgendamentoService agendar = new AgendamentoService();
                agendar.Exibir_Servicos(guna2ComboBox1PesquisaServico);
                agendar.Exibir_Servicos(guna2ComboBox2AlterarServicos);
            }
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
            AjustarLayout();
            AjustarLayoutData();
            AjustarLayoutText();
            AjustarLayoutHtml();
            AjustarLayoutCombo();
            AjustarLayoutAgenda();
        }

        private void AdicionarBotoes()
        {
            AdicionarBotao(guna2Button1PesquisaMenu);
            AdicionarBotao(guna2Button2PesquisaExcluir);
            AdicionarBotao(guna2Button3PesquisaCompletar);
            AdicionarBotao(guna2Button4AlterarPreencher);
            AdicionarBotao(guna2Button5AlterarAtualizar);
        }


        private void AdicionarDataGrids()
        {
            AdicionarDataGridView(guna2DataGridView1Pesquisa);
            AdicionarDataGridView(guna2DataGridView2Alterar);

        }

        private void AdicionarTexts()
        {
            AdicionarText(guna2TextBox10AlterarDurarcao);
            AdicionarText(guna2TextBox11AlterarValor);
            AdicionarText(guna2TextBox9AlterarHora);
            AdicionarText(guna2TextBox8AlterarData);
            AdicionarText(guna2TextBox7AlterarDescricao);
            AdicionarText(guna2TextBox6AlterarTelefone);
            AdicionarText(guna2TextBox5AlterarNome);
            AdicionarText(guna2TextBox3PesquisaDesacricao);
            AdicionarText(guna2TextBox2PesquisaTelefone);
            AdicionarText(guna2TextBox1PesquisaNome);
        }

        private void AdicionarHtmls()
        {
            AdicionarHtml(guna2HtmlLabel1);
            AdicionarHtml(guna2HtmlLabel2);
            AdicionarHtml(guna2HtmlLabel3);
            AdicionarHtml(guna2HtmlLabel4);
            AdicionarHtml(guna2HtmlLabel5);
            AdicionarHtml(guna2HtmlLabel6);
            AdicionarHtml(guna2HtmlLabel7);
            AdicionarHtml(guna2HtmlLabel8);
            AdicionarHtml(guna2HtmlLabel9);
            AdicionarHtml(guna2HtmlLabel10);
            AdicionarHtml(guna2HtmlLabel11);
            AdicionarHtml(guna2HtmlLabel12);
            AdicionarHtml(guna2HtmlLabel13);
            AdicionarHtml(guna2HtmlLabel14);
            AdicionarHtml(guna2HtmlLabel15);
            AdicionarHtml(guna2HtmlLabel16);
            AdicionarHtml(guna2HtmlLabel17);
            AdicionarHtml(guna2HtmlLabel18);
            AdicionarHtml(guna2HtmlLabel19);
        }

        private void AdicionarCombos()
        {
            AdicionarCombo(guna2ComboBox1PesquisaServico);
            AdicionarCombo(guna2ComboBox2AlterarServicos);

        }

        private void AdicionarAgendads()
        {
            AdicionarAgenda(guna2DateTimePicker1Alterar);
            AdicionarAgenda(guna2DateTimePicker1PesquisaData);

        }
        //adicionar a lisata
        private void AdicionarBotao(Guna2Button botao)
        {
            ListaGlobal.Botoes.Add(botao);
            ListaGlobal.PosicoesOriginais[botao] = new Rectangle(botao.Location, botao.Size);

        }
        private void AdicionarDataGridView(Guna2DataGridView dataGridView)
        {
            ListaGlobal.Datas.Add(dataGridView);
            ListaGlobal.PosicoesOriginaisData.Add(new Tuple<Guna2DataGridView, Rectangle>(dataGridView, new Rectangle(dataGridView.Location, dataGridView.Size)));

        }
        private void AdicionarText(Guna2TextBox Text)
        {
            ListaGlobal.Textos.Add(Text);
            ListaGlobal.PosicoesOriginaisText[Text] = new Rectangle(Text.Location, Text.Size);
        }
        private void AdicionarHtml(Guna2HtmlLabel Html)
        {
            ListaGlobal.Htmls.Add(Html);
            ListaGlobal.PosicoesOriginaisHtml[Html] = new Rectangle(Html.Location, Html.Size);
        }
        private void AdicionarCombo(Guna2ComboBox Combo)
        {
            ListaGlobal.Combos.Add(Combo);
            ListaGlobal.PosicoesOriginaisCombo[Combo] = new Rectangle(Combo.Location, Combo.Size);
        }
        private void AdicionarAgenda(Guna2DateTimePicker Agenda)
        {
            ListaGlobal.Agendas.Add(Agenda);
            ListaGlobal.PosicoesOriginaisAgenda[Agenda] = new Rectangle(Agenda.Location, Agenda.Size);
        }

        //logicade ajust
        private void AjustarLayout()
        {
            float fatorEscalaX = (float)this.Width / larguraOriginalDoFormulario;
            float fatorEscalaY = (float)this.Height / alturaOriginalDoFormulario;

            foreach (Guna2Button botao in ListaGlobal.Botoes)
            {
                Rectangle posicaoOriginal = ListaGlobal.PosicoesOriginais[botao];

                botao.Left = (int)(posicaoOriginal.Left * fatorEscalaX);
                botao.Top = (int)(posicaoOriginal.Top * fatorEscalaY);
                botao.Width = (int)(posicaoOriginal.Width * fatorEscalaX);
                botao.Height = (int)(posicaoOriginal.Height * fatorEscalaY);
            }
        }
        private void AjustarLayoutData()
        {
            float fatorEscalaX = (float)this.Width / larguraOriginalDoFormulario;
            float fatorEscalaY = (float)this.Height / alturaOriginalDoFormulario;

            foreach (var tuple in ListaGlobal.PosicoesOriginaisData)
            {
                Guna2DataGridView dataGridView = tuple.Item1;
                Rectangle dataOriginal = tuple.Item2;

                dataGridView.Left = (int)(dataOriginal.Left * fatorEscalaX);
                dataGridView.Top = (int)(dataOriginal.Top * fatorEscalaY);
                dataGridView.Width = (int)(dataOriginal.Width * fatorEscalaX);
                dataGridView.Height = (int)(dataOriginal.Height * fatorEscalaY);
            }
        }
        private void AjustarLayoutText()
        {
            float fatorEscalaX = (float)this.Width / larguraOriginalDoFormulario;
            float fatorEscalaY = (float)this.Height / alturaOriginalDoFormulario;

            foreach (Guna2TextBox botao in ListaGlobal.Textos)
            {
                Rectangle posicaoOriginal = ListaGlobal.PosicoesOriginaisText[botao];

                botao.Left = (int)(posicaoOriginal.Left * fatorEscalaX);
                botao.Top = (int)(posicaoOriginal.Top * fatorEscalaY);
                botao.Width = (int)(posicaoOriginal.Width * fatorEscalaX);
                botao.Height = (int)(posicaoOriginal.Height * fatorEscalaY);
            }
        }
        private void AjustarLayoutHtml()
        {
            float fatorEscalaX = (float)this.Width / larguraOriginalDoFormulario;
            float fatorEscalaY = (float)this.Height / alturaOriginalDoFormulario;

            foreach (Guna2HtmlLabel botao in ListaGlobal.Htmls)
            {
                Rectangle posicaoOriginal = ListaGlobal.PosicoesOriginaisHtml[botao];

                botao.Left = (int)(posicaoOriginal.Left * fatorEscalaX);
                botao.Top = (int)(posicaoOriginal.Top * fatorEscalaY);
                botao.Width = (int)(posicaoOriginal.Width * fatorEscalaX);
                botao.Height = (int)(posicaoOriginal.Height * fatorEscalaY);
            }
        }
        private void AjustarLayoutCombo()
        {
            float fatorEscalaX = (float)this.Width / larguraOriginalDoFormulario;
            float fatorEscalaY = (float)this.Height / alturaOriginalDoFormulario;

            foreach (Guna2ComboBox botao in ListaGlobal.Combos)
            {
                Rectangle posicaoOriginal = ListaGlobal.PosicoesOriginaisCombo[botao];

                botao.Left = (int)(posicaoOriginal.Left * fatorEscalaX);
                botao.Top = (int)(posicaoOriginal.Top * fatorEscalaY);
                botao.Width = (int)(posicaoOriginal.Width * fatorEscalaX);
                botao.Height = (int)(posicaoOriginal.Height * fatorEscalaY);
            }
        }
        private void AjustarLayoutAgenda()
        {
            float fatorEscalaX = (float)this.Width / larguraOriginalDoFormulario;
            float fatorEscalaY = (float)this.Height / alturaOriginalDoFormulario;

            foreach (Guna2DateTimePicker botao in ListaGlobal.Agendas)
            {
                Rectangle posicaoOriginal = ListaGlobal.PosicoesOriginaisAgenda[botao];

                botao.Left = (int)(posicaoOriginal.Left * fatorEscalaX);
                botao.Top = (int)(posicaoOriginal.Top * fatorEscalaY);
                botao.Width = (int)(posicaoOriginal.Width * fatorEscalaX);
                botao.Height = (int)(posicaoOriginal.Height * fatorEscalaY);
            }
        }
        private void guna2DateTimePicker1Data_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePicker1PesquisaData.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");

            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaData(guna2DataGridView1Pesquisa, dataFormatada);
        }

        private void guna2TextBox1PesquisaNome_TextChanged(object sender, EventArgs e)
        {
            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaNome(guna2DataGridView1Pesquisa, guna2TextBox1PesquisaNome.Text);
        }

        private void guna2TextBox2PesquisaTelefone_TextChanged(object sender, EventArgs e)
        {
            // Remove caracteres não numéricos
            string currentText = new string(guna2TextBox2PesquisaTelefone.Text.Where(char.IsDigit).ToArray());

            // Obtém a posição atual do cursor
            int cursorPosition = guna2TextBox2PesquisaTelefone.SelectionStart;

            // Remove o evento TextChanged para evitar um loop infinito
            guna2TextBox2PesquisaTelefone.TextChanged -= guna2TextBox2PesquisaTelefone_TextChanged;

            // Formata o número de telefone
            if (currentText.Length >= 1)
            {
                guna2TextBox2PesquisaTelefone.Text = string.Format("({0}", currentText.Substring(0, Math.Min(2, currentText.Length)));

                if (currentText.Length > 2)
                {
                    guna2TextBox2PesquisaTelefone.Text += string.Format(") {0}", currentText.Substring(2, Math.Min(5, currentText.Length - 2)));

                    if (currentText.Length > 7)
                    {
                        guna2TextBox2PesquisaTelefone.Text += string.Format("-{0}", currentText.Substring(7, Math.Min(4, currentText.Length - 7)));
                    }
                }
            }
        }
        private void guna2TextBox3PesquisaDesacricao_TextChanged(object sender, EventArgs e)
        {
            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaDescricao(guna2DataGridView1Pesquisa, guna2TextBox3PesquisaDesacricao.Text);
        }

        private void guna2DataGridView1Pesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2Button1PesquisaMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            //fecha a pagina
            this.Hide();
        }

        private void guna2Button2PesquisaExcluir_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1Pesquisa.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1Pesquisa.SelectedRows[0].Index;

                // Obtém o valor da coluna AgendamentoID da linha selecionada
                int agendamentoID = Convert.ToInt32(guna2DataGridView1Pesquisa.Rows[rowIndex].Cells["AgendamentoID"].Value);

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
                                guna2TextBox1PesquisaNome.Text = "";
                                guna2TextBox2PesquisaTelefone.Text = "";
                                guna2TextBox3PesquisaDesacricao.Text = "";
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
            agendamentoService.ExibirAgendaTudo(guna2DataGridView1Pesquisa);

            DateTime dataSelecionada = guna2DateTimePicker1Alterar.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora1(guna2DataGridView2Alterar, dataFormatada);
        }

        private void guna2Button3PesquisaCompletar_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1Pesquisa.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1Pesquisa.SelectedRows[0].Index;

                // Obtém o valor da coluna AgendamentoID da linha selecionada
                int agendamentoID = Convert.ToInt32(guna2DataGridView1Pesquisa.Rows[rowIndex].Cells["AgendamentoID"].Value);

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
                                guna2TextBox5AlterarNome.Text = dr["NomeCliente"].ToString();
                                guna2TextBox6AlterarTelefone.Text = dr["Telefone"].ToString();
                                guna2TextBox7AlterarDescricao.Text = dr["Descricao"].ToString();
                                guna2ComboBox2AlterarServicos.Text = dr["Servico"].ToString();
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

        private void guna2TextBox5AlterarNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox6AlterarTelefone_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox7AlterarDescricao_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox1PesquisaServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgendamentoService agendamentoService = new AgendamentoService();
            agendamentoService.ExibirAgendaServico(guna2DataGridView1Pesquisa, guna2ComboBox1PesquisaServico.Text);
        }

        private void guna2DataGridView2Alterar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2TextBox8AlterarData_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox9AlterarHora_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox10AlterarDurarcao_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox11AlterarValor_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2Button4AlterarPreencher_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2Alterar.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView2Alterar.SelectedRows[0].Index;

                // Obtém a data selecionada do MonthCalendar2
                DateTime dataSelecionada = guna2DateTimePicker1Alterar.Value;

                // Obtém o valor da coluna Hora da linha selecionada
                string horaSelecionada = guna2DataGridView2Alterar.Rows[rowIndex].Cells["Hora"].Value.ToString();

                // Recupera as informações do serviço selecionado no ComboBox
                string servicoSelecionado = guna2ComboBox2AlterarServicos.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(servicoSelecionado))
                {
                    MessageBox.Show("Selecione um serviço primeiro.");
                    return;
                }

                // Obtém as informações do serviço do banco de dados com base no serviço selecionado
                AgendamentoService agendamentoService = new AgendamentoService();
                agendamentoService.NomeAndTempo(servicoSelecionado, guna2TextBox11AlterarValor, guna2TextBox10AlterarDurarcao);

                // Preenche as TextBox com as informações obtidas
                guna2TextBox8AlterarData.Text = dataSelecionada.ToString("yyyy-MM-dd");
                guna2TextBox9AlterarHora.Text = horaSelecionada;
            }
            else
            {
                MessageBox.Show("Selecione um horário primeiro.");
            }
        }

        private void guna2Button5AlterarAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2DataGridView1Pesquisa.SelectedRows.Count > 0)
                {
                    // Obtém o AgendamentoID da linha selecionada no dataGridView1
                    int rowIndex = guna2DataGridView1Pesquisa.SelectedRows[0].Index;
                    int agendamentoID = Convert.ToInt32(guna2DataGridView1Pesquisa.Rows[rowIndex].Cells["AgendamentoID"].Value);

                    // Obtém os novos valores dos controles
                    string novoNome = guna2TextBox5AlterarNome.Text;
                    string novoTelefone = guna2TextBox6AlterarTelefone.Text;
                    string novaDescricao = guna2TextBox7AlterarDescricao.Text;
                    string novoServico = guna2ComboBox2AlterarServicos.Text;

                    // Obtém a nova data selecionada no monthCalendar1
                    DateTime novaDataSelecionada = guna2DateTimePicker1Alterar.Value;
                    string novaDataFormatada = novaDataSelecionada.ToString("yyyy-MM-dd");

                    // Obtém o novo horário selecionado na dataGridView2
                    int novoHorarioID = 0;
                    if (guna2DataGridView2Alterar.SelectedRows.Count > 0)
                    {
                        int horarioRowIndex = guna2DataGridView2Alterar.SelectedRows[0].Index;
                        novoHorarioID = Convert.ToInt32(guna2DataGridView2Alterar.Rows[horarioRowIndex].Cells["HorarioID"].Value);
                    }
                    else
                    {
                        MessageBox.Show("Selecione um novo horário antes de atualizar.");
                        return;
                    }

                    // Chama o método para atualizar o agendamento
                    AgendamentoService agendamentoService = new AgendamentoService();
                    agendamentoService.AtualizarAgendamento(agendamentoID, novoNome, novoTelefone, novaDescricao, novoServico, novaDataFormatada, novoHorarioID);


                    AgendamentoService agendamentoService1 = new AgendamentoService();
                    agendamentoService1.ExibirAgendaTudo(guna2DataGridView1Pesquisa);

                    DateTime dataSelecionada = guna2DateTimePicker1Alterar.Value;
                    string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
                    AgendamentoService horario = new AgendamentoService();
                    horario.exibirHora1(guna2DataGridView2Alterar, dataFormatada);
                    guna2TextBox5AlterarNome.Text = "";
                    guna2TextBox7AlterarDescricao.Text = "";
                    guna2TextBox6AlterarTelefone.Text = "";
                    guna2TextBox8AlterarData.Text = "";
                    guna2TextBox9AlterarHora.Text = "";
                    guna2TextBox11AlterarValor.Text = "";
                    guna2TextBox10AlterarDurarcao.Text = "";

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
            DateTime dataSelecionada1 = guna2DateTimePicker1Alterar.Value;
            string dataFormatada1 = dataSelecionada1.ToString("yyyy-MM-dd");
            AgendamentoService horario1 = new AgendamentoService();
            horario1.exibirHora1(guna2DataGridView2Alterar, dataFormatada1);
        }

        private void guna2DateTimePicker1Alterar_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePicker1Alterar.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora1(guna2DataGridView2Alterar, dataFormatada);


        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox2AlterarServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel19_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel18_Click(object sender, EventArgs e)
        {
        }
    }
}
