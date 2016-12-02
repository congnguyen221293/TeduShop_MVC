using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface IProductCategoryRepository : IResponsitory<ProductCategory>
    {
        IEnumerable<ProductCategory> GetbyAlias(string alias);

    }
    public class ProductCategoryRepository : ResponsitoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {


        }

        public IEnumerable<ProductCategory> GetbyAlias(string alias)
        {
            return this.dbContext.ProductCategorys.Where(x => x.Alias == alias);
        }
    }
}
