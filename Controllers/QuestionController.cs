using Microsoft.AspNetCore.Mvc;
using QuizApi.Base.BaseController;
using QuizApi.BusinessAndRepository.IBusiness;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;
using QuizApi.Helpers.Enums;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : BaseController<Question>
    {
        private readonly IQuestionBusiness<Question> _question;
        public QuestionController(IQuestionBusiness<Question> question) : base(question)
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
