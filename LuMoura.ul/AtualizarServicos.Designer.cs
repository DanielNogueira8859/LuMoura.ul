namespace ProjetoIntegrador
{
    partial class AtualizarServicos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Atualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxTempo);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Atualizar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxValor);
            this.groupBox1.Controls.Add(this.textBoxDes);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 384);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Serviços";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tempo de duração:";
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Location = new System.Drawing.Point(561, 233);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.Size = new System.Drawing.Size(100, 23);
            this.textBoxTempo.TabIndex = 11;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(561, 288);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Id:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.Location = new System.Drawing.Point(353, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(18, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(310, 23);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(410, 192);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.Color.Thistle;
            this.Atualizar.Location = new System.Drawing.Point(573, 332);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 5;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(561, 178);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 23);
            this.textBoxValor.TabIndex = 2;
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(561, 113);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(100, 23);
            this.textBoxDes.TabIndex = 1;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(561, 61);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // AtualizarServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.groupBox1);
            this.Name = "AtualizarServicos";
            this.Text = "AtualizarServicos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Button Atualizar;
        private Label label3;
        private Label label2;
        private TextBox textBoxValor;
        private TextBox textBoxDes;
        private TextBox textBoxNome;
        private Label label1;
        private TextBox textBoxID;
        private Label label4;
        private Label label5;
        private TextBox textBoxTempo;
    }
}