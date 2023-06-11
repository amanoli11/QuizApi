using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizApi.Base.IBaseBusiness;
using QuizApi.Helpers.Dtos;

namespace QuizApi.Base.BaseController
{
    [Route("[controller]")]
    public abstract class BaseController<TModel> : Controller where TModel : class
    {
        protected readonly IBaseBusiness<TModel> _baseBusiness;
        public BaseController(IBaseBusiness<TModel> baseBusiness)
        {
            _baseBusiness = baseBusiness;
        }

        [HttpGet]
        public virtual async Task<ResponseDto<IEnumerable<TModel>>> Get()
        {
            return await _baseBusiness.Get();
        }

        [HttpGet("{id}")]
        public virtual async Task<ResponseDto<TModel>> Get(int id)
        {
            return await _baseBusiness.Get(id);
        }

        [HttpPost]
        public virtual Task<ResponseDto<TModel>> Create(TModel entity)
        {
            return _baseBusiness.Create(entity);
        }

        [HttpPost]
        public virtual async Task<ResponseDto<TModel>> Update(TModel entity)
        {
            return await _baseBusiness.Update(entity);
        }
    }
}


// public class ProductController : BaseApiController<Model>
// {
//     public ProductController(ProductBusiness business) : base(business)
//     {
//     }

//     // Implement any additional endpoints or actions specific to the Product entity
// }