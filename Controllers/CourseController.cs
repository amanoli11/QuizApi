using Microsoft.AspNetCore.Mvc;
using QuizApi.Base.BaseController;
using QuizApi.BusinessAndRepository.IBusiness;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : BaseController<Course, CreateCourseDto, UpdateCourseDto, GetCourseDto>
    {
        private readonly ICourseBusiness _course;
        public CourseController(ICourseBusiness course) : base(course)
        {
            _course = course;
        }
    }
}
