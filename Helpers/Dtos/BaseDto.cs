namespace QuizApi.Helpers.Dtos
{
    public class BaseDto
    {
        public int Id { get; set; }
    }

    public class BaseGetDTO : BaseDto
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
