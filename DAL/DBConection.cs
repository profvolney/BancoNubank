using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoNubank.DAL
{
    public class DBConection
    {  
        string Con = ConfigurationManager.ConnectionStrings["DBConexao"].ConnectionString;
        public DBConection()
        {
            MySqlConnection conn = new MySqlConnection(Con);
            conn.Open();
            MessageBox.Show("Conexão com o banco de dados estabelecida com sucesso.");
        }    

    }
}
