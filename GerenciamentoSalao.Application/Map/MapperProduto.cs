﻿using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoSalao.Infra.CrossCutting.Map
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDTOToEntity(ProdutoDTO DTO)
        {
            var model = new Produto()
            {
                Id = DTO.Id,
                Descricao = DTO.Descricao,
                Preco = DTO.Preco,
                Quantidade = DTO.Quantidade,
            };

            return model;
        }

        public ProdutoDTO MapperEntityToDTO(Produto produto)
        {
            var DTO = new ProdutoDTO()
            {
                Id = produto.Id,
                Quantidade = produto.Quantidade,
                Descricao = produto.Descricao,
                Preco = produto.Preco,
            };

            return DTO;
        }

        public IEnumerable<ProdutoDTO> MapperListProdutosDTO(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(produto => MapperEntityToDTO(produto));
            return dto;
        }
    }
}
