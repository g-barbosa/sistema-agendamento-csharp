using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Application
{
    public class FuncionarioApplicationService : IFuncionarioApplicationService
    {
        private readonly IFuncionarioService _service;
        private readonly IMapperFuncionario _mapper;

        public FuncionarioApplicationService(IFuncionarioService service, IMapperFuncionario mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(FuncionarioDTO DTO)
        {
            var model = _mapper.MapperDTOToEntity(DTO);
            _service.Add(model);
        }

        public IEnumerable<FuncionarioDTO> GetAll()
        {
            var models = _service.GetAll();

            return _mapper.MapperListDTO(models);
        }

        public FuncionarioDTO GetById(Guid id)
        {
            var model = _service.GetById(id);
            return _mapper.MapperEntityToDTO(model);
        }

        public void Remove(FuncionarioDTO DTO)
        {
            var model = _mapper.MapperDTOToEntity(DTO);
            _service.Remove(model);
        }

        public void Update(FuncionarioDTO DTO)
        {
            var model = _mapper.MapperDTOToEntity(DTO);
            _service.Update(model);
        }
    }
}
