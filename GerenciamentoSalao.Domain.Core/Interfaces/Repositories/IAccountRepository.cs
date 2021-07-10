using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Domain.Core.Interfaces.Repositories
{
    public interface IAccountRepository<TEntity> where TEntity : class
    {
        TEntity GetByLogin(string login);
    }
}
