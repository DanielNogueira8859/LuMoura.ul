namespace LuMoura.ul
{
    partial class AgendarHorario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar1 = new MonthCalendar();
            textNome = new TextBox();
            textTelefone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnCadastar = new Button();
            dataGridView1 = new DataGridView();
            comboServiço = new ComboBox();
            textDescricao = new TextBox();
            groupBox1 = new GroupBox();
            button6 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            textDuracao = new TextBox();
            textPreco = new TextBox();
            button5 = new Button();
            button4 = new Button();
            textHorario = new TextBox();
            textData = new TextBox();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(271, 204);
            monthCalendar1.Margin = new Padding(9, 9, 9, 10);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.TodayDate = new DateTime(2023, 11, 8, 0, 0, 0, 0);
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textNome
            // 
            textNome.Location = new Point(564, 29);
            textNome.Name = "textNome";
            textNome.Size = new Size(405, 23);
            textNome.TabIndex = 2;
            textNome.TextChanged += textNome_TextChanged;
            // 
            // textTelefone
            // 
            textTelefone.Location = new Point(564, 58);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(405, 23);
            textTelefone.TabIndex = 3;
            textTelefone.TextChanged += textTelefone_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 37);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 61);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 204);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Serviço";
            // 
            // BtnCadastar
            // 
            BtnCadastar.Location = new Point(794, 343);
            BtnCadastar.Name = "BtnCadastar";
            BtnCadastar.Size = new Size(175, 23);
            BtnCadastar.TabIndex = 8;
            BtnCadastar.Text = "Cadastar Horario";
            BtnCadastar.UseVisualStyleBackColor = true;
            BtnCadastar.Click += BtnCadastar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(480, 137);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboServiço
            // 
            comboServiço.FormattingEnabled = true;
            comboServiço.Location = new Point(564, 204);
            comboServiço.Name = "comboServiço";
            comboServiço.Size = new Size(405, 23);
            comboServiço.TabIndex = 10;
            comboServiço.SelectedIndexChanged += comboServiço_SelectedIndexChanged;
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(564, 87);
            textDescricao.Multiline = true;
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(405, 72);
            textDescricao.TabIndex = 11;
            textDescricao.TextChanged += textDescricao_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textDuracao);
            groupBox1.Controls.Add(textPreco);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textHorario);
            groupBox1.Controls.Add(textData);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Controls.Add(textDescricao);
            groupBox1.Controls.Add(comboServiço);
            groupBox1.Controls.Add(textNome);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textTelefone);
            groupBox1.Controls.Add(BtnCadastar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 420);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button6
            // 
            button6.Location = new Point(564, 314);
            button6.Name = "button6";
            button6.Size = new Size(72, 23);
            button6.TabIndex = 33;
            button6.Text = "Completar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(750, 271);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 32;
            label8.Text = "Preço";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(507, 271);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 31;
            label7.Text = "Duração";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(741, 242);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 30;
            label6.Text = "Horario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(507, 242);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 29;
            label1.Text = "Data ";
            label1.Click += label1_Click;
            // 
            // textDuracao
            // 
            textDuracao.Location = new Point(564, 271);
            textDuracao.Name = "textDuracao";
            textDuracao.Size = new Size(149, 23);
            textDuracao.TabIndex = 28;
            textDuracao.TextChanged += textDuracao_TextChanged;
            // 
            // textPreco
            // 
            textPreco.Location = new Point(794, 271);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(175, 23);
            textPreco.TabIndex = 27;
            textPreco.TextChanged += textPreco_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(564, 343);
            button5.Name = "button5";
            button5.Size = new Size(72, 23);
            button5.TabIndex = 26;
            button5.Text = "Excluir";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(648, 343);
            button4.Name = "button4";
            button4.Size = new Size(65, 23);
            button4.TabIndex = 25;
            button4.Text = "Atualizar";
            button4.UseVisualStyleBackColor = true;
            // 
            // textHorario
            // 
            textHorario.Location = new Point(794, 242);
            textHorario.Name = "textHorario";
            textHorario.Size = new Size(175, 23);
            textHorario.TabIndex = 24;
            textHorario.TextChanged += textHorario_TextChanged;
            // 
            // textData
            // 
            textData.Location = new Point(564, 242);
            textData.Name = "textData";
            textData.Size = new Size(149, 23);
            textData.TabIndex = 23;
            textData.TextChanged += textData_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(271, 165);
            button3.Name = "button3";
            button3.Size = new Size(215, 23);
            button3.TabIndex = 22;
            button3.Text = "Preencher  Dados do Usuarios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 204);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(235, 162);
            dataGridView2.TabIndex = 21;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(124, 165);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 14;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(9, 165);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 13;
            button1.Text = "cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 87);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 12;
            label5.Text = "Descrição";
            label5.Click += label5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(839, 391);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 34;
            button7.Text = "Menu";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // AgendarHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1035, 444);
            Controls.Add(groupBox1);
            Name = "AgendarHorario";
            Text = "AgendarHorario";
            Load += AgendarHorario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textNome;
        private TextBox textTelefone;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnCadastar;
        private DataGridView dataGridView1;
        private ComboBox comboServiço;
        private TextBox textDescricao;
        private GroupBox groupBox1;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView2;
        public MonthCalendar monthCalendar1;
        private Button button3;
        private TextBox textHorario;
        private TextBox textData;
        private Label label1;
        private TextBox textDuracao;
        private TextBox textPreco;
        private Button button5;
        private Button button4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button6;
        private Button button7;
    }
}