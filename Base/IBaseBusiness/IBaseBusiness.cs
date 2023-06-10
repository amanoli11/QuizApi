using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QuizApi.Base.IBaseBusiness
{
    public interface IBaseBusiness<T>
    {
        public Task<IEnumerable<T>> Get();
        public Task<T> Get(int id);
        public void Create(T entity);
        public Task<T> Update(int id, T entity);
    }
}