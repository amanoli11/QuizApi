using Microsoft.AspNetCore.Mvc;
using QuizApi.BusinessAndRepository.IBusiness;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;
using QuizApi.Helpers.Enums;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : Controller
    {
        private readonly IQuestionBusiness _question;
        public QuestionController(IQuestionBusiness question)
        {
            _question = question;
        }

        [HttpGet]
        public async Task<IEnumerable<QuestionDto>> GetQuestionList(CourseOption course)
        {
            return await _question.GetQuestionList(course);
        }
    }
}
