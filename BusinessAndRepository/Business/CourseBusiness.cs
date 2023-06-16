using QuizApi.Base.BaseBusiness;
using QuizApi.BusinessAndRepository.IBusiness;
using QuizApi.BusinessAndRepository.IRepositories;

namespace QuizApi.BusinessAndRepository.Business
{
    public class CourseBusiness<TModel> : BaseBusiness<TModel>, ICourseBusiness<TModel> where TModel : class
    {
        private readonly ICourseRepository<TModel> _course;
        public CourseBusiness(ICourseRepository<TModel> course) : base(course)
        {
            _course = course;
        }
    }
}
