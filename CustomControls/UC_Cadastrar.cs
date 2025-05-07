using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoNubank.DAL;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace BancoNubank.CustomControls
{
    public partial class UC_Cadastrar: UserControl
    {
        private static string _DBConection;

        public UC_Cadastrar()
        {            
        }
        public UC_Cadastrar(string v, DBConection dBConection)
        {
            InitializeComponent();
            _DBConection = dBConection.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var email = txtEmail.Text;
            var senha = txtSenha.Text;
            var endereco = txtEndereco.Text;
            var telefone = txtTelefone.Text;
            var dataNascimento = txtDataNasc.Text;

            string sql = "INSERT INTO usuarios (nome, email, senha, endereco, " +
                "telefone, data_nascimento) " +
                "VALUES (@nome, @email, @senha, @endereco, @telefone," +
            " @data_nascimento)";

            MySqlCommand cmdCriarConta = new MySqlCommand(sql);
            cmdCriarConta.Parameters.AddWithValue("@nome", nome);
            cmdCriarConta.Parameters.AddWithValue("@email", email);
            cmdCriarConta.Parameters.AddWithValue("@senha", senha);
            cmdCriarConta.Parameters.AddWithValue("@endereco", endereco);
            cmdCriarConta.Parameters.AddWithValue("@telefone", telefone);
            cmdCriarConta.Parameters.AddWithValue("@dataNascimento", dataNascimento);

            try
            {   
                cmdCriarConta.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }           
        }
    }
}
