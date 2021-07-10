using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Domain.Core.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Remove(Guid id);
        void Update(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
    }
}
