using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Infra.Data.Repositories
{
    class AgendaRepository : BaseRepository<Agenda>, IAgendaRepository
    {
        private readonly SqlContext _sqlContext;

        public AgendaRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
