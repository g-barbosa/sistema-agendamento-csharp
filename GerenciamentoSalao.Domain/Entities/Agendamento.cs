using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Agendamento : Entity
    {
        public Guid ProdutoId { get; private set; }
        public Guid ServicoId { get; private set; }
        public Guid AgendaId { get; private set; }

        public Produto Produto { get; set; }
        public Servico Servico { get; set; }
        public Agenda Agenda { get; set; }

        protected Agendamento() { }

        public Agendamento(Guid produtoId, Guid servicoId, Guid agendaId)
        {
            ProdutoId = produtoId;
            ServicoId = servicoId;
            AgendaId = agendaId;
        }

        public void AlterarProduto(Guid produtoId)
        {
            ProdutoId = produtoId;
        }

        public void AlterarServico(Guid servicoId)
        {
            ServicoId = servicoId;
        }
    }
}
