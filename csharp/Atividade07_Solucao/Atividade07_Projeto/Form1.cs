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
    public partial class frmAcesso : Form
    {
        public frmAcesso()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = String.Format("SELECT * FROM tbEstados WHERE codigoEst = {0}", textBoxCodigo.Text);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBoxCodigo.Text = dr["codigoEst"].ToString();
                    textBoxNomeDoEstado.Text = dr["NomeEst"].ToString();
                    textBoxUF.Text = dr["UfEst"].ToString();
                }
                dr.Close();
                cmd.Dispose();
            }
            catch(MySqlException ex)
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
