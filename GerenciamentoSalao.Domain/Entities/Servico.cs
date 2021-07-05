using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Servico : Entity
    {
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }

        protected Servico() { }

        public Servico(string descricao, decimal preco)
        {
            Descricao = descricao;
            Preco = preco;
        }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void AlterarPreco(decimal preco)
        {
            Preco = preco;
        }
    }
}
