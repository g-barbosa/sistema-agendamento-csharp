using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.DTOS
{
    public class AgendaDTO : IDTORoot
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public Guid FuncionarioId { get; set; }
        public Guid ClienteId { get; set; }

        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
    }
}
