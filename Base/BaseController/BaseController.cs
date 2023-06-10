using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizApi.Base.IBaseBusiness;

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
        public virtual async Task<IEnumerable<TModel>> Get()
        {
            return await _baseBusiness.Get();
        }

        [HttpGet("{id}")]
        public virtual async Task<TModel> Get(int id)
        {
            return await _baseBusiness.Get(id);
        }

        [HttpPost]
        public virtual void Create(TModel entity)
        {
            _baseBusiness.Create(entity);
        }

        [HttpPut("{id}")]
        public virtual async Task<TModel> Update(int id, TModel entity)
        {
            return await _baseBusiness.Update(id, entity);
        }
    }
}