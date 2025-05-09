using System;
using System.Collections.Generic;
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
                if (string.IsNullOrWhiteSpace(value) || !value.All(char.IsLetter))
                    throw new ArgumentException("O nome deve conter apenas letras e não pode estar vazio.");
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

        public bool TipoFuncionario
        {
            get => _tipoFuncionario;
            set => _tipoFuncionario = value; // aqui não precisa de validação específica, mas mantemos o padrão
        }

        // Construtor
        public Funcionario(int id, string nome, string telefone, bool tipoFuncionario)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            TipoFuncionario = tipoFuncionario;
        }

        public bool Gravar()
        {
            string linha = $"{Id};{Nome};{Telefone};{TipoFuncionario}";
            return Funcionalidades.GravarBaseDados("funcionarios", linha);
        }

        public bool GravarLogin(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                password = "atec123";
            }
            string linha = $"{Id};{Nome};{password}";
            return Funcionalidades.GravarBaseDados("logins", linha);
        }

        public override string ToString()
        {
            return $"{Id}: {Nome} - {Telefone} - {(TipoFuncionario ? "Gerente" : "Funcionário")}";
        }
    }
}
