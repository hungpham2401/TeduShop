using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public interface IRepositories<T> where T : class
    {

        void Add(T enity);

        void Update(T entity);
        void Delete(T entity);
        void DeleteMulti(Expression<Func<T, bool>> where);
        T GetSingeById(int id);
        T GetStringByCondition(Expression<Func<T, bool>> expression, string[] includes = null);
        IQueryable<T> GetAll(string[] includes = null);
        IQueryable<T> GetMuliti(Expression<Func<T, bool>> predicate, string[]  includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total,int  index = 0, int size = 50, string[] includes = null);
        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);

           
    }
}
