using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Atividade08_Projeto
{
    class Conexao
    {
        private static string strConexao = @"Server = localhost; Database = dbAcessoBD; Uid = Astrogildo; Pwd = 123456";
        private static MySqlConnection Cn = new MySqlConnection(strConexao);

        public static MySqlConnection abreConexao()
        {
            try
            {
                if (Cn.State.ToString() == "Closed")
                {
                    Cn.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Cn;
        }

        public static void fechaConexao()
        {
            try
            {
                if (Cn.State.ToString() == "Open")
                {
                    Cn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
