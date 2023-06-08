using System.ComponentModel.DataAnnotations;

namespace QuizApi.Data.Models
{
    public class User : BaseCreateModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime createdAt { get; set; }
    }
}
