using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoNubank.Models;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace BancoNubank.CustomControls
{
    public partial class UC_Depositar: UserControl
    {
        public UC_Depositar()
        {
            InitializeComponent();
        }

        private void Depositar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double valorDeposito = Double.Parse(txtSaldo.Text);
            Usuario usuario = new Usuario();
            usuario.Depositar(valorDeposito);

            MessageBox.Show("Depósito realizado com sucesso!");

            string conString = ConfigurationManager.ConnectionStrings["DBConexao"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(conString);
            string sql = "SELECT saldo FROM Conta;";
            MySqlCommand cmdDepositar = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = cmdDepositar.ExecuteReader();
                if (reader.Read())
                {
                    double saldoAtual = reader.GetDouble("saldo");
                    
                    MessageBox.Show($"Seu saldo atual é: {saldoAtual}");

                    lblSaldoAtual.Text = saldoAtual.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
