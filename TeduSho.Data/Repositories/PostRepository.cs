using System;
using System.Collections;
using System.Collections.Generic;
using TeduSho.Data.Infrastructure;
using TeduSho.Model;
using System.Linq;

namespace TeduSho.Data.Repositories
{
    public interface IPostRepository : IResponsitory<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }
    public class PostRepository : ResponsitoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in dbContext.Posts
                        join pt in dbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedBy descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query; 
        }
    }
}
