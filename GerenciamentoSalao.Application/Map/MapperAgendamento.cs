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

        public AgendamentoDTO MapperEntityToDTO(Agendamento model)
        {
            var DTO = new AgendamentoDTO()
            {
                Id = model.Id,
                ProdutoId = model.ProdutoId,
                ServicoId = model.ServicoId,
                AgendaId = model.AgendaId
            };

            return DTO;
        }

        public IEnumerable<AgendamentoDTO> MapperListDTO(IEnumerable<Agendamento> models)
        {
            var dto = models.Select(model => MapperEntityToDTO(model));
            return dto;
        }
    }
}
