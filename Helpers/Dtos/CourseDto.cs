namespace QuizApi.Helpers.Dtos
{
    public class CreateCourseDto : ICourseDto
    {
        public string Name { get; set; }
    }

    public class GetCourseDto : BaseDto, ICourseDto
    {
        public string Name { get; set; }
    }

    public class UpdateCourseDto : BaseDto, ICourseDto
    {
        public string Name { get; set; }
    }

    public interface ICourseDto
    {
        public string Name { get; set; }
    }
}
