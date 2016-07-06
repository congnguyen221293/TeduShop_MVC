namespace TeduSho.Data.Infrastructure
{
    public class DbFactory : Disponable, IDbFactory
    {
        private TeduShopDbContext DbContext;

        public TeduShopDbContext Init()
        {
            return DbContext ?? (DbContext = new TeduShopDbContext);
        }

        protected override void DisposeCore()
        {
            if (DbContext != null)
            {
                DbContext.Dispose();
            }
        }
    }
}