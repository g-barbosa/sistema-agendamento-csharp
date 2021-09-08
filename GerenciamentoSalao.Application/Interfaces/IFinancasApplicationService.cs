using GerenciamentoSalao.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoSalao.Application.Interfaces
{
    public interface IFinancasApplicationService
    {
        Task<FinancasDTO> Get();
    }
}
