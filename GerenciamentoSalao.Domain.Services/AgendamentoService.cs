using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Domain.Services
{
    public class AgendamentoService : BaseService<Agendamento>, IAgendamentoService
    {
        private readonly IAgendamentoRepository _repository;
        public AgendamentoService(IAgendamentoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
