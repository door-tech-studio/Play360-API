using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class AfterOpenEndedQuestionAndResponse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "WellnessOpenEndedQuestionCheckinResponse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "WellnessOpenEndedQuestionCheckinResponse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WellnessCheckinId",
                table: "WellnessOpenEndedQuestionCheckinResponse",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "WellnessOpenEndedQuestionCheckinResponse");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "WellnessOpenEndedQuestionCheckinResponse");

            migrationBuilder.DropColumn(
                name: "WellnessCheckinId",
                table: "WellnessOpenEndedQuestionCheckinResponse");
        }
    }
}
