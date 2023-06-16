using System.ComponentModel.DataAnnotations;

namespace QuizApi.Data.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
