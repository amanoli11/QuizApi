using QuizApi.Helpers.Enums;

namespace QuizApi.Data.Models
{
    public class Exam : BaseCreateModel
    {
        public string name {  get; set; }
        public List<ExamAnswers> examAnswers { get; set; }
    }

    public class ExamAnswers : BaseCreateModel
    {
        public int QuestionId { get; set; }
        public CorrectAnswerOption answerChosen { get; set; }
        public Boolean isAnswerCorrect { get; set; }

        public Question Question { get; set; }
    }
}
