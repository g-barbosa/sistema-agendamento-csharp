using GerenciamentoSalao.Application.DTOS;
using System;
using System.Collections.Generic;

namespace GerenciamentoSalao.Application.Interfaces
{
    public interface IFuncionarioApplicationService
    {
        void Add(FuncionarioDTO funcionarioDTO);
        void Update(FuncionarioDTO funcionarioDTO);
        void Remove(FuncionarioDTO funcionarioDTO);
        IEnumerable<FuncionarioDTO> GetAll();
        FuncionarioDTO GetById(Guid id);
    }
}
