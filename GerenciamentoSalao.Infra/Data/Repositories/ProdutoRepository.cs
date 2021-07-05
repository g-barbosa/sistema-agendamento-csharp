using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Entities;

namespace GerenciamentoSalao.Infra.Data.Repositories
{
    class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly SqlContext _sqlContext;

        public ProdutoRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }

}