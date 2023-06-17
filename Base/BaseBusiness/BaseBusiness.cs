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

        public virtual async Task<ResponseDto<TModel>> Create(TModel entity)
        {
            return await _baseRepository.Create(entity);
        }

        public virtual async Task<ResponseDto<IEnumerable<TModel>>> Get()
        {
            return await _baseRepository.Get();
        }

        public virtual async Task<ResponseDto<TModel>> Get(int id)
        {
            return await _baseRepository.Get(id);
        }

        public virtual async Task<ResponseDto<TModel>> Update(TModel entity)
        {
            return await _baseRepository.Update(entity);
        }
    }
}