using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Agendamento : Entity
    {
        public Guid ProdutoId { get; private set; }
        public Guid ServicoId { get; private set; }
        public Guid AgendaId { get; private set; }

        public Produto Produto { get; private set; }
        public Servico Servico { get; private set; }
        public Agenda Agenda { get; private set; }

        public void AlterarProduto(Produto produto)
        {
            ProdutoId = produto.Id;
            Produto = produto;
        }

        public void AlterarServico(Servico servico)
        {
            ServicoId = servico.Id;
            Servico = servico;
        }
    }
}
