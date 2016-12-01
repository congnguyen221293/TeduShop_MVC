using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface IVisitorstatisticRepository
    {

    }
    public class VisitorstatisticRepository : ResponsitoryBase<Visitorstatistic>, IVisitorstatisticRepository
    {
        public VisitorstatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
