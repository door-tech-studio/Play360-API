using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class SeededMultipleChoiceQuestionAndPossibleAnswer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WellnessMultipleChoiceQuestion",
                columns: new[] { "Id", "AgeGroupId", "CreatedAt", "FrequencyTypeId", "IsActive", "QuestionCategoryId", "QuestionText" },
                values: new object[] { 1, 1, new DateTime(2025, 8, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 1, true, 1, "How do you feel today?" });

            migrationBuilder.InsertData(
                table: "WellnessMultipleChoiceAnswer",
                columns: new[] { "Id", "AnswerText", "WellnessMultipleChoiceQuestionId" },
                values: new object[,]
                {
                    { 1, "Good", 1 },
                    { 2, "Okay", 1 },
                    { 3, "Bad", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceAnswer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceAnswer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceAnswer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WellnessMultipleChoiceQuestion",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
