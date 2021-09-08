using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task<FinancasDTO> Get()
        {
            var agendamentos = _agendamentoRepository.GetAll();

            decimal lucro = 0;
            decimal despesa = 0;

            var somasTasks = agendamentos.Select(agendamento => Task.Factory.StartNew(() =>
            {
                var servico = _servicoRepository.GetById(agendamento.ServicoId);
                var produto = _produtoRepository.GetById(agendamento.ProdutoId);

                (decimal lucro, decimal despesa) resultado = (servico.Preco, produto.Preco);
                return resultado;
            }));

            var resultados = await Task.WhenAll(somasTasks);

            lucro = resultados.Sum(l => l.lucro);
            despesa = resultados.Sum(d => d.despesa);

            return new FinancasDTO()
            {
                Total = lucro - despesa,
                Lucro = lucro,
                Despesa = despesa
            };
        }
    }
}
