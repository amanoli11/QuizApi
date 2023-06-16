using Microsoft.AspNetCore.Mvc;
using QuizApi.Base.BaseController;
using QuizApi.BusinessAndRepository.IBusiness;
using QuizApi.Data.Models;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : BaseController<Course>, ICourseBusiness<Course>
    {
        private readonly ICourseBusiness<Course> _course;
        public CourseController(ICourseBusiness<Course> course) : base(course)
        {
            _course = course;
        }
    }
}
