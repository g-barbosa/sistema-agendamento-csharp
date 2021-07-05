using GerenciamentoSalao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.DTOS
{
    public class AgendamentoDTO
    {
        public Guid Id { get; set; }
        public Guid ProdutoId { get; private set; }
        public Guid ServicoId { get; private set; }
        public Guid AgendaId { get; private set; }

        public Produto Produto { get; private set; }
        public Servico Servico { get; private set; }
        public Agenda Agenda { get; private set; }
    }
}
