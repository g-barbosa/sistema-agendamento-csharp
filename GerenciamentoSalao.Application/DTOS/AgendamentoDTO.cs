using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.DTOS
{
    public class AgendamentoDTO : IDTORoot
    {
        public Guid Id { get; set; }
        public Guid ProdutoId { get; set; }
        public Guid ServicoId { get; set; }
        public Guid AgendaId { get; set; }
    }

    public class AgendamentoDTOResponse
    {
        public Guid Id { get; set; }
        public Produto Produto { get; set; }
        public Servico Servico { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
