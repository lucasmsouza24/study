using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade02_Projeto
{
    public partial class FormPokemon : Form
    {
        public FormPokemon()
        {
            InitializeComponent();
        }

        private void rbtAbra_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Abra;
        }

        private void rbtCharmander_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Charmander;
        }

        private void rbtDratini_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Dratini;
        }

        private void rbtDrowzee_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Drowzee;
        }

        private void rbtGrowlithe_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Growlithe;
        }

        private void rbtPikachu_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Pikachu;
        }

        private void rbtPonyta_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Ponyta;
        }

        private void rbtPsyduck_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Psyduck;
        }

        private void rbtSquirtle_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Squirtle;
        }

        private void rbtVulpix_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Vulpix;
        }
    }
}
