using GerenciamentoSalao.Application.DTOS;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Application.Interfaces
{
    public interface IProdutoApplicationService
    {
        void Add(ProdutoDTO produtoDTO);
        void Update(ProdutoDTO produtoDTO);
        void Remove(ProdutoDTO produtoDTO);
        IEnumerable<ProdutoDTO> GetAll();
        ProdutoDTO GetById(Guid id);
    }
}
