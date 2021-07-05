using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Funcionario : Entity
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public DateTime Entrada { get; private set; }
        public DateTime Saida { get; private set; }

        protected Funcionario () { }

        public Funcionario(string nome, string telefone, string login, string password, DateTime entrada, DateTime saida)
        {
            Nome = nome;
            Telefone = telefone;
            Login = login;
            Password = password;
            Entrada = entrada;
            Saida = saida;
        }

        public void AlterarFuncionario(Funcionario funcionario)
        {
            Nome = funcionario.Nome;
            Telefone = funcionario.Telefone;
            Login = funcionario.Login;
            Password = funcionario.Password;
            Entrada = funcionario.Entrada;
            Saida = funcionario.Saida;
        }
    }
}
