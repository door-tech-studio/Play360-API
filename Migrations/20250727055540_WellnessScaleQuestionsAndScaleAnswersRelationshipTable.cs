using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class WellnessScaleQuestionsAndScaleAnswersRelationshipTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuestionText",
                table: "WellnessMultipleChoiceAnswer",
                newName: "AnswerText");

            migrationBuilder.CreateTable(
                name: "WellnessScaleQuestion",
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
                    table.PrimaryKey("PK_WellnessScaleQuestion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WellnessScaleQuestionAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WellnessScaleQuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WellnessScaleQuestionAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WellnessScaleQuestionAnswer_WellnessScaleQuestion_WellnessScaleQuestionId",
                        column: x => x.WellnessScaleQuestionId,
                        principalTable: "WellnessScaleQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WellnessScaleQuestionAnswer_WellnessScaleQuestionId",
                table: "WellnessScaleQuestionAnswer",
                column: "WellnessScaleQuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WellnessScaleQuestionAnswer");

            migrationBuilder.DropTable(
                name: "WellnessScaleQuestion");

            migrationBuilder.RenameColumn(
                name: "AnswerText",
                table: "WellnessMultipleChoiceAnswer",
                newName: "QuestionText");
        }
    }
}
