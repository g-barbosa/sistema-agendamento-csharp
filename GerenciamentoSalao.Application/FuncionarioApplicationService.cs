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
            if (model == null) throw new Exception("Não foi possível encontrar este funcionário");

            return _mapper.MapperEntityToDTO(model);
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

        public void Update(FuncionarioDTO DTO)
        {
            var model = _service.GetById(DTO.Id);
            var dtoToModel = _mapper.MapperDTOToEntity(DTO);
            model.AlterarFuncionario(dtoToModel);
            _service.Update(model);
        }
    }
}
