using QuizApi.Base.IBaseBusiness;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;

namespace QuizApi.BusinessAndRepository.IBusiness
{
    public interface ICourseBusiness : IBaseBusiness<Course, CreateCourseDto, UpdateCourseDto, GetCourseDto>
    {
    }
}
