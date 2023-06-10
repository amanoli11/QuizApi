using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;
using QuizApi.Helpers.Enums;

namespace QuizApi.BusinessAndRepository.IRepositories
{
    public interface IQuestionRepository
    {
        public Task<IEnumerable<QuestionDto>> GetQuestionList(CourseOption course);
    }
}
