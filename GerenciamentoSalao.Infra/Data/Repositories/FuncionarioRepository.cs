using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Entities;
using System.Linq;

namespace GerenciamentoSalao.Infra.Data.Repositories
{
    class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        private readonly SqlContext _sqlContext;

        public FuncionarioRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public Funcionario GetByLogin(string login)
        {
            return _sqlContext.Set<Funcionario>().Where(f => f.Login == login).FirstOrDefault();
        }
    }

}
