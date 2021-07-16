using GerenciamentoSalao.Domain.Core.Interfaces.Repositories;
using GerenciamentoSalao.Domain.Entities;
using System.Linq;

namespace GerenciamentoSalao.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly SqlContext _sqlContext;

        public ClienteRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public Cliente GetByLogin(string login)
        {
            return _sqlContext.Set<Cliente>().Where(c => c.Login == login).FirstOrDefault();
        }
    }
}
