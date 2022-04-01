using GerenciamentoSalao.Application.DTOS;
using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Entities;
using GerenciamentoSalao.Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace GerenciamentoSalao.Testes
{
    public class financaServiceTests
    {
        private readonly Mock<IAgendamentoRepository> _mockAgendamentoRepository;
        public financaServiceTests()
        {
            _mockAgendamentoRepository = new Mock<IAgendamentoRepository>();
        }
        [Fact]
        public async Task TestasCalculoDeRetornoDeFinancasAsync()
        {
            //Arrange
            var agendamentos = new List<Agendamento>() {
                new Agendamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid())
                {
                    Ativo = true,
                    DataCadastro = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Servico = new Servico("Corte", 100),
                    Produto = new Produto("Tesoura", 1, 50)
                },
                new Agendamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid())
                {
                    Ativo = true,
                    DataCadastro = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Servico = new Servico("Progressiva", 50),
                    Produto = new Produto("Shampoo", 1, 15)
                },
            };

            _mockAgendamentoRepository.Setup(c => c.GetAll()).Returns(agendamentos);
            var mock = _mockAgendamentoRepository.Object;

            var financasService = new FinancasService(mock);

            //Act
            FinancasDTO financas = await financasService.Get();
            var expected = new FinancasDTO()
            {
                Despesa = 65,
                Lucro = 150,
                Total = 85
            };

            //Assert
            Assert.NotNull(financas);
            Assert.Equal(65, financas.Despesa);
            Assert.Equal(150, financas.Lucro);
            Assert.Equal(85, financas.Total);
        }
    }
}
