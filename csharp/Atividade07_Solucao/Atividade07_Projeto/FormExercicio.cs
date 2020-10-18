using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Atividade07_Projeto
{
    public partial class FormExercicio : Form
    {
        public FormExercicio()
        {
            InitializeComponent();
        }

        private void buttonSairCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = String.Format("SELECT * FROM tbClientes WHERE codigoCli = {0}", textBoxCodigoCliente.Text);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBoxCodigoCliente.Text = dr["codigoCli"].ToString();
                    textBoxNomeCliente.Text = dr["NomeCli"].ToString();
                    if (dr["SexoCli"].ToString() == "M")
                    {
                        radioButtonSexoM.Checked = true;
                        radioButtonSexoF.Checked = false;
                    }
                    else
                    {
                        radioButtonSexoM.Checked = false;
                        radioButtonSexoF.Checked = true;
                    }
                    dr.Close();
                    cmd.Dispose();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }
    }
}
