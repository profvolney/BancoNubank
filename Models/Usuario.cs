using BancoNubank.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNubank.Models
{
    public class Usuario : IUsuarioService
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255, ErrorMessage= "O nome é obrigatório!")]
        public string Nome { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "A Senha é obrigatória!")]
        public string Senha { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "O Email é obrigatório!")]
        public string Email { get; set; }
        [Required]
        [StringLength(12, ErrorMessage = "O telefone é obrigatório!")]
        public string Telefone { get; set; }
        [StringLength(255)]
        public string Endereco { get; set; }
        [StringLength(255)]
        public DateTime DataNascimento { get; set; }

        public void CriarConta(string nome, string senha, string email, string telefone, string endereco, DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }

        public void DeletarConta(int id)
        {
            throw new NotImplementedException();
        }

        public void Depositar(int id, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void EditarConta(int id, string nome, string senha, string email, string telefone, string endereco, DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }

        public void Sacar(int id, decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
