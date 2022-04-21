using TeduShop.Data.Infrastructure;
using TeduShop.Model;

namespace TeduShop.Data.Repositories
{
    public interface IErrorRepository : IRepositories<Error>
    {
    }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}