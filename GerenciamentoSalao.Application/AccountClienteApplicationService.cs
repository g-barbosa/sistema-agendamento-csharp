using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.DTO;

namespace GerenciamentoSalao.Application
{
    public class AccountClienteApplicationService : IAccountClienteApplicationService
    {
        private readonly IAccountClienteService _service;
        public AccountClienteApplicationService(IAccountClienteService service)
        {
            _service = service;
        }
        public dynamic Login(LoginDTO DTO)
        {
            return _service.Login(DTO);
        }
    }
}
