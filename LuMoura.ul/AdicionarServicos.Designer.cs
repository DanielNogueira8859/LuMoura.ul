namespace ProjetoIntegrador
{
    partial class AdicionarServicos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxTempo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxValor);
            this.groupBox1.Controls.Add(this.textBoxDes);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(127, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Serviços";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tempo de duração:";
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Location = new System.Drawing.Point(165, 282);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.Size = new System.Drawing.Size(100, 23);
            this.textBoxTempo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(175, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(165, 210);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 23);
            this.textBoxValor.TabIndex = 2;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(165, 143);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(100, 23);
            this.textBoxDes.TabIndex = 1;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(165, 66);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // AdicionarServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdicionarServicos";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxValor;
        private TextBox textBoxDes;
        private TextBox textBoxNome;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBoxTempo;
    }
}