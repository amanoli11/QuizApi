using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QuizApi.BusinessAndRepository.Business;
using QuizApi.BusinessAndRepository.IBusiness;
using QuizApi.BusinessAndRepository.IRepositories;
using QuizApi.BusinessAndRepository.Repositories;
using QuizApi.CustomMiddlewares;
using QuizApi.Data.DatabaseContext;
using QuizApi.Data.Models;
using QuizApi.Helpers.Automapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("QuizApiDatabase")));
builder.Services.AddAutoMapper(typeof(AutomapperProfiles).Assembly);

builder.Services.AddScoped<IQuestionBusiness, QuestionBusiness>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();

builder.Services.AddScoped(typeof(ICourseBusiness<>), typeof(CourseBusiness<>));
builder.Services.AddScoped(typeof(ICourseRepository<>), typeof(CourseRepository<>));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<GlobalErrorHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
