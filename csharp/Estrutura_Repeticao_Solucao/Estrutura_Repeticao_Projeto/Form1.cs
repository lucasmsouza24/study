using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrutura_Repeticao_Projeto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonMostrar1_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();
            for (int i = 1; i <= numericUpDownValor.Value; i++)
            {
                listBoxNumeros.Items.Add(i);
            }
        }

        private void buttonMostrar2_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();
            int aux = 1;
            while (aux <= numericUpDownValor.Value)
            {
                listBoxNumeros.Items.Add(aux);
                aux++;
            }
        }

        private void buttonMostrarFor_Click(object sender, EventArgs e)
        {
            listBoxFor.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                listBoxFor.Items.Add(Convert.ToString(numericUpDownFor.Value) + " x " + Convert.ToString(i) + " = " + Convert.ToString(numericUpDownFor.Value * i));
            }
        }

        private void buttonWhile_Click(object sender, EventArgs e)
        {
            listBoxWhile.Items.Clear();
            int i = 1; 
            while (i <= 10)
            {
                listBoxWhile.Items.Add(Convert.ToString(numericUpDownWhile.Value) + " x " + Convert.ToString(i) + " = " + Convert.ToString(numericUpDownWhile.Value * i));
                i++;
            }
        }
    }
}
