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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            textBoxTempo = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBoxValor = new TextBox();
            textBoxDes = new TextBox();
            textBoxNome = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 74);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxTempo);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxValor);
            groupBox1.Controls.Add(textBoxDes);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(127, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 384);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionar Serviços";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 290);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 7;
            label4.Text = "Tempo de duração:";
            // 
            // textBoxTempo
            // 
            textBoxTempo.Location = new Point(165, 282);
            textBoxTempo.Name = "textBoxTempo";
            textBoxTempo.Size = new Size(100, 23);
            textBoxTempo.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Location = new Point(175, 335);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 151);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 210);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Valor:";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(165, 210);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(100, 23);
            textBoxValor.TabIndex = 2;
            textBoxValor.TextChanged += textBoxValor_TextChanged;
            // 
            // textBoxDes
            // 
            textBoxDes.Location = new Point(165, 143);
            textBoxDes.Name = "textBoxDes";
            textBoxDes.Size = new Size(100, 23);
            textBoxDes.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(165, 66);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Location = new Point(613, 107);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AdicionarServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "AdicionarServicos";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private Button button2;
    }
}