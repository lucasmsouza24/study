using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Projeto
{
    public partial class FormPrincipal : Form
    {
        string dia = Convert.ToString(DateTime.Today.Day);
        string mes = Convert.ToString(DateTime.Today.Month);
        string ano = Convert.ToString(DateTime.Today.Year);

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonExibiaDia_Click(object sender, EventArgs e)
        {
            labelExibicao.Text = "Hoje é:";
            labelExibicao.Text += "\nDia: " + dia;
            labelExibicao.Text += "\nMês: " + mes;
            labelExibicao.Text += "\nAno: " + ano;
        }

        private void buttonExibirDataJunta_Click(object sender, EventArgs e)
        {
            labelExibicao.Text = "Hoje é: " + dia + "/" + mes + "/" + ano;
        }

        private void buttonExibeBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoje é: " + dia + "/" + mes + "/" + ano);
        }
    }
}
