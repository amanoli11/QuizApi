using System.ComponentModel.DataAnnotations;

namespace QuizApi.Data.Models
{
    public class AnswerOptions : BaseCreateModel
    {
        public string OptionLabel { get; set; }
        public bool IsCorrectAnswer { get; set; }
    }
}
