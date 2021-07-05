using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Application
{
    public class ProdutoApplicationService : IProdutoApplicationService
    {
        private readonly IProdutoService _service;
        private readonly IMapperProduto _mapper;

        public ProdutoApplicationService(IProdutoService service, IMapperProduto mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(ProdutoDTO produtoDTO)
        {
            var cliente = _mapper.MapperDTOToEntity(produtoDTO);
            _service.Add(cliente);
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = _service.GetAll();

            return _mapper.MapperListProdutosDTO(produtos);
        }

        public ProdutoDTO GetById(Guid id)
        {
            var produto = _service.GetById(id);
            return _mapper.MapperEntityToDTO(produto);
        }

        public void Remove(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.MapperDTOToEntity(produtoDTO);
            _service.Remove(produto);
        }

        public void Update(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.MapperDTOToEntity(produtoDTO);
            _service.Update(produto);
        }
    }
}
