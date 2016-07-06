namespace TeduSho.Data.Infrastructure
{
    public class UnitOfWord : IUnitOfWord
    {
        // dùng để commit 2 phương thức vào database
        private readonly IDbFactory dbFactory;
        private TeduShopDbContext dbContext;

        public UnitOfWord(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public TeduShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}