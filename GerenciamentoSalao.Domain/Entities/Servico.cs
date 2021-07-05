using System;

namespace GerenciamentoSalao.Domain.Entities
{
    public class Servico : Entity
    {
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }

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
