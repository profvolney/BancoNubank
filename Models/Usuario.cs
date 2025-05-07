using BancoNubank.DAL;
using BancoNubank.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BancoNubank.Models
{
    public class Usuario : IUsuarioService
    {       
        private double _saldo;

        #region Propriedades
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
        #endregion
        #region Construtores
        public Usuario()
        {            
        }
        
        public Usuario(double saldo)
        {           
            _saldo = saldo;
        }
        #endregion

        public double ContaBancaria
        {
            get { return _saldo; }            
        }


        public void CriarConta(string nome, string senha, string email, string telefone, 
            string endereco, DateTime dataNasc)
        {
            string sql = "Insert Into usuarios (nome, senha, email, telefone, endereco, dataNasc) " +
                "Values (@nome, @senha, @email, @telefone, @endereco, @dataNasc);";
            try
            {
                string Con = ConfigurationManager.ConnectionStrings["DBConexao"].ConnectionString;
                var connection = new MySqlConnection(Con);
                connection.Open();
                MySqlCommand cmdUsuario = new MySqlCommand(sql, connection);
                cmdUsuario.Parameters.AddWithValue("@nome", nome);
                cmdUsuario.Parameters.AddWithValue("@senha", senha);
                cmdUsuario.Parameters.AddWithValue("@email", email);
                cmdUsuario.Parameters.AddWithValue("@telefone", telefone);
                cmdUsuario.Parameters.AddWithValue("@endereco", endereco);
                cmdUsuario.Parameters.AddWithValue("@dataNasc", dataNasc);

                cmdUsuario.ExecuteNonQuery();

            }
            catch
            {
                throw new Exception("Erro ao conectar ao banco de dados.");
            }
        }
        public void DeletarConta(int id)
        {
            string sql = "DELETE FROM usuarios WHERE id=@id;";

            try
            {
                string Con = ConfigurationManager.ConnectionStrings["DBConexao"].ConnectionString;
                var connection = new MySqlConnection(Con);
                connection.Open();
                MySqlCommand cmdUsuario = new MySqlCommand(sql, connection);

                cmdUsuario.Parameters.AddWithValue("@id", id);

                cmdUsuario.ExecuteNonQuery();

            }
            catch
            {
                throw new Exception("Erro ao conectar ao banco de dados.");
            }
        }
        public void Depositar(double valor)
        {
           if(valor < 0)
            {
                throw new ArgumentOutOfRangeException("Valor de depósito inválido.");
            }
            _saldo += valor;
        }
        public void EditarConta(int id, string nome, string senha, string email, 
            string telefone, string endereco, DateTime dataNasc)
        {
            string sql = "Update usuarios SET nome=@nome, senha=@senha, email=@email, " +
                "telefone=@telefone, endereco=@endereco, dataNasc=@dataNasc WHERE id=@id;";

            try
            {
                string Con = ConfigurationManager.ConnectionStrings["DBConexao"].ConnectionString;
                var connection = new MySqlConnection(Con);
                connection.Open();
                MySqlCommand cmdUsuario = new MySqlCommand(sql, connection);

                cmdUsuario.Parameters.AddWithValue("@id", id);
                cmdUsuario.Parameters.AddWithValue("@nome", nome);
                cmdUsuario.Parameters.AddWithValue("@senha", senha);
                cmdUsuario.Parameters.AddWithValue("@email", email);
                cmdUsuario.Parameters.AddWithValue("@telefone", telefone);
                cmdUsuario.Parameters.AddWithValue("@endereco", endereco);
                cmdUsuario.Parameters.AddWithValue("@dataNasc", dataNasc);

                cmdUsuario.ExecuteNonQuery();

            }
            catch
            {
                throw new Exception("Erro ao conectar ao banco de dados.");                
            }
        }
        public void Sacar(double valor)
        {
            if (valor > _saldo)
            {
                throw new ArgumentOutOfRangeException("Valor de saque inválido.");
            }
            else
            {
                _saldo -= valor;
            }
        }
        public void Transferir(double valor, int idDestino, ContaBancaria outraConta)
        {
            Sacar(valor);
            outraConta.Depositar(valor);

        }
    }
}
