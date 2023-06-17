using AutoMapper;
using QuizApi.Base.BaseRepository;
using QuizApi.Base.IBaseRepository;
using QuizApi.BusinessAndRepository.IRepositories;
using QuizApi.Data.DatabaseContext;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;

namespace QuizApi.BusinessAndRepository.Repositories
{
    public class CourseRepository : BaseRepository<Course, CreateCourseDto, UpdateCourseDto, GetCourseDto>, ICourseRepository
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
