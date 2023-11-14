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
            button3 = new Button();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(259, 355);
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
            label4.Location = new Point(74, 299);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Serviço";
            // 
            // BtnCadastar
            // 
            BtnCadastar.Location = new Point(22, 538);
            BtnCadastar.Name = "BtnCadastar";
            BtnCadastar.Size = new Size(170, 23);
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
            comboServiço.Location = new Point(0, 317);
            comboServiço.Name = "comboServiço";
            comboServiço.Size = new Size(235, 23);
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
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 570);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(171, 165);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 22;
            button3.Text = "Preencher";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 355);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(235, 162);
            dataGridView2.TabIndex = 21;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(90, 165);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(9, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
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
            // AgendarHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 614);
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
    }
}