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
            button7 = new Button();
            button6 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            textDuracao = new TextBox();
            textPreco = new TextBox();
            button4 = new Button();
            textHorario = new TextBox();
            textData = new TextBox();
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
            monthCalendar1.Location = new Point(271, 204);
            monthCalendar1.Margin = new Padding(9, 9, 9, 10);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.TodayDate = new DateTime(2023, 12, 3, 0, 0, 0, 0);
            monthCalendar1.DateChanged += monthCalendar1_DateChanged_1;
            // 
            // textNome
            // 
            textNome.Location = new Point(564, 29);
            textNome.Name = "textNome";
            textNome.Size = new Size(405, 23);
            textNome.TabIndex = 2;
            textNome.TextChanged += textNome_TextChanged_1;
            // 
            // textTelefone
            // 
            textTelefone.Location = new Point(564, 58);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(405, 23);
            textTelefone.TabIndex = 3;
            textTelefone.TextChanged += textTelefone_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(512, 33);
            label2.Name = "label2";
            label2.Size = new Size(49, 13);
            label2.TabIndex = 5;
            label2.Text = "Nome:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(492, 62);
            label3.Name = "label3";
            label3.Size = new Size(69, 13);
            label3.TabIndex = 6;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(502, 208);
            label4.Name = "label4";
            label4.Size = new Size(59, 13);
            label4.TabIndex = 7;
            label4.Text = "Serviço:";
            // 
            // BtnCadastar
            // 
            BtnCadastar.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCadastar.Location = new Point(794, 343);
            BtnCadastar.Name = "BtnCadastar";
            BtnCadastar.Size = new Size(175, 23);
            BtnCadastar.TabIndex = 8;
            BtnCadastar.Text = "Cadastar Horario";
            BtnCadastar.UseVisualStyleBackColor = true;
            BtnCadastar.Click += BtnCadastar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(480, 137);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // comboServiço
            // 
            comboServiço.FormattingEnabled = true;
            comboServiço.Location = new Point(564, 204);
            comboServiço.Name = "comboServiço";
            comboServiço.Size = new Size(405, 23);
            comboServiço.TabIndex = 10;
            comboServiço.SelectedIndexChanged += comboServiço_SelectedIndexChanged_1;
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(564, 87);
            textDescricao.Multiline = true;
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(405, 72);
            textDescricao.TabIndex = 11;
            textDescricao.TextChanged += textDescricao_TextChanged_1;
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
            groupBox1.Size = new Size(1000, 390);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // button7
            // 
            button7.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(564, 343);
            button7.Name = "button7";
            button7.Size = new Size(71, 23);
            button7.TabIndex = 34;
            button7.Text = "Menu";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // button6
            // 
            button6.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(642, 343);
            button6.Name = "button6";
            button6.Size = new Size(92, 23);
            button6.TabIndex = 33;
            button6.Text = "Completar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(741, 275);
            label8.Name = "label8";
            label8.Size = new Size(47, 13);
            label8.TabIndex = 32;
            label8.Text = "Preço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(497, 275);
            label7.Name = "label7";
            label7.Size = new Size(64, 13);
            label7.TabIndex = 31;
            label7.Text = "Duração:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(731, 246);
            label6.Name = "label6";
            label6.Size = new Size(59, 13);
            label6.TabIndex = 30;
            label6.Text = "Horario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(519, 246);
            label1.Name = "label1";
            label1.Size = new Size(42, 13);
            label1.TabIndex = 29;
            label1.Text = "Data:";
            // 
            // textDuracao
            // 
            textDuracao.Location = new Point(564, 271);
            textDuracao.Name = "textDuracao";
            textDuracao.Size = new Size(149, 23);
            textDuracao.TabIndex = 28;
            textDuracao.TextChanged += textDuracao_TextChanged_1;
            // 
            // textPreco
            // 
            textPreco.Location = new Point(794, 271);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(175, 23);
            textPreco.TabIndex = 27;
            textPreco.TextChanged += textPreco_TextChanged_1;
            // 
            // button4
            // 
            button4.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(564, 314);
            button4.Name = "button4";
            button4.Size = new Size(170, 23);
            button4.TabIndex = 25;
            button4.Text = "Excluir/Atualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textHorario
            // 
            textHorario.Location = new Point(794, 242);
            textHorario.Name = "textHorario";
            textHorario.Size = new Size(175, 23);
            textHorario.TabIndex = 24;
            textHorario.TextChanged += textHorario_TextChanged_1;
            // 
            // textData
            // 
            textData.Location = new Point(564, 242);
            textData.Name = "textData";
            textData.Size = new Size(149, 23);
            textData.TabIndex = 23;
            textData.TextChanged += textData_TextChanged_1;
            // 
            // button3
            // 
            button3.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(271, 165);
            button3.Name = "button3";
            button3.Size = new Size(215, 23);
            button3.TabIndex = 22;
            button3.Text = "Preencher  Dados do Usuarios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 204);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(238, 162);
            dataGridView2.TabIndex = 21;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(124, 165);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 14;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(9, 165);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 13;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(486, 91);
            label5.Name = "label5";
            label5.Size = new Size(75, 13);
            label5.TabIndex = 12;
            label5.Text = "Descrição:";
            // 
            // AgendarHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1035, 414);
            Controls.Add(groupBox1);
            Name = "AgendarHorario";
            Text = "AgendarHorario";
            Load += AgendarHorario_Load_1;
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
        private Button button4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button6;
        private Button button7;
    }
}