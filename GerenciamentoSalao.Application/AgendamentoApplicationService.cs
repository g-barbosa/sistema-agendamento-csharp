using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Application
{
    public class AgendamentoApplicationService : IAgendamentoApplicationService
    {
        private readonly IAgendamentoService _service;
        private readonly IMapperAgendamento _mapper;

        public AgendamentoApplicationService(IAgendamentoService service, IMapperAgendamento mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(AgendamentoDTO DTO)
        {
            var model = _mapper.MapperDTOToEntity(DTO);
            _service.Add(model);
        }

        public IEnumerable<AgendamentoDTOResponse> GetAll()
        {
            var models = _service.GetAll();

            return _mapper.MapperListDTO(models);
        }

        public AgendamentoDTOResponse GetById(Guid id)
        {
            var model = _service.GetById(id);
            if (model == null) throw new Exception("Não foi possível encontrar este agendamento");

            return _mapper.MapperEntityToDTO(model);
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

        public void Update(AgendamentoDTO DTO)
        {
            var model = _service.GetById(DTO.Id);
            model.AlterarProduto(DTO.ProdutoId);
            model.AlterarServico(DTO.ServicoId);
            _service.Update(model);
        }
    }
}
