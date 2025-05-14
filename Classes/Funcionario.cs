using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBugInn
{
    internal class Funcionario
    {
        private int _id;
        private string _nome;
        private string _telefone;
        private bool _tipoFuncionario;
        private string _password;
        private string _username;

        public int Id
        {
            get => _id;
            set
            {
                if (value < 0)
                    throw new ArgumentException("O ID não pode ser negativo.");
                _id = value;
            }
        }

        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    throw new ArgumentException("O nome deve conter apenas letras e espaços, e não pode estar vazio.");
                _nome = value;
            }
        }


        public string Telefone
        {
            get => _telefone;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.All(char.IsDigit) || value.Length < 9)
                    throw new ArgumentException("O telefone deve conter apenas números e ter pelo menos 9 dígitos.");
                _telefone = value;
            }
        }
        
        public string Password
        {
            get => _password;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                    throw new ArgumentException("A senha deve ter pelo menos 6 caracteres.");
                _password = value;
            }
        }

        public bool TipoFuncionario
        {
            get => _tipoFuncionario;
            set => _tipoFuncionario = value; // aqui não precisa de validação específica, mas mantemos o padrão
        }

        public string Username
        {
            get => _username;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome de usuário não pode estar vazio.");
                _username = value;
            }
        }

        // Construtor
        public Funcionario(int id, string nome, string telefone, bool tipoFuncionario, string password,string username)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            TipoFuncionario = tipoFuncionario;
            Password = password;
            Username = username;
        }



        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nome} | Username: {Username} | Telefone: {Telefone} | Cargo: {(TipoFuncionario ? "Gerente" : "Funcionário")} | Senha: {Password}";
        }
    }
}
