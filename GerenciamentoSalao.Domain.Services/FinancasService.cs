using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciamentoSalao.Domain.Services
{
    public class FinancasService : IFinancasService<FinancasDTO>
    {
        private readonly IServicoRepository _servicoRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IAgendamentoRepository _agendamentoRepository;
        public FinancasService(
            IServicoRepository servicoRepository, 
            IProdutoRepository produtoRepository, 
            IAgendamentoRepository agendamentoRepository)
        {
            _servicoRepository = servicoRepository;
            _produtoRepository = produtoRepository;
            _agendamentoRepository = agendamentoRepository;
        }
        public FinancasDTO Get()
        {
            var agendamentos = _agendamentoRepository.GetAll();

            decimal lucro = 0;
            decimal despesa = 0;

            foreach (var agendamento in agendamentos)
            {
                var servico = _servicoRepository.GetById(agendamento.ServicoId);
                var produto = _produtoRepository.GetById(agendamento.ProdutoId);

                lucro += servico.Preco;
                despesa += produto.Preco;
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
