using System.ComponentModel.DataAnnotations;

namespace QuizApi.Data.Models
{
    public class BaseCreateModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
