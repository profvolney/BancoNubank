using BancoNubank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNubank.Models
{
    public class ContaBancaria
    {
        public int IdDestino { get; set; }
        public double Saldo { get; set; }
        private double _saldo;

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("Valor de depósito inválido.");
            }
            _saldo += valor;
            
        }

       
    }
}
