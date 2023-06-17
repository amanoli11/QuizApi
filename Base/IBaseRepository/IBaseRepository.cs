using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApi.Helpers.Dtos;

namespace QuizApi.Base.IBaseRepository
{
    public interface IBaseRepository<TModel, TCreateDto, TUpdateDto, TGetDto>
    {
        public Task<ResponseDto<IEnumerable<TGetDto>>> Get();
        public Task<ResponseDto<TGetDto>> Get(int id);
        public Task<ResponseDto<string>> Create(TCreateDto entity);
        public Task<ResponseDto<string>> Update(int id, TUpdateDto entity);
    }
}