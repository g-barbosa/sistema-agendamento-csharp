using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Entities;
using System.Collections.Generic;

namespace GerenciamentoSalao.Infra.CrossCutting.Interfaces
{
    public interface IMapperAgendamento
    {
        Agendamento MapperDTOToEntity(AgendamentoDTO DTO);
        IEnumerable<AgendamentoDTOResponse> MapperListDTO(IEnumerable<Agendamento> entities);
        AgendamentoDTOResponse MapperEntityToDTO(Agendamento entity);
    }
}
