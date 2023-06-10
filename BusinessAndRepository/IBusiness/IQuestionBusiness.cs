﻿using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;
using QuizApi.Helpers.Enums;

namespace QuizApi.BusinessAndRepository.IBusiness
{
    public interface IQuestionBusiness
    {
        public Task<IEnumerable<QuestionDto>> GetQuestionList(CourseOption course);
    }
}
