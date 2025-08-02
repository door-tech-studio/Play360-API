using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class SeedingBooleanQuestionsAndAnswersAndChangedAgeGroupDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "All");

            migrationBuilder.InsertData(
                table: "WellnessBooleanQuestion",
                columns: new[] { "Id", "AgeGroupId", "CreatedAt", "FrequencyTypeId", "IsActive", "QuestionCategoryId", "QuestionText" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1, true, 2, "Do you feel mentally exhausted?" },
                    { 3, 1, new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1, true, 2, "Did you practice mindfulness today?" },
                    { 4, 1, new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1, true, 2, "Any injuries or stress this week?" }
                });

            migrationBuilder.InsertData(
                table: "WellnessBooleanQuestionAnswer",
                columns: new[] { "Id", "AnswerText", "WellnessBooleanQuestionId" },
                values: new object[,]
                {
                    { 3, "True", 2 },
                    { 4, "False", 2 },
                    { 5, "True", 3 },
                    { 6, "False", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestion",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestionAnswer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestionAnswer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestionAnswer",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestionAnswer",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestion",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestion",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "General");
        }
    }
}
