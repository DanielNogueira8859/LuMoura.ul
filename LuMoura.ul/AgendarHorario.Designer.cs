﻿namespace LuMoura.ul
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCadastar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboServiço = new System.Windows.Forms.ComboBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textDuracao = new System.Windows.Forms.TextBox();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textHorario = new System.Windows.Forms.TextBox();
            this.textData = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(271, 204);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TodayDate = new System.DateTime(2023, 12, 3, 0, 0, 0, 0);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(564, 29);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(405, 23);
            this.textNome.TabIndex = 2;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(564, 58);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(405, 23);
            this.textTelefone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(512, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(492, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(502, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serviço:";
            // 
            // BtnCadastar
            // 
            this.BtnCadastar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastar.Location = new System.Drawing.Point(794, 343);
            this.BtnCadastar.Name = "BtnCadastar";
            this.BtnCadastar.Size = new System.Drawing.Size(175, 23);
            this.BtnCadastar.TabIndex = 8;
            this.BtnCadastar.Text = "Cadastar Horario";
            this.BtnCadastar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(480, 137);
            this.dataGridView1.TabIndex = 9;
            // 
            // comboServiço
            // 
            this.comboServiço.FormattingEnabled = true;
            this.comboServiço.Location = new System.Drawing.Point(564, 204);
            this.comboServiço.Name = "comboServiço";
            this.comboServiço.Size = new System.Drawing.Size(405, 23);
            this.comboServiço.TabIndex = 10;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(564, 87);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(405, 72);
            this.textDescricao.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textDuracao);
            this.groupBox1.Controls.Add(this.textPreco);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textHorario);
            this.groupBox1.Controls.Add(this.textData);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.textDescricao);
            this.groupBox1.Controls.Add(this.comboServiço);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textTelefone);
            this.groupBox1.Controls.Add(this.BtnCadastar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 390);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(564, 343);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 23);
            this.button7.TabIndex = 34;
            this.button7.Text = "Menu";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(642, 343);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "Completar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(741, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Preço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(497, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Duração:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(731, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Horario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(519, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Data:";
            // 
            // textDuracao
            // 
            this.textDuracao.Location = new System.Drawing.Point(564, 271);
            this.textDuracao.Name = "textDuracao";
            this.textDuracao.Size = new System.Drawing.Size(149, 23);
            this.textDuracao.TabIndex = 28;
            // 
            // textPreco
            // 
            this.textPreco.Location = new System.Drawing.Point(794, 271);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(175, 23);
            this.textPreco.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(564, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Excluir/Atualizar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textHorario
            // 
            this.textHorario.Location = new System.Drawing.Point(794, 242);
            this.textHorario.Name = "textHorario";
            this.textHorario.Size = new System.Drawing.Size(175, 23);
            this.textHorario.TabIndex = 24;
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(564, 242);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(149, 23);
            this.textData.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(271, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Preencher  Dados do Usuarios";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 204);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(238, 162);
            this.dataGridView2.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(124, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(9, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(486, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descrição:";
            // 
            // AgendarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1035, 414);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgendarHorario";
            this.Text = "AgendarHorario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

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