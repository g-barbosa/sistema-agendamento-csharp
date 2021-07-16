using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.DTO;

namespace GerenciamentoSalao.Application
{
    public class AccountFuncionarioApplicationService : IAccountFuncionarioApplicationService
    {
        private readonly IAccountFuncionarioService _service;
        public AccountFuncionarioApplicationService(IAccountFuncionarioService service)
        {
            _service = service;
        }
        public dynamic Login(LoginDTO DTO)
        {
            return _service.Login(DTO);
        }
    }
}
