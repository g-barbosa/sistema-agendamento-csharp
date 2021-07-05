using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public void AlterarCliente(Cliente cliente)
        {
            Nome = cliente.Nome;
            Telefone = cliente.Telefone;
            Login = cliente.Login;
            Password = cliente.Password;
        }
    }
}
