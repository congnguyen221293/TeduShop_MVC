using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface IProductTagRepository
    {

    }
    public class ProductTagRepository : ResponsitoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
