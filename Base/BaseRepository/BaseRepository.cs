using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuizApi.Base.IBaseRepository;
using QuizApi.Data.DatabaseContext;

namespace QuizApi.Base.BaseRepository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IMapper _mapper;
        private readonly DatabaseContext _database;
        public BaseRepository(DatabaseContext database, IMapper mapper)
        {
            _database = database;
            _mapper = mapper; // IF NEED TO USE AUTOMAPPER WHEN ENHANCING THE BASE REPO.
        }

        public virtual void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            return await _database.Set<T>().ToListAsync();
        }

        public virtual async Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}