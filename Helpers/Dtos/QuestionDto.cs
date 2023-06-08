using QuizApi.Data.Models;
using QuizApi.Helpers.Enums;

namespace QuizApi.Helpers.Dtos
{
    public class QuestionDto : BaseDto
    {
        public string question { get; set; }
        public decimal marks { get; set; }
        public List<AnswerOptionsDto> options { get; set; }
        public AnswerTypeOption answerType { get; set; }
        public CorrectAnswerOption correctAnswer { get; set; }
    }
}
