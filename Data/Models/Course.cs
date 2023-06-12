namespace QuizApi.Data.Models
{
    public class Course : BaseCreateModel
    {
        public string Name { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
