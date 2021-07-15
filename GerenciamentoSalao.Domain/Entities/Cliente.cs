using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Cliente : User
    {
        protected Cliente() { }

        public Cliente(string nome, string telefone, string login, string password)
        {
            Nome = nome;
            Telefone = telefone;
            Login = login;
            Password = password;
            Role = "Cliente";
        }

        public void AlterarCliente(Cliente cliente)
        {
            Nome = cliente.Nome;
            Telefone = cliente.Telefone;
            Login = cliente.Login;
        }
    }
}
