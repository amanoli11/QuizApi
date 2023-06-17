using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApi.Helpers.Dtos;

namespace QuizApi.Base.IBaseRepository
{
    public interface IBaseRepository<TModel, TCreateDto, TUpdateDto, TGetDto>
    {
        public Task<ResponseDto<IEnumerable<TModel>>> Get();
        public Task<ResponseDto<TModel>> Get(int id);
        public Task<ResponseDto<TModel>> Create(TModel entity);
        public Task<ResponseDto<TModel>> Update(TModel entity);
    }
}