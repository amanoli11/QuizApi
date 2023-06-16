using QuizApi.Data.Models;
using QuizApi.Helpers.Enums;

namespace QuizApi.Helpers.Dtos
{
    public class CreateQuestionDto
    {
        public string QuestionLabel { get; set; }
        public decimal Marks { get; set; }
        public IEnumerable<AnswerOptions> Options { get; set; }
        public AnswerTypeOption AnswerType { get; set; }
        public QuesetionAskedFrequencyOption AskedFrequency { get; set; }
        public QuestionDifficultyLevelOption QuestionType { get; set; }
        public int CourseId { get; set; }
    }

    public class UpdateQuestionDto : BaseDto
    {
        public string QuestionLabel { get; set; }
        public decimal Marks { get; set; }
        public IEnumerable<AnswerOptions> Options { get; set; }
        public AnswerTypeOption AnswerType { get; set; }
        public QuesetionAskedFrequencyOption AskedFrequency { get; set; }
        public QuestionDifficultyLevelOption QuestionType { get; set; }
        public int CourseId { get; set; }
    }

    public class GetQuestionDto : BaseGetDTO {
        public string QuestionLabel { get; set; }
        public decimal Marks { get; set; }
        public IEnumerable<AnswerOptions> Options { get; set; }
        public AnswerTypeOption AnswerType { get; set; }
        public QuesetionAskedFrequencyOption AskedFrequency { get; set; }
        public QuestionDifficultyLevelOption QuestionType { get; set; }
        public int CourseId { get; set; }
    }
}
