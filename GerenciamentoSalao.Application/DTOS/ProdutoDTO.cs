using GerenciamentoSalao.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.DTOS
{
    public class ProdutoDTO : IDTORoot
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
