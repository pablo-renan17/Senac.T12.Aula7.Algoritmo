namespace WinFormsAppEstruturaControle
{
    partial class FormCalculoJuros
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
            groupBox1 = new GroupBox();
            txtMeses = new TextBox();
            label4 = new Label();
            btnCalcular = new Button();
            txtJuros = new TextBox();
            label2 = new Label();
            txtValor = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMeses);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(txtJuros);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.Location = new Point(24, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Juro Composto";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(346, 64);
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(128, 23);
            txtMeses.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 46);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 6;
            label4.Text = "Informe os meses";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(25, 93);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 42);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtJuros
            // 
            txtJuros.Location = new Point(199, 64);
            txtJuros.Name = "txtJuros";
            txtJuros.Size = new Size(128, 23);
            txtJuros.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 46);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 2;
            label2.Text = "Informe a taxa de juros";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(25, 64);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(141, 23);
            txtValor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 46);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe o valor de aporte";
            // 
            // FormCalculoJuros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 222);
            Controls.Add(groupBox1);
            Name = "FormCalculoJuros";
            Text = "Calculo de Juros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCalcular;
        private TextBox txtJuros;
        private Label label2;
        private TextBox txtValor;
        private Label label1;
        private TextBox txtMeses;
        private Label label4;
    }
}