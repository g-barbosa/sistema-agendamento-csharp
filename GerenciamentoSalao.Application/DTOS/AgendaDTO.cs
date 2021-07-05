using GerenciamentoSalao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.DTOS
{
    public class AgendaDTO
    {
        public DateTime Data { get; private set; }
        public Guid FuncionarioId { get; private set; }
        public Guid ClienteId { get; private set; }

        public Funcionario Funcionario { get; private set; }
        public Cliente Cliente { get; private set; }
    }
}
