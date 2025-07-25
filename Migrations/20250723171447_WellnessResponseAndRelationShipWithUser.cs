using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class WellnessResponseAndRelationShipWithUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WellnessQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WellnessQuestion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WellnessResponse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    ResponseValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WellnessQuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WellnessResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WellnessResponse_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WellnessResponse_WellnessQuestion_WellnessQuestionId",
                        column: x => x.WellnessQuestionId,
                        principalTable: "WellnessQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WellnessResponse_UserId",
                table: "WellnessResponse",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WellnessResponse_WellnessQuestionId",
                table: "WellnessResponse",
                column: "WellnessQuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WellnessResponse");

            migrationBuilder.DropTable(
                name: "WellnessQuestion");
        }
    }
}
