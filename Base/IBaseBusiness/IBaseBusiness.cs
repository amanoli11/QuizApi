using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizApi.Helpers.Dtos;

namespace QuizApi.Base.IBaseBusiness
{
    public interface IBaseBusiness<T>
    {
        public Task<ResponseDto<IEnumerable<T>>> Get();
        public Task<ResponseDto<T>> Get(int id);
        public Task<ResponseDto<T>> Create(T entity);
        public Task<ResponseDto<T>> Update(T entity);
    }
}