using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using QuizApi.Data.Models;
using QuizApi.Helpers.Dtos;

namespace QuizApi.Helpers.Automapper
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Question, QuestionDto>();
        }
    }
}