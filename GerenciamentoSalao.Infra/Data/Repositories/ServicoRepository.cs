using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Infra.Data.Repositories
{
    class ServicoRepository : BaseRepository<Servico>, IServicoRepository
    {
        private readonly SqlContext _sqlContext;

        public ServicoRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }

}