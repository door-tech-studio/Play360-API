using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class AddedOpenEndedQuestionAndResponseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WellnessOpenEndedQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeGroupId = table.Column<int>(type: "int", nullable: false),
                    FrequencyTypeId = table.Column<int>(type: "int", nullable: false),
                    QuestionCategoryId = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WellnessOpenEndedQuestion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WellnessOpenEndedQuestionCheckinResponse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WellnessOpenEndedQuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WellnessOpenEndedQuestionCheckinResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WellnessOpenEndedQuestionCheckinResponse_WellnessOpenEndedQuestion_WellnessOpenEndedQuestionId",
                        column: x => x.WellnessOpenEndedQuestionId,
                        principalTable: "WellnessOpenEndedQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "WellnessOpenEndedQuestion",
                columns: new[] { "Id", "AgeGroupId", "CreatedAt", "FrequencyTypeId", "IsActive", "QuestionCategoryId", "QuestionText" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 1, true, 2, "Any mental challenges or stresses today?" },
                    { 2, 1, new DateTime(2025, 8, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 1, true, 1, "What was your biggest challenge this week?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WellnessOpenEndedQuestionCheckinResponse_WellnessOpenEndedQuestionId",
                table: "WellnessOpenEndedQuestionCheckinResponse",
                column: "WellnessOpenEndedQuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WellnessOpenEndedQuestionCheckinResponse");

            migrationBuilder.DropTable(
                name: "WellnessOpenEndedQuestion");
        }
    }
}
