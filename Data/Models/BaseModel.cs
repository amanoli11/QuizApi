using System.ComponentModel.DataAnnotations;

namespace QuizApi.Data.Models
{
    public class BaseModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
