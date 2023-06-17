namespace QuizApi.Helpers.Dtos
{
    public class CreateCourseDto : BaseCreateDto, ICourseDto
    {
        public string Name { get; set; }
    }

    public class GetCourseDto : BaseGetDTO, ICourseDto
    {
        public string Name { get; set; }
    }

    public class UpdateCourseDto : BaseUpdateDto, ICourseDto
    {
        public string Name { get; set; }
    }

    public interface ICourseDto
    {
        public string Name { get; set; }
    }
}
