using GerenciamentoSalao.Domain.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Domain.Core.Interfaces.Services
{
    public interface IAccountService<TEntity> where TEntity : class
    {
        dynamic Login(string login, string password);
    }
}
