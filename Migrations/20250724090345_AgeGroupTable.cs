using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class AgeGroupTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WellnessResponse_WellnessQuestion_UserId",
                table: "WellnessResponse");

            migrationBuilder.AddColumn<int>(
                name: "AgeGroupId",
                table: "WellnessQuestion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SportTypeId",
                table: "WellnessQuestion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AgeGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroup", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WellnessResponse_QuestionId",
                table: "WellnessResponse",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_WellnessResponse_WellnessQuestion_QuestionId",
                table: "WellnessResponse",
                column: "QuestionId",
                principalTable: "WellnessQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WellnessResponse_WellnessQuestion_QuestionId",
                table: "WellnessResponse");

            migrationBuilder.DropTable(
                name: "AgeGroup");

            migrationBuilder.DropIndex(
                name: "IX_WellnessResponse_QuestionId",
                table: "WellnessResponse");

            migrationBuilder.DropColumn(
                name: "AgeGroupId",
                table: "WellnessQuestion");

            migrationBuilder.DropColumn(
                name: "SportTypeId",
                table: "WellnessQuestion");

            migrationBuilder.AddForeignKey(
                name: "FK_WellnessResponse_WellnessQuestion_UserId",
                table: "WellnessResponse",
                column: "UserId",
                principalTable: "WellnessQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
