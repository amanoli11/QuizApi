using QuizApi.Helpers.Enums;

namespace QuizApi.Helpers.Dtos
{
    public class BaseDto
    {
        public int Id { get; set; }
        public ActiveStatusOption IsActive { get; set; }
        public RecordStatusOption Status { get; set; }
    }

    public class BaseCreateDto
    {
        public ActiveStatusOption IsActive { get; set; }
        public RecordStatusOption Status { get; set; }
    }

    public class BaseUpdateDto
    {
        public ActiveStatusOption IsActive { get; set; }
        public RecordStatusOption Status { get; set; }
    }

    public class BaseGetDTO : BaseDto
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
