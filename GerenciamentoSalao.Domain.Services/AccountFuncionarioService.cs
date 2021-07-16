using GerenciamentoSalao.Domain.Core.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.DTO;
using GerenciamentoSalao.Domain.Entities;
using System;

namespace GerenciamentoSalao.Domain.Services
{
    public class AccountFuncionarioService : BaseAccountService<Funcionario>, IAccountFuncionarioService
    {
        private readonly IFuncionarioRepository _repository;
        private readonly ICryptography _cryptography;

        public AccountFuncionarioService(IFuncionarioRepository repository, ICryptography cryptography) : base(repository)
        {
            _repository = repository;
            _cryptography = cryptography;
        }

        public override dynamic Login(LoginDTO DTO)
        {
            var user = _repository.GetByLogin(DTO.login);

            if (user == null) throw new Exception("Usuário ou senha incorretas");

            var validado = _cryptography.Verify(user.Password, DTO.password);

            if (!validado) throw new Exception("Usuário ou senha incorretas");

            var token = TokenService.GenerateToken(user);
            user.AlterarPassword("");

            return new { user = user, token = token };
        }
    }
}
