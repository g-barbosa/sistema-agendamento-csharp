using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using System.Collections.Generic;

namespace GerenciamentoSalao.Infra.CrossCutting.Interfaces
{
    public interface IMapperAgenda
    {
        Agenda MapperDTOToEntity(AgendaDTO DTO);
        IEnumerable<AgendaDTO> MapperListDTO(IEnumerable<Agenda> entities);
        AgendaDTO MapperEntityToDTO(Agenda entity);
    }
}
