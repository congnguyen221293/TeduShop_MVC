using System;

namespace TeduSho.Data.Infrastructure
{
    public interface IDbFactory
    {
        TeduShopDbContext Init();
    }
}