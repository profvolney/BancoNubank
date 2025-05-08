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
        }
    }
}
