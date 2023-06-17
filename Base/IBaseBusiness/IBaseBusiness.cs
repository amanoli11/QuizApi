using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizApi.Helpers.Dtos;

namespace QuizApi.Base.IBaseBusiness
{
    public interface IBaseBusiness<TModel, TCreateDto, TUpdateDto, TGetDto>
    {
        public Task<ResponseDto<IEnumerable<TGetDto>>> Get();
        public Task<ResponseDto<TGetDto>> Get(int id);
        public Task<ResponseDto<string>> Create(TCreateDto entity);
        public Task<ResponseDto<string>> Update(int id, TUpdateDto entity);
    }
}