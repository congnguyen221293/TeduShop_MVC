using System.Collections.Generic;
using System.Linq;
using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface IProductRepository{
    IEnumerable<Product> GetByAlias(string alias);
    }
    public class ProductRepository : ResponsitoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Product> GetByAlias(string alias)
        {
            return this.dbContext.Products.Where(x => x.Alias == alias);
        }
    }
}
