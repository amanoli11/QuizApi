using QuizApi.BusinessAndRepository.IBusiness;
using QuizApi.BusinessAndRepository.IRepositories;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;
using QuizApi.Helpers.Enums;

namespace QuizApi.BusinessAndRepository.Business
{
    public class QuestionBusiness : IQuestionBusiness
    {
        public readonly IQuestionRepository _question;
        public QuestionBusiness(IQuestionRepository question) {
            _question = question;
        }

        public async Task<IEnumerable<QuestionDto>> GetQuestionList(CourseOption course)
        {
            return await _question.GetQuestionList(course);
            //throw new NotImplementedException();
        }
    }
}
