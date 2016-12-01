using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface IFooterRepository
    {
        IEnumerable<Footer> GetById(string id);

    }
    public class FooterRepository : ResponsitoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Footer> GetById(string id)
        {
            return this.dbContext.Footers.Where(x => x.ID == id);
        }
    }
}
