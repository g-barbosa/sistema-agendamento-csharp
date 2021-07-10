using GerenciamentoSalao.Domain.Core.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Domain.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly ICryptography _cryptography;
        public ClienteService(IClienteRepository repository, ICryptography cryptography) : base(repository)
        {
            _repository = repository;
            _cryptography = cryptography;
        }

        public new void Add(Cliente cliente)
        {
            cliente.AlterarPassword(_cryptography.Encrypt(cliente.Password));
            _repository.Add(cliente);
        }
    }
}
