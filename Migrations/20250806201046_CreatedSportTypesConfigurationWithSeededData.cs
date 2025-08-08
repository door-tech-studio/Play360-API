using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class CreatedSportTypesConfigurationWithSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SportTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SportTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Soccer" },
                    { 2, "Rugby" },
                    { 3, "Cricket" },
                    { 4, "Golf" },
                    { 5, "Netball" },
                    { 6, "Athletics" },
                    { 7, "Tennis" },
                    { 8, "Swimming" },
                    { 9, "Boxing" },
                    { 10, "Motorsport" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SportTypes");
        }
    }
}
