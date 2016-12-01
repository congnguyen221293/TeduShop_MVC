﻿using TeduSho.Data.Infrastructure;
using TeduSho.Model;

namespace TeduSho.Data.Repositories
{
    public interface ISlideRepository
    {

    }
    public class SlideRepository : ResponsitoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}