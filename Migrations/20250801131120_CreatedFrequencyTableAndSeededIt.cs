using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class CreatedFrequencyTableAndSeededIt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WellnessQuestionFrequencyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WellnessQuestionFrequencyType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WellnessQuestionFrequencyType",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Daily" },
                    { 2, "Weekly" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WellnessQuestionFrequencyType");
        }
    }
}
