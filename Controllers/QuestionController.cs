using Microsoft.AspNetCore.Mvc;

namespace QuizApi.Controllers
{
    public class QuestionController : Controller
    {
        public QuestionController()
        {

        }

        [HttpGet]
        public string GetQuestionList()
        {
            return "";
        }
    }
}
