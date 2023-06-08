using System.ComponentModel.DataAnnotations;

namespace QuizApi.Data.Models
{
    public class AnswerOptions : BaseCreateModel
    {
        public string optionA { get; set; }
        public string optionB { get; set; }
        public string optionC { get; set; }
        public string optionD { get; set; }
    }
}
