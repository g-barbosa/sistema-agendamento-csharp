using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Domain.Services
{
    public class ServicoService : BaseService<Servico>, IServicoService
    {
        private readonly IServicoRepository _repository;
        public ServicoService(IServicoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
