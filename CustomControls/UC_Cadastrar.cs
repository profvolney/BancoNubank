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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BancoNubank.CustomControls
{
    public partial class UC_Cadastrar: UserControl
    {
        public UC_Cadastrar()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string email = txtEmail.Text;
            string telefone = txtPhone.Text;
            string endereco = txtEndereco.Text;   
            string conta_id = "last_insert_id()";
            DateTime dataNasc = DateTime.Parse(txtDataNasc.Text);          
            
            Usuario usuario = new Usuario();

            usuario.CriarConta(nome, senha, email,telefone,endereco, dataNasc, conta_id);
        }
    }
}
