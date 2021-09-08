using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoSalao.Domain.Core.Interfaces.Services
{
    public interface IFinancasService<TEntity> where TEntity : class
    {
        Task<TEntity> Get();
    }
}
