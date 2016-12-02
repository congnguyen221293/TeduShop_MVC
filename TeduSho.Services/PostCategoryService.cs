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
    public interface IPostCategoryService
    {
        void Add(PostCategory postcategory);
        void Update(PostCategory postcategory);
        void Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int parentId);
        PostCategory GetById(int id);
    }
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _postcategoryResponsitory;
        IUnitOfWord _unitOfWork;
        public PostCategoryService(IPostCategoryRepository postCategoryResponsitory, IUnitOfWord unitOfWork)
        {
            this._postcategoryResponsitory = postCategoryResponsitory;
            this._unitOfWork = unitOfWork;
        }
        public void Add(PostCategory postcategory)
        {
            _postcategoryResponsitory.Add(postcategory);
        }

        public void Delete(int id)
        {
            _postcategoryResponsitory.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postcategoryResponsitory.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
            return _postcategoryResponsitory.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public PostCategory GetById(int id)
        {
            _postcategoryResponsitory.GetSingleById(id);
        }

        public void Update(PostCategory postcategory)
        {
            _postcategoryResponsitory.Update(postcategory);
        }
    }
}
