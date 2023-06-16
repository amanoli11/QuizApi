namespace QuizApi.Data.Models
{
    public class Course : BaseModel
    {
        public string Name { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
