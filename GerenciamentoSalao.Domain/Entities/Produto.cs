using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Produto : Entity
    {
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }

        protected Produto() { }

        public Produto(string descricao, int quantidade, decimal preco)
        {
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }

        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;
            if (!PossuiEstoque(quantidade)) throw new Exception("Estoque insuficiente");
            Quantidade -= quantidade;
        }

        public void ReporEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public bool PossuiEstoque(int quantidade)
        {
            return Quantidade >= quantidade;
        }
    }
}
