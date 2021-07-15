using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Domain.Entities
{
    public class User : Entity
    {
        public string Nome { get; protected set; }
        public string Telefone { get; protected set; }
        public string Login { get; protected set; }
        public string Password { get; protected set; }
        public string Role { get; protected set; }

        public void AlterarPassword(string newPassword)
        {
            Password = newPassword;
        }
    }
}
