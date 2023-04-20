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
    }
}
