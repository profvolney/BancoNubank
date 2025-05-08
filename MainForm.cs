using BancoNubank.CustomControls;
using BancoNubank.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoNubank
{
    public partial class MainForm : Form
    {
        public static Panel MainPanel;
        private string _dbConnection; 
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(DBConection dBConection)
        {           
            MainPanel = panel2;
            _dbConnection = dBConection.ToString();    
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Con = ConfigurationManager.ConnectionStrings["DBConexao"].ConnectionString;
                var connection = new MySqlConnection(Con);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }

            UC_Login login = new UC_Login();
            login.Dock = DockStyle.Fill;
            panel2.Controls.Add(login);
            panel2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            UC_Cadastrar cadastrar = new UC_Cadastrar();
            cadastrar.Dock = DockStyle.Fill;
            panel2.Controls.Add(cadastrar);
            cadastrar.BringToFront();
            cadastrar.Visible = true;
            cadastrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_Login login = new UC_Login();
            login.Dock = DockStyle.Fill;
            panel2.Controls.Add(login);
            panel2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Depositar depositar = new UC_Depositar();
            depositar.Dock = DockStyle.Fill;
            panel2.Controls.Add(depositar);
            depositar.BringToFront();
            depositar.Visible = true;
            depositar.Show();
        }
    }
}
