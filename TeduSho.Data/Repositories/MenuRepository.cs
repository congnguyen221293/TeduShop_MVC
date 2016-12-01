using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface IMenuRepository {

    }
    public class MenuRepository : ResponsitoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
