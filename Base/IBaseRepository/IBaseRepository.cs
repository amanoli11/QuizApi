using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApi.Base.IBaseRepository
{
    public interface IBaseRepository<T>
    {
        public Task<IEnumerable<T>> Get();
        public Task<T> Get(int id);
        public void Create(T entity);
        public Task<T> Update(int id, T entity);
    }
}