﻿using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface IPostCategoryRepository : IResponsitory<PostCategory>
    {

    }
    public class PostCategoryRepository : ResponsitoryBase<PostCategory>
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
