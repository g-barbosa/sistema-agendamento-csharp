using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Application
{
    public class AgendaApplicationService : IAgendaApplicationService
    {
        private readonly IAgendaService _service;
        private readonly IMapperAgenda _mapper;

        public AgendaApplicationService(IAgendaService service, IMapperAgenda mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(AgendaDTO DTO)
        {
            var model = _mapper.MapperDTOToEntity(DTO);
            _service.Add(model);
        }

        public IEnumerable<AgendaDTO> GetAll()
        {
            var models = _service.GetAll();

            return _mapper.MapperListDTO(models);
        }

        public AgendaDTO GetById(Guid id)
        {
            var model = _service.GetById(id);
            if (model == null) throw new Exception("Não foi possível encontrar esta agenda");

            return _mapper.MapperEntityToDTO(model);
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

        public void Update(AgendaDTO DTO)
        {
            var model = _service.GetById(DTO.Id);
            model.AlterarFuncionario(DTO.Funcionario);
            model.AlterarData(DTO.Data);
            _service.Update(model);
        }
    }
}
