using System.Collections.Generic;
using System.Linq;
using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface IOderRepository
    {
        IEnumerable<Oder> GetById(int id);
    }
    public class OderRepository : ResponsitoryBase<Oder>, IOderRepository
    {
        public OderRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<Oder> GetById(int id)
        {
            return this.dbContext.Oders.Where(x => x.ID == id);
        }
    }
}
