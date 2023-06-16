namespace QuizApi.Data.Models
{
    public class Subject : BaseModel
    {
        public string Name { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}
