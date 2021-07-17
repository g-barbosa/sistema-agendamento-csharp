using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Domain.Core.Interfaces.Services
{
    public interface IFinancasService<TEntity> where TEntity : class
    {
        TEntity Get();
    }
}
