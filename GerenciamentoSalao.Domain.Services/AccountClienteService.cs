using GerenciamentoSalao.Domain.Core.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Entities;
using System;

namespace GerenciamentoSalao.Domain.Services
{
    public class AccountClienteService : BaseAccountService<Cliente>, IAccountClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly ICryptography _cryptography;

        public AccountClienteService(IClienteRepository repository, ICryptography cryptography) : base(repository)
        {
            _repository = repository;
            _cryptography = cryptography;
        }

        public override Cliente Login(string login, string password)
        {
            var user = _repository.GetByLogin(login);

            var validado = _cryptography.Verify(user.Password, password);

            if (!validado) throw new Exception("Usuário ou senha incorretas");

            return user;
        }
    }
}
