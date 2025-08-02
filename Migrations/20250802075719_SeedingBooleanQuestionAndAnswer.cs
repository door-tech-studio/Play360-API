using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class SeedingBooleanQuestionAndAnswer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WellnessBooleanQuestion",
                columns: new[] { "Id", "AgeGroupId", "CreatedAt", "FrequencyTypeId", "IsActive", "QuestionCategoryId", "QuestionText" },
                values: new object[] { 1, 1, new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1, true, 1, "Do you have any injuries or pain?" });

            migrationBuilder.InsertData(
                table: "WellnessBooleanQuestionAnswer",
                columns: new[] { "Id", "AnswerText", "WellnessBooleanQuestionId" },
                values: new object[,]
                {
                    { 1, "True", 1 },
                    { 2, "False", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestionAnswer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestionAnswer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestion",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
