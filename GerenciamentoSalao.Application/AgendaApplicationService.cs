using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Entities;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Application
{
    public class AgendaApplicationService : IAgendaApplicationService
    {
        private readonly IAgendaService _service;
        private readonly IMapperAgenda _mapper;
        private readonly IMapperAgendamento _mapperAgendamento;
        private readonly IAgendamentoService _agendamentoService;

        public AgendaApplicationService(
            IAgendaService service, 
            IMapperAgenda mapper, 
            IMapperAgendamento mapperAgendamento, 
            IAgendamentoService agendamentoService)
        {
            _service = service;
            _mapper = mapper;
            _mapperAgendamento = mapperAgendamento;
            _agendamentoService = agendamentoService;
        }

        public void Add(AgendaDTO DTO)
        {
            var model = _mapper.MapperDTOToEntity(DTO);
            _service.Add(model);

            var agendamento = new Agendamento(DTO.ProdutoId, DTO.ServicoId, model.Id);
            _agendamentoService.Add(agendamento);
        }

        public IEnumerable<AgendamentoDTOResponse> GetAll()
        {
            var models = _agendamentoService.GetAll();

            return _mapperAgendamento.MapperListDTO(models);
        }

        public AgendamentoDTOResponse GetById(Guid id)
        {
            var model = _agendamentoService.GetById(id);
            if (model == null) throw new Exception("Não foi possível encontrar esta agenda");

            return _mapperAgendamento.MapperEntityToDTO(model);
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

        public void Update(AgendaDTO DTO)
        {
            var model = _service.GetById(DTO.Id);
            model.AlterarFuncionario(DTO.FuncionarioId);
            model.AlterarData(DTO.Data);
            _service.Update(model);
        }
    }
}
