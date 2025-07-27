using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class WellnessMultipleChoiceQuestionAndAnswersRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WellnessMultipleChoiceQuestion",
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
                    table.PrimaryKey("PK_WellnessMultipleChoiceQuestion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WellnessMultipleChoiceAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WellnessMultipleChoiceQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WellnessMultipleChoiceAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WellnessMultipleChoiceAnswer_WellnessMultipleChoiceQuestion_WellnessMultipleChoiceQuestionId",
                        column: x => x.WellnessMultipleChoiceQuestionId,
                        principalTable: "WellnessMultipleChoiceQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WellnessMultipleChoiceAnswer_WellnessMultipleChoiceQuestionId",
                table: "WellnessMultipleChoiceAnswer",
                column: "WellnessMultipleChoiceQuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WellnessMultipleChoiceAnswer");

            migrationBuilder.DropTable(
                name: "WellnessMultipleChoiceQuestion");
        }
    }
}
