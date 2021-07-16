using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Core.DomainObjects;
using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoSalao.Domain.Services
{
    public abstract class BaseAccountService<TEntity> : IAccountService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseAccountService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public abstract dynamic Login(LoginDTO DTO);
    }
}
