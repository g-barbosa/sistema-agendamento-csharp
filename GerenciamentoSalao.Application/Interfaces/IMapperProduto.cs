using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Infra.CrossCutting.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperDTOToEntity(ProdutoDTO produtoDTO);
        IEnumerable<ProdutoDTO> MapperListProdutosDTO(IEnumerable<Produto> produtos);
        ProdutoDTO MapperEntityToDTO(Produto produto);
    }
}
