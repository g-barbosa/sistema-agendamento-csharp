using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoSalao.Infra.CrossCutting.Map
{
    public class MapperAgendamento : IMapperAgendamento
    {
        public Agendamento MapperDTOToEntity(AgendamentoDTO DTO)
        {
            var model = new Agendamento(
                DTO.ProdutoId,
                DTO.ServicoId,
                DTO.AgendaId);

            return model;
        }

        public AgendamentoDTOResponse MapperEntityToDTO(Agendamento model)
        {
            var DTO = new AgendamentoDTOResponse()
            {
                Id = model.Id,
                Produto = model.Produto,
                Servico = model.Servico,
                Data = model.Agenda.Data,
                Cliente = model.Agenda.Cliente,
                Funcionario = model.Agenda.Funcionario
            };

            return DTO;
        }

        public IEnumerable<AgendamentoDTOResponse> MapperListDTO(IEnumerable<Agendamento> models)
        {
            var dto = models.Select(model => MapperEntityToDTO(model));
            return dto;
        }
    }
}
