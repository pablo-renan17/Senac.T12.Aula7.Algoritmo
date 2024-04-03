using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppEstruturaControle
{
    public partial class FormPrincipal : Form
    {
        // variavel inteiro
        int contador = 0;
        // variavel texto
        string mensagem = String.Empty;
        // variavel decimal
        decimal saldoAtual = decimal.Zero;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cria uma variavel do formConta
            var formConta = new FormConta();
            //exibe a tela form contra
            formConta.Show();
            //incrementar o valor da variavel contador
            contador++;
        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exibe uma caixa de mensagem
            mensagem = "Contador de clique: " + contador;
            MessageBox.Show(mensagem,
                "Contador",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //atribui o valor da variavel mensagem
            mensagem = "Deseja sair do aplicativo?";
            var resultado = MessageBox.Show(mensagem,
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            //se o usuario escolher a opcao sim, fechar programa
            if (resultado == DialogResult.Yes)
            {
                //Fecha aplicativo
                Application.Exit();
            }
            else //senao
            {
                //grava um log que ele desistiu de sair
                Console.WriteLine("O usuario desistiu de fechar");
            }
        }

        private void calculoDeJurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCalculoJuros = new FormCalculoJuros();
            formCalculoJuros.ShowDialog();
        }

        private void btnMiar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\04966599016\Documents\Pablo\rayknonenJumpscare\meow.wav");
            player.Play();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            btnMiar.Location = new Point(1100, 650);
        }
    }
}
