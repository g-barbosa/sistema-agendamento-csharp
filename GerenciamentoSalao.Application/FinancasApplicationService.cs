using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Application.Interfaces;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using System;

namespace GerenciamentoSalao.Application
{
    public class FinancasApplicationService : IFinancasApplicationService
    {
        private readonly IFinancasService<FinancasDTO> _financasServices;
        public FinancasApplicationService(IFinancasService<FinancasDTO> financasServices)
        {
            _financasServices = financasServices;
        }
        public FinancasDTO Get()
        {
            return _financasServices.Get();
        }
    }
}
