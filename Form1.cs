using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculo_Click(object sender, EventArgs e)
        {
            

        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double resultado = n1 * n2;
            MessageBox.Show($"Resultado: {resultado}");
            txtVisor.Text = (n1 * n2).ToString();
        }

        private void soma_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double resultado = n1 + n2;
            MessageBox.Show($"Resultado: {resultado}");
            txtVisor.Text = (n1 + n2).ToString();
           
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double  resultado =  n1 / n2;
            MessageBox.Show($"Resultado: {resultado}");
            if (n2 == 0)
            {
                MessageBox.Show("Não é possivel dividir por zero!");
                return;
            }
            txtVisor.Text = (n1 / n2).ToString();
        }

        private void menos_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double resultado = n1 - n2;
            MessageBox.Show($"Resultado: {resultado}");

            txtVisor.Text = (n1 - n2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
