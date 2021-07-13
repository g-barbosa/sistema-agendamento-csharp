using GerenciamentoSalao.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.Interfaces
{
    public interface IAgendaApplicationService
    {
        void Add(AgendaDTO agendaDTO);
        void Update(AgendaDTO agendaDTO);
        void Remove(Guid id);
        IEnumerable<AgendamentoDTOResponse> GetAll();
        AgendamentoDTOResponse GetById(Guid id);
    }
}
