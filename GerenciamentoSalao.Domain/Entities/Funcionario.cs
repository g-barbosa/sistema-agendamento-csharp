using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Funcionario : User
    {
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
            Role = "Funcionario";
        }

        public void AlterarFuncionario(Funcionario funcionario)
        {
            Nome = funcionario.Nome;
            Telefone = funcionario.Telefone;
            Login = funcionario.Login;
            Entrada = funcionario.Entrada;
            Saida = funcionario.Saida;
        }
    }
}
