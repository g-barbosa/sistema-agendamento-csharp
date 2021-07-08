using GerenciamentoSalao.Domain.Core.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Domain.Services
{
    public class FuncionarioService : BaseService<Funcionario>, IFuncionarioService
    {
        private readonly IFuncionarioRepository _repository;
        private readonly ICryptography _cryptography;
        public FuncionarioService(IFuncionarioRepository repository, ICryptography cryptography) : base(repository)
        {
            _repository = repository;
            _cryptography = cryptography;
        }

        public void Add(Funcionario funcionario)
        {
            funcionario.AlterarPassword(_cryptography.Encrypt(funcionario.Password));
            _repository.Add(funcionario);
        }
    }
}
