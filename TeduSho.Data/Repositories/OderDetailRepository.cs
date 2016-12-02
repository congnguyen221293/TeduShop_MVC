using System;
using System.Collections.Generic;
using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface IOderDetailRepository: IResponsitory<OderDetail>
    {
        IEnumerable<OderDetail> GetbByAlias(string alias);
    }
    public class OderDetailRepository : ResponsitoryBase<OderDetail>, IOderDetailRepository
    {
        public OderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<OderDetail> GetbByAlias(string alias)
        {
            throw new NotImplementedException();
        }
    }
}
