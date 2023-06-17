using QuizApi.Base.IBaseRepository;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;

namespace QuizApi.BusinessAndRepository.IRepositories
{
    public interface ICourseRepository : IBaseRepository<Course, CreateCourseDto, UpdateCourseDto, GetCourseDto>
    {
    }
}
