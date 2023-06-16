using QuizApi.Base.IBaseBusiness;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;
using QuizApi.Helpers.Enums;

namespace QuizApi.BusinessAndRepository.IBusiness
{
    public interface IQuestionBusiness //<T> : IBaseBusiness<T> where T : class
    {
        public Task<IEnumerable<GetQuestionDto>> GetQuestionList(CourseOption course);
    }
}
