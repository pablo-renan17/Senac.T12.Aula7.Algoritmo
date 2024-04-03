namespace WinFormsAppEstruturaControle
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            contaToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            contadorToolStripMenuItem = new ToolStripMenuItem();
            calculoDeJurosToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnMiar = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { contaToolStripMenuItem, clienteToolStripMenuItem, ferramentasToolStripMenuItem, ajudaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(51, 20);
            contaToolStripMenuItem.Text = "Conta";
            contaToolStripMenuItem.Click += contaToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(56, 20);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contadorToolStripMenuItem, calculoDeJurosToolStripMenuItem });
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // contadorToolStripMenuItem
            // 
            contadorToolStripMenuItem.Name = "contadorToolStripMenuItem";
            contadorToolStripMenuItem.Size = new Size(160, 22);
            contadorToolStripMenuItem.Text = "Contador";
            contadorToolStripMenuItem.Click += contadorToolStripMenuItem_Click;
            // 
            // calculoDeJurosToolStripMenuItem
            // 
            calculoDeJurosToolStripMenuItem.Name = "calculoDeJurosToolStripMenuItem";
            calculoDeJurosToolStripMenuItem.Size = new Size(160, 22);
            calculoDeJurosToolStripMenuItem.Text = "Calculo de Juros";
            calculoDeJurosToolStripMenuItem.Click += calculoDeJurosToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // btnMiar
            // 
            btnMiar.BackColor = Color.Transparent;
            btnMiar.FlatAppearance.BorderSize = 0;
            btnMiar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMiar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMiar.FlatStyle = FlatStyle.Flat;
            btnMiar.ForeColor = Color.Transparent;
            btnMiar.Location = new Point(477, 323);
            btnMiar.Name = "btnMiar";
            btnMiar.Size = new Size(149, 111);
            btnMiar.TabIndex = 1;
            btnMiar.UseVisualStyleBackColor = false;
            btnMiar.Click += btnMiar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 485);
            Controls.Add(btnMiar);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            Text = "Senac - Banking";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contaToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem contadorToolStripMenuItem;
        private ToolStripMenuItem calculoDeJurosToolStripMenuItem;
        private Button btnMiar;
    }
}