using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Domain.Services
{
    public class AgendaService : BaseService<Agenda>, IAgendaService
    {
        private readonly IAgendaRepository _repository;
        public AgendaService(IAgendaRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
