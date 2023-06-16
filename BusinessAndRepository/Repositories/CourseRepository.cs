using AutoMapper;
using QuizApi.Base.BaseRepository;
using QuizApi.Base.IBaseRepository;
using QuizApi.BusinessAndRepository.IRepositories;
using QuizApi.Data.DatabaseContext;

namespace QuizApi.BusinessAndRepository.Repositories
{
    public class CourseRepository<TModel> : BaseRepository<TModel>, ICourseRepository<TModel> where TModel : class
    {
        private readonly IMapper _mapper;
        private readonly DatabaseContext _database;
        public CourseRepository(DatabaseContext database, IMapper mapper) : base(database, mapper)
        {
            _database = database;
            _mapper = mapper;
        }
    }
}
