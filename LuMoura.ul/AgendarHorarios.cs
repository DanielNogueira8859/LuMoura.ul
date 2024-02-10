using Guna.UI2.WinForms;
using LuMoura.ul.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LuMoura.ul
{
    public partial class AgendarHorarios : Form
    {
        private const string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";     
        private const int larguraOriginalDoFormulario = 977;
        private const int alturaOriginalDoFormulario = 516;

        public AgendarHorarios()
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
        //objetos a ser manipulados
        private void AdicionarBotoes()
        {
            AdicionarBotao(guna2Button1cadastrar);
            AdicionarBotao(guna2Button2atualizar);
            AdicionarBotao(guna2Button3PreencherDados);
            AdicionarBotao(guna2ButtonCadastrar);
            AdicionarBotao(guna2ButtonCompletar);
            AdicionarBotao(guna2ButtonExl_Atl);
            AdicionarBotao(guna2ButtonMenu);
        }
        private void AdicionarDataGrids()
        {
            AdicionarDataGridView(guna2DataGridView1exibirClientes);
            AdicionarDataGridView(guna2DataGridViewHorarios);

        }
        private void AdicionarTexts()
        {
            AdicionarText(guna2TextNome);
            AdicionarText(guna2TextTelefone);
            AdicionarText(guna2TextDescricao);
            AdicionarText(guna2TextDuracao);
            AdicionarText(guna2TextHorario);
            AdicionarText(guna2TextPreco);
            AdicionarText(guna2TextData);
        }
        private void AdicionarCombos()
        {
            AdicionarCombo(guna2ComboServicos);
        }
        private void AdicionarHtmls()
        {
            AdicionarHtml(guna2HtmlNome);
            AdicionarHtml(guna2HtmlDescricao);
            AdicionarHtml(guna2HtmlTelefone);
            AdicionarHtml(guna2HtmlLabelData);
            AdicionarHtml(guna2HtmlLabelDuracao);
            AdicionarHtml(guna2HtmlLabelHorario);
            AdicionarHtml(guna2HtmlLabelPreco);
            AdicionarHtml(guna2HtmlLabelServico);
        }
        private void AdicionarAgendads()
        {
            AdicionarAgenda(guna2DateTimePickerData);
        }
        //adicionar a lista
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


        //fim

        private void guna2Button1cadastrar_Click(object sender, EventArgs e)
        {
            ControleCadastroADM controleCadastroADM = new ControleCadastroADM();
            controleCadastroADM.Show();
        }

        private void guna2Button2atualizar_Click(object sender, EventArgs e)
        {
            AgendamentoService agendar = new AgendamentoService();
            agendar.Atualizar(guna2DataGridView1exibirClientes);
        }

        private void guna2Button3PreencherDados_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1exibirClientes.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1exibirClientes.SelectedRows[0].Index;
                int idCliente = Convert.ToInt32(guna2DataGridView1exibirClientes.Rows[rowIndex].Cells["IdCliente"].Value);

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

        private void guna2DataGridView1exibirClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para a célula clicada no DataGridView
        }

        private void guna2TextNome_TextChanged(object sender, EventArgs e)
        {
            AgendamentoService horario = new AgendamentoService();
            horario.Exibir(guna2DataGridView1exibirClientes, guna2TextNome.Text);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AjustarLayout();
            AjustarLayoutData();
            AjustarLayoutText();
            AjustarLayoutHtml();
            AjustarLayoutCombo();
            AjustarLayoutAgenda();


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

        private void guna2HtmlNome_Click(object sender, EventArgs e)
        {
            // Lógica quando o controle guna2HtmlNome é clicado
        }

        private void guna2HtmlTelefone_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextTelefone_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextDescricao_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2HtmlDescricao_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextDuracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ButtonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter dados do formulário
                DateTime dataSelecionada = guna2DateTimePickerData.Value;
                string dataFormatada = dataSelecionada.ToString("dd/MM/yyyy");

                string nome = guna2TextNome.Text;
                string telefone = guna2TextTelefone.Text;
                string servico = guna2ComboServicos.Text;
                string descricao = guna2TextDescricao.Text;

                // Validar dados
                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(servico))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Chamar o serviço de agendamento
                AgendamentoService agendar = new AgendamentoService();
                agendar.agendar(dataFormatada, nome, telefone, servico, descricao, guna2DataGridViewHorarios, servico);

                // Exibir horários após o agendamento
                AgendamentoService horario = new AgendamentoService();
                horario.exibirHora(guna2DataGridViewHorarios, dataFormatada);

                MessageBox.Show("Horário agendado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar agendamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2ButtonCompletar_Click(object sender, EventArgs e)
        {
            try
            {
                AgendamentoService agendar = new AgendamentoService();

                // Obtém a data e horário formatados
                Tuple<string, string> dataHorarioTuple = agendar.Completar(guna2DateTimePickerData.Value, guna2DataGridViewHorarios);

                // Atribui os valores aos controles
                guna2TextData.Text = dataHorarioTuple.Item1;
                guna2TextHorario.Text = dataHorarioTuple.Item2;

                // Exibe os horários disponíveis no DataGridView
                agendar.exibirHora(guna2DataGridViewHorarios, guna2DateTimePickerData.Value.ToString("dd-MM-yyyy"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2ButtonMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            //fecha a pagina
            this.Hide();
        }

        private void guna2ButtonExl_Atl_Click(object sender, EventArgs e)
        {
            AtualizarAgendamentos atualizarAgendamento = new AtualizarAgendamentos();
            atualizarAgendamento.Show();
        }

        private void guna2TextPreco_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextHorario_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextData_TextChanged(object sender, EventArgs e)
        {
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

        private void guna2HtmlLabelHorario_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabelPreco_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabelDuracao_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabelData_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabelServico_Click(object sender, EventArgs e)
        {
        }

        private void guna2DataGridViewHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AgendamentoService agendar = new AgendamentoService();

                // Obtém a data e horário formatados
                Tuple<string, string> dataHorarioTuple = agendar.Completar(guna2DateTimePickerData.Value, guna2DataGridViewHorarios);

                // Atribui os valores aos controles
                guna2TextData.Text = dataHorarioTuple.Item1;
                guna2TextHorario.Text = dataHorarioTuple.Item2;

                // Exibe os horários disponíveis no DataGridView
                agendar.exibirHora(guna2DataGridViewHorarios, guna2DateTimePickerData.Value.ToString("dd-MM-yyyy"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void guna2DateTimePickerData_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePickerData.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora(guna2DataGridViewHorarios, dataFormatada);

            try
            {
                AgendamentoService agendar = new AgendamentoService();

                // Obtém a data e horário formatados
                Tuple<string, string> dataHorarioTuple = agendar.Completar(guna2DateTimePickerData.Value, guna2DataGridViewHorarios);

                // Atribui os valores aos controles
                guna2TextData.Text = dataHorarioTuple.Item1;
                guna2TextHorario.Text = dataHorarioTuple.Item2;

                // Exibe os horários disponíveis no DataGridView
                agendar.exibirHora(guna2DataGridViewHorarios, guna2DateTimePickerData.Value.ToString("dd-MM-yyyy"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dataSelecionada = guna2DateTimePickerData.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            AgendamentoService horario = new AgendamentoService();
            horario.exibirHora(guna2DataGridViewHorarios, dataFormatada);



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
            AgendamentoService agendarr = new AgendamentoService();
            agendarr.Atualizar(guna2DataGridView1exibirClientes);
        }

        private void guna2ButtonCadastrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
