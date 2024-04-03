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
    public partial class FormCalculoJuros : Form
    {
        public FormCalculoJuros()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //criar variaveis aporte, e juros do  tipo double
            //obter o texto do txtValor
            //obter o texto do txtJuros
            //converter o texto em um numero double
            int meses = int.Parse(txtMeses.Text);
            double aporte = double.Parse(txtValor.Text);
            double juros = double.Parse(txtJuros.Text);

            //chamar o metodo calcular Juros
            //e obtem o retorno dele, armazendo o seu retorno em uma variavel
            double total = CalcularJuros(aporte, juros, meses);

            //:F2 formata pra 2 n depois da virgula
            MessageBox.Show($"Total de rendimento: {total:F2}");

        }

        //Calcula os juros com base no aporte e %
        //private: so pode ser chamado nesta tela. (nao da pra ir em outra tela e chamar ele)
        //void: retorno vazio (nao retorna nada)
        //duble: retorna um valor double (retorna algo)
        //(double aporte, object juros): parametros do metodo
        private double CalcularJuros(double aporte, double juros, int meses)
        {
            double total = 0.0;
            //estrutura de repetição
            //contador, condicao e incremento
            for(int i = 1; i <= meses; i++)
            {
                //calculo de juros
                aporte *= (1 + (juros / 100));
            }

            total = aporte;
            //depois de falar que o metodo retorna algo diferente de void, precisa usar o return, e o que ele vai retornar
            return total;
        }
    }
}
