using GerenciamentoSalao.Domain.DTO;

namespace GerenciamentoSalao.Domain.Core.Interfaces.Services
{
    public interface IAccountService<TEntity> where TEntity : class
    {
        dynamic Login(LoginDTO DTO);
    }
}
