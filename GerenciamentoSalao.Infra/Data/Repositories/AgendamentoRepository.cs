using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoSalao.Infra.Data.Repositories
{
    class AgendamentoRepository : BaseRepository<Agendamento>, IAgendamentoRepository
    {
        private readonly SqlContext _sqlContext;

        public AgendamentoRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public override Agendamento GetById(Guid id)
        {
            return _sqlContext.Agendamentos
                .Include(a => a.Agenda)
                    .ThenInclude(a => a.Cliente)
                .Include(a => a.Agenda)
                    .ThenInclude(a => a.Funcionario)
                .Include(a => a.Produto)
                .Include(a => a.Servico)
                .Where(a => a.Id == id).FirstOrDefault();
        }

        public override IEnumerable<Agendamento> GetAll()
        {
            return _sqlContext.Agendamentos
                .Include(a => a.Agenda)
                    .ThenInclude(a => a.Cliente)
                .Include(a => a.Agenda)
                    .ThenInclude(a => a.Funcionario)
                .Include(a => a.Produto)
                .Include(a => a.Servico).ToList();
        }
    }
}
