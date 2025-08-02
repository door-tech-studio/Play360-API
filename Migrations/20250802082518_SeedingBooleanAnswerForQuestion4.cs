using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class SeedingBooleanAnswerForQuestion4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WellnessBooleanQuestionAnswer",
                columns: new[] { "Id", "AnswerText", "WellnessBooleanQuestionId" },
                values: new object[,]
                {
                    { 7, "True", 4 },
                    { 8, "False", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestionAnswer",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WellnessBooleanQuestionAnswer",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
