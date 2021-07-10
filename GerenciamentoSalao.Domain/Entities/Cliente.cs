using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Cliente : Entity, IUser
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        protected Cliente() { }

        public Cliente(string nome, string telefone, string login, string password)
        {
            Nome = nome;
            Telefone = telefone;
            Login = login;
            Password = password;
        }

        public void AlterarCliente(Cliente cliente)
        {
            Nome = cliente.Nome;
            Telefone = cliente.Telefone;
            Login = cliente.Login;
        }

        public void AlterarPassword(string newPassword)
        {
            Password = newPassword;
        }
    }
}
