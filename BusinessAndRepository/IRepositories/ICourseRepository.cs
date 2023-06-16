using QuizApi.Base.IBaseRepository;

namespace QuizApi.BusinessAndRepository.IRepositories
{
    public interface ICourseRepository<TModel> : IBaseRepository<TModel> where TModel : class
    {
    }
}
