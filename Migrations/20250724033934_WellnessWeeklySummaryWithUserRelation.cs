using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class WellnessWeeklySummaryWithUserRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AchievementType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchievementType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreditType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DominantSide",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DominantSide", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeelingType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeelingType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProficiencyLevelType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProficiencyLevelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferralStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WellnessWeeklySummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WeekStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AverageFeeling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InjuryCount = table.Column<int>(type: "int", nullable: false),
                    SummaryNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WellnessWeeklySummary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WellnessWeeklySummary_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WellnessWeeklySummary_UserId",
                table: "WellnessWeeklySummary",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AchievementType");

            migrationBuilder.DropTable(
                name: "CreditType");

            migrationBuilder.DropTable(
                name: "DominantSide");

            migrationBuilder.DropTable(
                name: "FeelingType");

            migrationBuilder.DropTable(
                name: "MediaType");

            migrationBuilder.DropTable(
                name: "ProficiencyLevelType");

            migrationBuilder.DropTable(
                name: "QuestionType");

            migrationBuilder.DropTable(
                name: "ReferralStatus");

            migrationBuilder.DropTable(
                name: "WellnessWeeklySummary");
        }
    }
}
