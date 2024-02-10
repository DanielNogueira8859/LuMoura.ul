using Guna.UI2.WinForms;
using LuMoura.ul.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ProjetoIntegrador;
using Timer = System.Windows.Forms.Timer;

namespace LuMoura.ul
{

    public partial class Form2 : Form
    {
        private Timer dataRefreshTimer;

        private const string connectionString = @"Data Source=lumouraserver.database.windows.net;Initial Catalog=LUMOURA.DB;User ID=adminn;Password=#Lumoura;Connect Timeout=60;Encrypt=True;";
        private const int larguraOriginalDoFormulario = 816;
        private const int alturaOriginalDoFormulario = 489;
        
        public Form2()
        {
            InitializeComponent();
            // Initialize the timer
            dataRefreshTimer = new Timer();
            dataRefreshTimer.Interval = 200; // Set the interval in milliseconds (e.g., every minute)
            dataRefreshTimer.Tick += DataRefreshTimer_Tick;
            dataRefreshTimer.Start(); // Start the timer
        }
        private void DataRefreshTimer_Tick(object sender, EventArgs e)
        {
            // Call the method to load appointments for today
            LoadAppointmentsForToday();
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
        private void Form2_Load(object sender, EventArgs e)
        {
            
            AdicionarBotoes();
            AjustarLayout();
            AdicionarDataGrids();
            AdicionarTexts();
            AdicionarHtmls();
            LoadAppointmentsForToday();



        }
        //objetos a ser manipulados
        private void AdicionarBotoes()
        {
            AdicionarBotao(guna2Button1);
            AdicionarBotao(guna2Button2);
            AdicionarBotao(guna2Button10);
            AdicionarBotao(guna2Button4);
            AdicionarBotao(guna2Button5);

        }
        private void AdicionarDataGrids()
        {
            AdicionarDataGridView(guna2DataGridView1);
            

        }
        private void AdicionarTexts()
        {
            
        }
        
        private void AdicionarHtmls()
        {
            AdicionarHtml(guna2HtmlLabel1);
            
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
        
        private void AdicionarHtml(Guna2HtmlLabel Html)
        {
            ListaGlobal.Htmls.Add(Html);
            ListaGlobal.PosicoesOriginaisHtml[Html] = new Rectangle(Html.Location, Html.Size);
        }
        


        //fim

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

        private void LoadAppointmentsForToday()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT AgendamentoID, NomeCliente, Telefone, Servico, Descricao
                         FROM Agendamentos
                         WHERE CONVERT(date, DataAgendamento) = CONVERT(date, GETDATE())";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    guna2DataGridView1.DataSource = dataTable;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ControleCadastroADM controleCadastroADM = new ControleCadastroADM();
            controleCadastroADM.Show();

            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AgendarHorarios agendarHorarios = new AgendarHorarios();
            agendarHorarios.Show();

            this.Hide();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            AtualizarAgendamentos atualizarAgendamentos = new AtualizarAgendamentos();
            atualizarAgendamentos.Show();

            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AdicionarServicos adicionarServicos = new AdicionarServicos();
            adicionarServicos.Show();
            this.Hide();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AtualizarServicos atualizarServicos = new AtualizarServicos();
            atualizarServicos.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
