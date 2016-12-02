using System;
using System.Linq;
using System.Linq.Expressions;
using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface IMenuRepository : IResponsitory<Menu>
    {

    }
    public class MenuRepository : ResponsitoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
