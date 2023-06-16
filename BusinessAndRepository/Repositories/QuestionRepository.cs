using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuizApi.BusinessAndRepository.IRepositories;
using QuizApi.Data.DatabaseContext;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;
using QuizApi.Helpers.Enums;

namespace QuizApi.BusinessAndRepository.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IMapper _mapper;
        private readonly DatabaseContext _database;
        public QuestionRepository(DatabaseContext database, IMapper mapper)
        {
            _database = database;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetQuestionDto>> GetQuestionList(CourseOption course)
        {
            var AllQuestions = await _database.Questions.ToListAsync();
            return _mapper.Map<IEnumerable<GetQuestionDto>>(AllQuestions);
        }
    }
}
