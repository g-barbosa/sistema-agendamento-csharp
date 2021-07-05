using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using GerenciamentoSalao.Infra.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoSalao.Infra.CrossCutting.Map
{
    public class MapperAgenda : IMapperAgenda
    {
        public Agenda MapperDTOToEntity(AgendaDTO DTO)
        {
            var model = new Agenda(
                DTO.Data,
                DTO.FuncionarioId,
                DTO.ClienteId);

            return model;
        }

        public AgendaDTO MapperEntityToDTO(Agenda model)
        {
            var DTO = new AgendaDTO()
            {
                Id = model.Id,
                FuncionarioId = model.FuncionarioId,
                ClienteId = model.ClienteId,
            };

            return DTO;
        }

        public IEnumerable<AgendaDTO> MapperListDTO(IEnumerable<Agenda> models)
        {
            var dto = models.Select(model => MapperEntityToDTO(model));
            return dto;
        }
    }
}
