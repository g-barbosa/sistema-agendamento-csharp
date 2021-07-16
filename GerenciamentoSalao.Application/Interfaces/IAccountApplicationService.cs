using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.DTO;

namespace GerenciamentoSalao.Application.Interfaces
{
    public interface IAccountApplicationService
    {
        dynamic Login(LoginDTO DTO);
    }
}
