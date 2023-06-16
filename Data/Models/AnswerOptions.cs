using System.ComponentModel.DataAnnotations;

namespace QuizApi.Data.Models
{
    public class AnswerOptions : BaseModel
    {
        public string OptionLabel { get; set; }
        public bool IsCorrectAnswer { get; set; }
    }
}
