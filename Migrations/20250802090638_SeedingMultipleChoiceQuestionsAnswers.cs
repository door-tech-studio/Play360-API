using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class SeedingMultipleChoiceQuestionsAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WellnessMultipleChoiceQuestion",
                columns: new[] { "Id", "AgeGroupId", "CreatedAt", "FrequencyTypeId", "IsActive", "QuestionCategoryId", "QuestionText" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2025, 8, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 1, true, 1, "Do you feel muscle soreness?" },
                    { 3, 1, new DateTime(2025, 8, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 1, true, 1, "How did your week feel overall?" }
                });

            migrationBuilder.InsertData(
                table: "WellnessMultipleChoiceAnswer",
                columns: new[] { "Id", "AnswerText", "WellnessMultipleChoiceQuestionId" },
                values: new object[,]
                {
                    { 4, "Good", 2 },
                    { 5, "Okay", 2 },
                    { 6, "Bad", 2 },
                    { 7, "Good", 3 },
                    { 8, "Okay", 3 },
                    { 9, "Bad", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceAnswer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceAnswer",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceAnswer",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceAnswer",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceAnswer",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceAnswer",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceQuestion",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceQuestion",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
