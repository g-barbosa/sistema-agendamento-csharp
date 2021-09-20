using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using GerenciamentoSalao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoSalao.Domain.Services
{
    public class FinancasService : IFinancasService<FinancasDTO>
    {
        private readonly IAgendamentoRepository _agendamentoRepository;
        public FinancasService(
            IAgendamentoRepository agendamentoRepository)
        {
            _agendamentoRepository = agendamentoRepository;
        }
        public async Task<FinancasDTO> Get()
        {
            var agendamentos = _agendamentoRepository.GetAll().AsParallel().WithDegreeOfParallelism(4);

            decimal lucro = 0;
            decimal despesa = 0;


            foreach(var agendamento in agendamentos)
            {
                lucro += agendamento.Servico.Preco;
                despesa += agendamento.Produto.Preco;
            }

            return new FinancasDTO()
            {
                Total = lucro - despesa,
                Lucro = lucro,
                Despesa = despesa
            };
        }
    }
}
