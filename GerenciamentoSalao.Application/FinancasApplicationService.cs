using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace GerenciamentoSalao.Application
{
    public class FinancasApplicationService : IFinancasApplicationService
    {
        private readonly IFinancasService<FinancasDTO> _financasServices;
        public FinancasApplicationService(IFinancasService<FinancasDTO> financasServices)
        {
            _financasServices = financasServices;
        }
        public async Task<FinancasDTO> Get()
        {
            return await _financasServices.Get();
        }
    }
}
