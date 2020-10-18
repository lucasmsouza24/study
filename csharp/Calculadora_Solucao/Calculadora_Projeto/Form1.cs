using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Projeto
{
    public partial class FormMain : Form
    {
        double numero1, numero2;
        string conta;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            conta = "mais";
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textBox1.Text);
            if (conta == "mais")
            {
                textBox1.Text = (numero1 + numero2).ToString();
            }
            if (conta == "menos")
            {
                textBox1.Text = (numero1 - numero2).ToString();
            }
            if (conta == "multiplicacao")
            {
                textBox1.Text = (numero1 * numero2).ToString();
            }
            if (conta == "divisao")
            {
                textBox1.Text = (numero1 / numero2).ToString();
            }
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            conta = "menos";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonVezes_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            conta = "multiplicacao";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            conta = "divisao";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNegativo_Click(object sender, EventArgs e)
        {
    
            if (! textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
            }
        }
    }
}
