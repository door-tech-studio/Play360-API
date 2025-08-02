using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class SeedingScaleQuestionAndAnswer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WellnessScaleQuestion",
                columns: new[] { "Id", "AgeGroupId", "CreatedAt", "FrequencyTypeId", "IsActive", "QuestionCategoryId", "QuestionText" },
                values: new object[] { 1, 1, new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1, true, 1, "How much energy do you have?" });

            migrationBuilder.InsertData(
                table: "WellnessScaleQuestionAnswer",
                columns: new[] { "Id", "AnswerText", "CreatedAt", "WellnessScaleQuestionId" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "2", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "3", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "4", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, "5", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "6", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, "7", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, "8", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, "9", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, "10", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestion",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
