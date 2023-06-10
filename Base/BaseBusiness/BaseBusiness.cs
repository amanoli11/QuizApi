using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApi.Base.IBaseBusiness;
using QuizApi.Base.IBaseRepository;

namespace QuizApi.Base.BaseBusiness
{
    public abstract class BaseBusiness<T> : IBaseBusiness<T>
    {
        public readonly IBaseRepository<T> _baseRepository;
        public BaseBusiness(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            return await _baseRepository.Get();
        }

        public virtual async Task<T> Get(int id)
        {
            return await _baseRepository.Get(id);
        }

        public virtual void Create(T entity)
        {
            _baseRepository.Create(entity);
        }

        public virtual async Task<T> Update(int id, T entity)
        {
            return await _baseRepository.Update(id, entity);
        }
    }
}