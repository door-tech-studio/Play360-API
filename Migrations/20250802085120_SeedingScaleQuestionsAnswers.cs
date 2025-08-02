using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class SeedingScaleQuestionsAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WellnessScaleQuestion",
                columns: new[] { "Id", "AgeGroupId", "CreatedAt", "FrequencyTypeId", "IsActive", "QuestionCategoryId", "QuestionText" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1, true, 1, "How well did you sleep last night?" },
                    { 3, 1, new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1, true, 2, "How motivated do you feel today ?" },
                    { 4, 1, new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 1, true, 2, "How focused were you during training today?" }
                });

            migrationBuilder.InsertData(
                table: "WellnessScaleQuestionAnswer",
                columns: new[] { "Id", "AnswerText", "CreatedAt", "WellnessScaleQuestionId" },
                values: new object[,]
                {
                    { 11, "1", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "2", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "3", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "4", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "5", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "6", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "7", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "8", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "9", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "10", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "1", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "2", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "3", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "4", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "5", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "6", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "7", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "8", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "9", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "10", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "1", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "2", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "3", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "4", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "5", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "6", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "7", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "8", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "9", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "10", new DateTime(2025, 8, 2, 8, 58, 0, 0, DateTimeKind.Unspecified), 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestionAnswer",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestion",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestion",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WellnessScaleQuestion",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
