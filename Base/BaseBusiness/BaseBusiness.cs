using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApi.Base.IBaseBusiness;
using QuizApi.Base.IBaseRepository;
using QuizApi.Helpers.Dtos;

namespace QuizApi.Base.BaseBusiness
{
    public abstract class BaseBusiness<TModel, TCreateDto, TUpdateDto, TGetDto> 
        : IBaseBusiness<TModel, TCreateDto, TUpdateDto, TGetDto>
        where TModel : class
        where TCreateDto : class
        where TUpdateDto : class
        where TGetDto : class
    {
        public readonly IBaseRepository<TModel, TCreateDto, TUpdateDto, TGetDto> _baseRepository;
        public BaseBusiness(IBaseRepository<TModel, TCreateDto, TUpdateDto, TGetDto> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public virtual async Task<ResponseDto<string>> Create(TCreateDto entity)
        {
            return await _baseRepository.Create(entity);
        }

        public virtual async Task<ResponseDto<IEnumerable<TGetDto>>> Get()
        {
            return await _baseRepository.Get();
        }

        public virtual async Task<ResponseDto<TGetDto>> Get(int id)
        {
            return await _baseRepository.Get(id);
        }

        public virtual async Task<ResponseDto<string>> Update(int id, TUpdateDto entity)
        {
            return await _baseRepository.Update(id, entity);
        }
    }
}