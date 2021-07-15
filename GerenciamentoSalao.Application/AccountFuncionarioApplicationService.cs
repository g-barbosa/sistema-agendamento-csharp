using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Application
{
    class AccountFuncionarioApplicationService : IAccountApplicationService
    {
        private readonly IAccountFuncionarioService _service;
        public AccountFuncionarioApplicationService(IAccountFuncionarioService service)
        {
            _service = service;
        }
        public dynamic Login(string login, string password)
        {
            return _service.Login(login, password);
        }
    }
}
