namespace QuizApi.Data.Models
{
    public class Subject : BaseCreateModel
    {
        public string Name { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}
