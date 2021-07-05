using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using System.Collections.Generic;

namespace GerenciamentoSalao.Infra.CrossCutting.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperDTOToEntity(ProdutoDTO DTO);
        IEnumerable<ProdutoDTO> MapperListDTO(IEnumerable<Produto> entities);
        ProdutoDTO MapperEntityToDTO(Produto entity);
    }
}
