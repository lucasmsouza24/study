using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personagens_Projeto
{
    public partial class FormPersonagens : Form
    {
        //Metodo que verifica o item selecionado
        private void verifica(int item)
        {
            switch (item)
            {
                case 0:
                    pictureBoxPersonagem.Image = Properties.Resources.goku;
                    this.BackColor = Color.Orange;
                    break;
                case 1:
                    pictureBoxPersonagem.Image = Properties.Resources.vegeta;
                    this.BackColor = Color.Blue;
                    break;
                case 2:
                    pictureBoxPersonagem.Image = Properties.Resources.inuyasha;
                    this.BackColor = Color.IndianRed;
                    break;
                case 3:
                    pictureBoxPersonagem.Image = Properties.Resources.sesshoumaru;
                    this.BackColor = Color.White;
                    break;
                case 4:
                    pictureBoxPersonagem.Image = Properties.Resources.tokoyami;
                    this.BackColor = Color.Black;
                    break;
                case 5:
                    pictureBoxPersonagem.Image = Properties.Resources.yusuke;
                    this.BackColor = Color.Green;
                    break;
                case 6:
                    pictureBoxPersonagem.Image = Properties.Resources.tanjiro;
                    this.BackColor = Color.SpringGreen;
                    break;
                case 7:
                    pictureBoxPersonagem.Image = Properties.Resources.zero_two;
                    this.BackColor = Color.Pink;
                    break;
                case 8:
                    pictureBoxPersonagem.Image = Properties.Resources.erwin;
                    this.BackColor = Color.Goldenrod;
                    break;
                case 9:
                    pictureBoxPersonagem.Image = Properties.Resources.goblin_slayer;
                    this.BackColor = Color.Gray; 
                    break;
                default:
                    pictureBoxPersonagem.Image = null;
                    break;
            }
        }
        public FormPersonagens()
        {
            InitializeComponent();
        }

        private void listBoxPersonagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            verifica(listBoxPersonagem.SelectedIndex);
        }

        private void comboBoxPersonagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            verifica(comboBoxPersonagem.SelectedIndex);
        }
    }
}
