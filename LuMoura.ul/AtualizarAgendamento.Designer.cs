namespace LuMoura.ul
{
    partial class AtualizarAgendamento
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
            dataGridView1 = new DataGridView();
            monthCalendar1 = new MonthCalendar();
            textTelefone = new TextBox();
            groupBox1 = new GroupBox();
            label15 = new Label();
            button4 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button3 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            textDuracao = new TextBox();
            textPreco = new TextBox();
            button5 = new Button();
            comboServicos = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            textHorario = new TextBox();
            textData = new TextBox();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            monthCalendar2 = new MonthCalendar();
            textNome = new TextBox();
            textDescricao = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(512, 237);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(8, 58);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textTelefone
            // 
            textTelefone.Location = new Point(290, 58);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(194, 23);
            textTelefone.TabIndex = 3;
            textTelefone.TextChanged += textTelefone_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 555);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 492);
            label15.Name = "label15";
            label15.Size = new Size(106, 15);
            label15.TabIndex = 40;
            label15.Text = "Dinheiro a Receber";
            label15.Click += label15_Click;
            // 
            // button4
            // 
            button4.Location = new Point(5, 526);
            button4.Name = "button4";
            button4.Size = new Size(146, 23);
            button4.TabIndex = 15;
            button4.Text = "Menu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 154);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 14;
            label8.Text = "Descrição";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(247, 197);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 13;
            label7.Text = "Serviço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 103);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 12;
            label6.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 58);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "Nome";
            // 
            // button3
            // 
            button3.Location = new Point(301, 526);
            button3.Name = "button3";
            button3.Size = new Size(92, 23);
            button3.TabIndex = 8;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(417, 526);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 7;
            button1.Text = "Completar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(301, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(301, 154);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(216, 23);
            textBox5.TabIndex = 5;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(301, 103);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 23);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 19);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 2;
            label1.Text = "Escolha um método de Pesquisa ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MistyRose;
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textDuracao);
            groupBox2.Controls.Add(textPreco);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(comboServicos);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textHorario);
            groupBox2.Controls.Add(textData);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(monthCalendar2);
            groupBox2.Controls.Add(textNome);
            groupBox2.Controls.Add(textDescricao);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textTelefone);
            groupBox2.Location = new Point(555, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(492, 555);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(245, 456);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 42;
            label14.Text = "Valor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 456);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 41;
            label13.Text = "Duração";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(245, 413);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 40;
            label12.Text = "Hora";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 412);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 39;
            label11.Text = "Data";
            // 
            // textDuracao
            // 
            textDuracao.Location = new Point(64, 446);
            textDuracao.Name = "textDuracao";
            textDuracao.Size = new Size(169, 23);
            textDuracao.TabIndex = 38;
            textDuracao.TextChanged += textDuracao_TextChanged;
            // 
            // textPreco
            // 
            textPreco.Location = new Point(290, 448);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(194, 23);
            textPreco.TabIndex = 37;
            textPreco.TextChanged += textPreco_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(6, 526);
            button5.Name = "button5";
            button5.Size = new Size(227, 23);
            button5.TabIndex = 36;
            button5.Text = "Preecher";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboServicos
            // 
            comboServicos.FormattingEnabled = true;
            comboServicos.Location = new Point(64, 194);
            comboServicos.Name = "comboServicos";
            comboServicos.Size = new Size(420, 23);
            comboServicos.TabIndex = 35;
            comboServicos.SelectedIndexChanged += comboServicos_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 131);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 15;
            label10.Text = "Descrição";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 197);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 15;
            label9.Text = "Serviço";
            // 
            // textHorario
            // 
            textHorario.Location = new Point(290, 406);
            textHorario.Name = "textHorario";
            textHorario.Size = new Size(196, 23);
            textHorario.TabIndex = 34;
            textHorario.TextChanged += textHorario_TextChanged;
            // 
            // textData
            // 
            textData.Location = new Point(64, 404);
            textData.Name = "textData";
            textData.Size = new Size(169, 23);
            textData.TabIndex = 33;
            textData.TextChanged += textData_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(251, 526);
            button2.Name = "button2";
            button2.Size = new Size(235, 23);
            button2.TabIndex = 17;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Snow;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(249, 229);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(235, 162);
            dataGridView2.TabIndex = 14;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(13, 229);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 13;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // textNome
            // 
            textNome.Location = new Point(64, 58);
            textNome.Name = "textNome";
            textNome.Size = new Size(169, 23);
            textNome.TabIndex = 12;
            textNome.TextChanged += textNome_TextChanged;
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(64, 103);
            textDescricao.Multiline = true;
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(420, 74);
            textDescricao.TabIndex = 11;
            textDescricao.TextChanged += textDescricao_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 19);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 8;
            label2.Text = "Dados a Alterar";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 58);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 10;
            label4.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 61);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Telefone";
            // 
            // AtualizarAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1059, 597);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AtualizarAgendamento";
            Text = "AtualizarAgendamento";
            Load += AtualizarAgendamento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private MonthCalendar monthCalendar1;
        private TextBox textTelefone;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label4;
        private Label label3;
        private MonthCalendar monthCalendar2;
        private TextBox textNome;
        private TextBox textDescricao;
        private DataGridView dataGridView2;
        private Button button2;
        private TextBox textHorario;
        private TextBox textData;
        private Button button3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
        private Button button4;
        private ComboBox comboServicos;
        private Button button5;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textDuracao;
        private TextBox textPreco;
        private Label label15;
    }
}