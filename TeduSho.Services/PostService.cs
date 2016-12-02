using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduSho.Data.Infrastructure;
using TeduSho.Data.Repositories;
using TeduSho.Model;

namespace TeduSho.Services
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalPage);
        IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pagesize, out int totalPage);
        IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pagesize, out int totalPage);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        IPostRepository _postresponsitory;
        IUnitOfWord _unitofwwork;
        public PostService(IPostRepository postresponsitory, IUnitOfWord unitofwork)
        {
            this._postresponsitory = postresponsitory;
            this._unitofwwork = unitofwork;
        }
        public void Add(Post post)
        {
            _postresponsitory.Add(post);
        }

        public void Delete(int id)
        {
            _postresponsitory.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postresponsitory.GetAll(new string []{ "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pagesize, out int totalPage)
        {
            return _postresponsitory.GetMultiPaging(x=>x.Status && x.CategoryID == categoryId,out totalPage,page,pagesize, new string[] { "PostCategory"});
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pagesize, out int totalRow)
        {
            //TODO: select all by tag
            return _postresponsitory.GetAllByTag(tag, page, pagesize, out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            return _postresponsitory.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public Post GetById(int id)
        {
            return _postresponsitory.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitofwwork.Commit();
        }

        public void Update(Post post)
        {
            _postresponsitory.Update(post);
        }
    }
}
