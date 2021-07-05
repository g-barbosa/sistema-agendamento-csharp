using GerenciamentoSalao.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.DTOS
{
    public class ClienteDTO: IDTORoot
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
