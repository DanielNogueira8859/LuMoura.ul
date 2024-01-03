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
    public partial class ServicoFeito : Form
    {
        private readonly string connectionString = "Data Source=FAC0539709W10-1;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

       
        public ServicoFeito()
        {
            InitializeComponent();
        }

        private void ServicoFeito_Load(object sender, EventArgs e)
        {
            CarregarAgendamentos();


        }
        private void CarregarAgendamentos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Aqui estou usando um DataTable diretamente
                    DataTable dt = new DataTable();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Agendamentos", conn))
                    {
                        // Aqui o SqlDataAdapter para preencher diretamente o DataTable
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            // Preenchendo o DataTable com os resultados
                            da.Fill(dt);
                        }
                    }

                    // Atribuindo o DataTable ao DataSource do DataGridView
                    GridCliente.DataSource = dt;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar agendamentos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"SELECT
                                Agendamentos.AgendamentoID,
                                Agendamentos.DataAgendamento,
                                Agendamentos.NomeCliente,
                                Agendamentos.Telefone,
                                Agendamentos.Servico,
                                Agendamentos.Descricao,
                                Horarios.Hora AS HorarioAgendamento,
                                Servicos.NomeServico,
                                Servicos.DescricaoServico,
                                Servicos.ValorServico,
                                Servicos.DuracaoEmHoras
                            FROM
                                Agendamentos
                            JOIN
                                Horarios ON Agendamentos.FK_HorarioID = Horarios.HorarioID
                            JOIN
                                Servicos ON Agendamentos.FK_ServicoID = Servicos.ServicoID
                            WHERE
                                Agendamentos.DataAgendamento >= @SelectedDateStart
                                AND Agendamentos.DataAgendamento < @SelectedDateEnd";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDateStart", selectedDate);
                        cmd.Parameters.AddWithValue("@SelectedDateEnd", selectedDate.AddDays(1));

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            GridCliente.DataSource = dt;
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Livre: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtém o valor da data selecionada no MonthCalendar
                DateTime selectedDate = monthCalendar1.SelectionStart;

                // Filtra os registros do DataGridView para o dia selecionado
                DataView dv = new DataView((DataTable)GridCliente.DataSource);
                dv.RowFilter = $"DataAgendamento = '{selectedDate.ToShortDateString()}'";

                // Calcula a soma dos valores da coluna 'ValorServico'
                double totalValorServico = dv.ToTable().AsEnumerable().Sum(row => row.Field<double>("ValorServico"));

                // Exibe o total no TextBox
                textBox1.Text = totalValorServico.ToString("C2"); // Formatando como moeda
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular a soma: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuAppBar1_IconClick(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
