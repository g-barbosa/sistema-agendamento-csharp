using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Application
{
    class AccountClienteApplicationService : IAccountApplicationService
    {
        private readonly IAccountClienteService _service;
        public AccountClienteApplicationService(IAccountClienteService service)
        {
            _service = service;
        }
        public dynamic Login(string login, string password)
        {
            return _service.Login(login, password);
        }
    }
}
