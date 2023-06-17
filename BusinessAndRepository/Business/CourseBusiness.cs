using QuizApi.Base.BaseBusiness;
using QuizApi.BusinessAndRepository.IBusiness;
using QuizApi.BusinessAndRepository.IRepositories;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;

namespace QuizApi.BusinessAndRepository.Business
{
    public class CourseBusiness : BaseBusiness<Course, CreateCourseDto, UpdateCourseDto, GetCourseDto> ,ICourseBusiness
    {
        private readonly ICourseRepository _course;
        public CourseBusiness(ICourseRepository course) : base(course)
        {
            _course = course;
        }
    }
}
