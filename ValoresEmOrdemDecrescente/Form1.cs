using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValoresEmOrdemDecrescente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Lê os valores digitados pelo usuário nas TextBoxes
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);

            // Ordena os valores em ordem decrescente usando o método Sort da classe Array
            int[] numeros = { num1, num2, num3 };
            Array.Sort(numeros);
            Array.Reverse(numeros);

            // Exibe os valores em ordem decrescente no Label
            label1.Text = numeros[0] + ", " + numeros[1] + ", " + numeros[2];
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Lê os valores digitados pelo usuário nas TextBoxes
            int num1 = int.Parse(textBox4.Text);
            int num2 = int.Parse(textBox5.Text);

            if (num1 > num2)
            {
                // num1 é maior que num2
                label2.Text = num1 + " é maior que: " + num2;
            }
            else if (num1 < num2)
            {
                // num1 é menor que num2
                label2.Text = num1 + " é menor que: " + num2;
            }
            else if (num1 == num2)
            {
                // num1 e num2 são iguais
                label2.Text = num1 + " é igual à " + num2;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Lê o número digitado pelo usuário na TextBox
            int num = int.Parse(textBox6.Text);

            // Cria uma variável para armazenar a tabuada do número
            string tabuada = "";

            // Faz um loop de 1 a 10 para calcular a tabuada do número
            for (int i = 1; i <= 10; i++)
            {
                int resultado = num * i;
                tabuada += num + " x " + i + " = " + resultado + "\n";
            }

            // Exibe a tabuada do número no Label
            label3.Text = "Tabuada do " + num + ":\n\n" + tabuada;
        }
    }
}
