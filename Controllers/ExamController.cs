using Microsoft.AspNetCore.Mvc;
using QuizApi.BusinessAndRepository.IBusiness;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : Controller
    {
        private readonly IExamBusiness _exam;
        public ExamController(IExamBusiness exam)
        {
            _exam = exam;
        }

        [HttpGet]
        public void GetQuestionList()
        {
            _exam.AddExamDetails();
        }
    }
}
