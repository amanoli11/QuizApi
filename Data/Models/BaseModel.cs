using QuizApi.Helpers.Enums;
using System.ComponentModel.DataAnnotations;

namespace QuizApi.Data.Models
{
    public class BaseModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public ActiveStatusOption IsActive { get; set; }
        public RecordStatusOption Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
