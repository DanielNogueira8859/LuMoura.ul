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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            groupBox1 = new GroupBox();
            BtAtualizar = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            textBoxTempo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxValor = new TextBox();
            textBoxDes = new TextBox();
            textBoxNome = new TextBox();
            BtMenu = new Guna.UI2.WinForms.Guna2CircleButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 74);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtAtualizar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxTempo);
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
            // BtAtualizar
            // 
            BtAtualizar.CustomizableEdges = customizableEdges1;
            BtAtualizar.DisabledState.BorderColor = Color.DarkGray;
            BtAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            BtAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtAtualizar.FillColor = Color.Plum;
            BtAtualizar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtAtualizar.ForeColor = Color.White;
            BtAtualizar.Location = new Point(169, 328);
            BtAtualizar.Name = "BtAtualizar";
            BtAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtAtualizar.Size = new Size(96, 28);
            BtAtualizar.TabIndex = 35;
            BtAtualizar.Text = "Adicionar";
            BtAtualizar.Click += BtAtualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 290);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 151);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(95, 210);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Valor:";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(165, 210);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(100, 23);
            textBoxValor.TabIndex = 2;
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
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // BtMenu
            // 
            BtMenu.DisabledState.BorderColor = Color.DarkGray;
            BtMenu.DisabledState.CustomBorderColor = Color.DarkGray;
            BtMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtMenu.FillColor = Color.Plum;
            BtMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtMenu.ForeColor = Color.White;
            BtMenu.Location = new Point(613, 65);
            BtMenu.Name = "BtMenu";
            BtMenu.ShadowDecoration.CustomizableEdges = customizableEdges3;
            BtMenu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            BtMenu.Size = new Size(74, 43);
            BtMenu.TabIndex = 31;
            BtMenu.Text = "Menu";
            BtMenu.Click += BtMenu_Click;
            // 
            // AdicionarServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(BtMenu);
            Controls.Add(groupBox1);
            Name = "AdicionarServicos";
            Text = "Form1";
            Load += AdicionarServicos_Load;
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
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBoxTempo;
        private Guna.UI2.WinForms.Guna2CircleButton BtMenu;
        private Guna.UI2.WinForms.Guna2Button BtAtualizar;
    }
}