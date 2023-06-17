using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuizApi.Base.IBaseRepository;
using QuizApi.Data.DatabaseContext;
using QuizApi.Exceptions;
using QuizApi.Helpers.Dtos;
using QuizApi.Helpers.Enums;

namespace QuizApi.Base.BaseRepository
{
    public abstract class BaseRepository<TModel, TCreateDto, TUpdateDto, TGetDto> 
        : IBaseRepository<TModel, TCreateDto, TUpdateDto, TGetDto>
        where TModel : class
        where TCreateDto : class
        where TUpdateDto : class
        where TGetDto : class
    {
        private readonly IMapper _mapper;
        private readonly DatabaseContext _database;
        private DbSet<TModel> table;
        
        public BaseRepository(DatabaseContext database, IMapper mapper)
        {
            _database = database;
            table = _database.Set<TModel>();
            _mapper = mapper; // IF NEED TO USE AUTOMAPPER WHEN ENHANCING THE BASE REPO.
        }

        public virtual async Task<ResponseDto<TModel>> Create(TModel entity)
        {
            await table.AddAsync(entity);
            await _database.SaveChangesAsync();
            return new ResponseDto<TModel>()
            {
                message = "Data saved successfully",
                data = null,
                responseStatusCode = ResponseStatusCodeOption.Success
            };
        }

        public virtual async Task<ResponseDto<IEnumerable<TModel>>> Get()
        {
            var AllData = await table.ToListAsync();
            if (AllData.Count == 0) throw new DataNotFoundException("No data found");
            return new ResponseDto<IEnumerable<TModel>>()
            {
                message = "Data fetched successfully",
                data = AllData,
                responseStatusCode = ResponseStatusCodeOption.Success
            };
        }

        public virtual async Task<ResponseDto<TModel>> Get(int Id)
        {
            var GetById = await table.FindAsync(Id);
            return new ResponseDto<TModel>()
            {
                message = "Data fetched successfully",
                data = GetById,
                responseStatusCode = ResponseStatusCodeOption.Success
            };
        }

        public virtual async Task<ResponseDto<TModel>> Update(TModel entity)
        {
            table.Attach(entity);
            _database.Entry(entity).State = EntityState.Modified;
            await _database.SaveChangesAsync();
            return new ResponseDto<TModel>()
            {
                message = "Data updated successully",
                data = null,
                responseStatusCode = ResponseStatusCodeOption.Success
            };
        }
    }
}