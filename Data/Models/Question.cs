using QuizApi.Helpers.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace QuizApi.Data.Models
{
    public class Question : BaseCreateModel
    {
        public string question { get; set; }
        public decimal marks { get; set; }
        public ICollection<AnswerOptions> options { get; set; }
        public AnswerTypeOption answerType { get; set; }
        public CorrectAnswerOption correctAnswer { get; set; }
        public CourseOption course { get; set; }
    }
}
