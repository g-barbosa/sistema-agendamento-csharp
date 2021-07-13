using GerenciamentoSalao.Application.Interfaces;
using System;

namespace GerenciamentoSalao.Application.DTOS
{
    public class AgendaDTO : IDTORoot
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public Guid FuncionarioId { get; set; }
        public Guid ClienteId { get; set; }
        public Guid ServicoId { get; set; }
        public Guid ProdutoId { get; set; }
    }
}
