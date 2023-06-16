using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace QuizApi.Migrations
{
    /// <inheritdoc />
    public partial class migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamAnswers");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropColumn(
                name: "optionA",
                table: "AnswerOptions");

            migrationBuilder.DropColumn(
                name: "optionB",
                table: "AnswerOptions");

            migrationBuilder.DropColumn(
                name: "optionC",
                table: "AnswerOptions");

            migrationBuilder.RenameColumn(
                name: "marks",
                table: "Questions",
                newName: "Marks");

            migrationBuilder.RenameColumn(
                name: "answerType",
                table: "Questions",
                newName: "AnswerType");

            migrationBuilder.RenameColumn(
                name: "question",
                table: "Questions",
                newName: "QuestionLabel");

            migrationBuilder.RenameColumn(
                name: "course",
                table: "Questions",
                newName: "QuestionType");

            migrationBuilder.RenameColumn(
                name: "correctAnswer",
                table: "Questions",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "optionD",
                table: "AnswerOptions",
                newName: "OptionLabel");

            migrationBuilder.AddColumn<int>(
                name: "AskedFrequency",
                table: "Questions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrectAnswer",
                table: "AnswerOptions",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CourseId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SubjectId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topic_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CourseId",
                table: "Questions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_CourseId",
                table: "Subject",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_SubjectId",
                table: "Topic",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Course_CourseId",
                table: "Questions",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Course_CourseId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Topic");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CourseId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AskedFrequency",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsCorrectAnswer",
                table: "AnswerOptions");

            migrationBuilder.RenameColumn(
                name: "Marks",
                table: "Questions",
                newName: "marks");

            migrationBuilder.RenameColumn(
                name: "AnswerType",
                table: "Questions",
                newName: "answerType");

            migrationBuilder.RenameColumn(
                name: "QuestionType",
                table: "Questions",
                newName: "course");

            migrationBuilder.RenameColumn(
                name: "QuestionLabel",
                table: "Questions",
                newName: "question");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Questions",
                newName: "correctAnswer");

            migrationBuilder.RenameColumn(
                name: "OptionLabel",
                table: "AnswerOptions",
                newName: "optionD");

            migrationBuilder.AddColumn<string>(
                name: "optionA",
                table: "AnswerOptions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionB",
                table: "AnswerOptions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "optionC",
                table: "AnswerOptions",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    ExamId = table.Column<int>(type: "integer", nullable: true),
                    answerChosen = table.Column<int>(type: "integer", nullable: false),
                    isAnswerCorrect = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamAnswers_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamAnswers_ExamId",
                table: "ExamAnswers",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAnswers_QuestionId",
                table: "ExamAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UserId",
                table: "Exams",
                column: "UserId");
        }
    }
}
