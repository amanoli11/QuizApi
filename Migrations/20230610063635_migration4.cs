using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApi.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "course",
                table: "Questions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Exams",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UserId",
                table: "Exams",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Users_UserId",
                table: "Exams",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Users_UserId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_UserId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "course",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Exams");
        }
    }
}
