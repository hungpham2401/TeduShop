using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostService
    {
        void Add(Post Post);
        void Update(Post Post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(string tag, int page, int pageSize, out int TotalRow);
        IEnumerable<Post> GetAllByCategoryPaging(string tag, int page, int pageSize, out int TotalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllTagPaging(string tag, int page, int pageSize, out int TotalRow);
        void SaveChange();



    }
    public class PostService : IPostService
    {
        IPostRepository _postRepositories;
        IUnitOfWork _unitOfWork;
        public PostService (IPostRepository postRepository , IUnitOfWork unitOfWork)
        {
            this._postRepositories = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post Post)
        {
            _postRepositories.Add(Post);
        }

        public void Delete(int id)
        {
            _postRepositories.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepositories.GetAll(new string[] { "PostCatetory" });
        }

        public IEnumerable<Post> GetAllByCategoryPaging(string tag, int page, int pageSize, out int TotalRow)
        {
            return _postRepositories.GetMultiPaging(x => x.Status , out TotalRow, page, pageSize, new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllPaging(string tag, int page, int pageSize, out int TotalRow)
        {
            return _postRepositories.GetMultiPaging(x => x.Status, out TotalRow, page, pageSize);
            
        }

        public IEnumerable<Post> GetAllTagPaging(string tag, int page, int pageSize, out int TotalRow)
        {
            //ToDo select all post by tag
            return _postRepositories.GetMultiPaging(x => x.Status, out TotalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepositories.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post Post)
        {
            _postRepositories.Update(Post);
        }
    }
}