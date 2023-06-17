using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuizApi.Base.IBaseRepository;
using QuizApi.Data.DatabaseContext;
using QuizApi.Data.Models;
using QuizApi.Exceptions;
using QuizApi.Helpers.Dtos;
using QuizApi.Helpers.Enums;

namespace QuizApi.Base.BaseRepository
{
    public abstract class BaseRepository<TModel, TCreateDto, TUpdateDto, TGetDto> 
        : IBaseRepository<TModel, TCreateDto, TUpdateDto, TGetDto>
        where TModel : BaseModel
        where TCreateDto : BaseCreateDto
        where TUpdateDto : BaseUpdateDto
        where TGetDto : BaseGetDTO
    {
        private readonly DatabaseContext _database;
        private DbSet<TModel> table;
        
        protected BaseRepository(DatabaseContext database, IMapper mapper)
        {
            _database = database;
            table = _database.Set<TModel>();
        }

        public virtual async Task<ResponseDto<string>> Create(TCreateDto entity)
        {
            var saveData = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TCreateDto, TModel>();
            });
            var mapper = saveData.CreateMapper();
            await table.AddAsync(mapper.Map<TModel>(entity));
            await _database.SaveChangesAsync();
            return new ResponseDto<string>()
            {
                message = "Data saved successfully",
                data = null,
                responseStatusCode = ResponseStatusCodeOption.Success
            };
        }

        public virtual async Task<ResponseDto<IEnumerable<TGetDto>>> Get()
        {
            var AllData = await table.ToListAsync();
            if (AllData.Count == 0) throw new DataNotFoundException("No data found");

            var getData = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TModel, TGetDto>();
            });
            var mapper = getData.CreateMapper();

            return new ResponseDto<IEnumerable<TGetDto>>()
            {
                message = "Data fetched successfully",
                data = mapper.Map<IEnumerable<TGetDto>>(AllData),
                responseStatusCode = ResponseStatusCodeOption.Success
            };
        }

        public virtual async Task<ResponseDto<TGetDto>> Get(int Id)
        {
            var GetById = await table.FindAsync(Id);
            var GetData = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TModel, TGetDto>();
            });

            var mapper = GetData.CreateMapper();

            return new ResponseDto<TGetDto>()
            {
                message = "Data fetched successfully",
                data = mapper.Map<TGetDto>(GetById),
                responseStatusCode = ResponseStatusCodeOption.Success
            };
        }

        public virtual async Task<ResponseDto<string>> Update(int id, TUpdateDto entity)
        {
            var row = await table.FindAsync(id);
            await _database.SaveChangesAsync();
            if (row == null)
            {
                throw new DataNotFoundException("Row does not exists");
            }

            var UpdateMapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TUpdateDto, TModel>();
            });

            var UpdateData = UpdateMapper.CreateMapper().Map<TModel>(entity);
            UpdateData.Id = row.Id;
            UpdateData.CreatedAt = row.CreatedAt; //row.CreatedAt;
            UpdateData.UpdatedAt = DateTime.Now.ToUniversalTime();

            try
            {
                table.Update(UpdateData);
                await _database.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return new ResponseDto<string>()
            {
                message = "Data updated successully",
                data = null,
                responseStatusCode = ResponseStatusCodeOption.Success
            };
        }
    }
}