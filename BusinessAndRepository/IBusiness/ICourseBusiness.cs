using QuizApi.Base.IBaseBusiness;

namespace QuizApi.BusinessAndRepository.IBusiness
{
    public interface ICourseBusiness<TModel> : IBaseBusiness<TModel> where TModel : class
    {
    }
}
