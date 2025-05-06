using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNubank.Interfaces
{
    public interface IUsuarioService
    {
        void CriarConta(string nome, string senha, string email, string telefone, string endereco, DateTime dataNascimento);
        void EditarConta(int id, string nome, string senha, string email, string telefone, string endereco, DateTime dataNascimento);
        void DeletarConta(int id);
        void Sacar(int id, decimal valor);
        void Depositar(int id, decimal valor);
    }
}
