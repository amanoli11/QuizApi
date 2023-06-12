using QuizApi.Helpers.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace QuizApi.Data.Models
{
    public class Question : BaseCreateModel
    {
        public string QuestionLabel { get; set; }
        public decimal Marks { get; set; }
        public ICollection<AnswerOptions> Options { get; set; }
        public AnswerTypeOption AnswerType { get; set; }
        public QuesetionAskedFrequencyOption AskedFrequency { get; set; }
        public QuestionTypeOption QuestionType { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
