using BancoNubank.CustomControls;
using BancoNubank.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private string _dbConnection; // Add a field to store the database connection string  
        private static string _DBConection;
        public MainForm(DBConection dBConection)
        {
            InitializeComponent();
            MainPanel = panel2;
            _dbConnection = dBConection.ToString();  // Initialize the database connection string  
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UC_Login login = new UC_Login();
            login.Dock = DockStyle.Fill;
            panel2.Controls.Add(login);
            panel2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pass the required database connection string
            // to the UC_Cadastrar constructor  
            UC_Cadastrar cadastrar = new UC_Cadastrar(DBConection dBConection);
            cadastrar.Dock = DockStyle.Fill;
            this.Controls.Add(cadastrar);
            cadastrar.Visible = false;
            cadastrar.BringToFront();
            cadastrar.Show();
        }
    }
}
