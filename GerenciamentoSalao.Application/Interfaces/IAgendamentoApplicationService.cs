using GerenciamentoSalao.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Application.Interfaces
{
    public interface IAgendamentoApplicationService
    {
        void Add(AgendamentoDTO agendamentoDTO);
        void Update(AgendamentoDTO agendamentoDTO);
        void Remove(Guid id);
        IEnumerable<AgendamentoDTOResponse> GetAll();
        AgendamentoDTOResponse GetById(Guid id);
    }
}
