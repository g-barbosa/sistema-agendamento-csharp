using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Infra.Data.Repositories
{
    class AgendamentoRepository : BaseRepository<Agendamento>, IAgendamentoRepository
    {
        private readonly SqlContext _sqlContext;

        public AgendamentoRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
