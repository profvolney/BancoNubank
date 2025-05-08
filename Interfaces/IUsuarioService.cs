using BancoNubank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNubank.Interfaces
{
    public interface IUsuarioService
    {
        void CriarConta(string nome, string senha, string email, string telefone, string endereco, DateTime dataNasc, string conta_id);
        void EditarConta(int id, string nome, string senha, string email, string telefone, string endereco, DateTime dataNasc);
        void DeletarConta(int id);
        void Sacar(double valor);
        void Depositar(double valor);
        void Transferir(double valor, int idDestino, ContaBancaria outraConta);
    }
}
