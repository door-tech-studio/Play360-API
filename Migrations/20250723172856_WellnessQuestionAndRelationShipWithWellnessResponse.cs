using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class WellnessQuestionAndRelationShipWithWellnessResponse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WellnessResponse_WellnessQuestion_WellnessQuestionId",
                table: "WellnessResponse");

            migrationBuilder.DropIndex(
                name: "IX_WellnessResponse_WellnessQuestionId",
                table: "WellnessResponse");

            migrationBuilder.DropColumn(
                name: "WellnessQuestionId",
                table: "WellnessResponse");

            migrationBuilder.AddColumn<int>(
                name: "WellnessResponseId",
                table: "WellnessQuestion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_WellnessResponse_WellnessQuestion_UserId",
                table: "WellnessResponse",
                column: "UserId",
                principalTable: "WellnessQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WellnessResponse_WellnessQuestion_UserId",
                table: "WellnessResponse");

            migrationBuilder.DropColumn(
                name: "WellnessResponseId",
                table: "WellnessQuestion");

            migrationBuilder.AddColumn<int>(
                name: "WellnessQuestionId",
                table: "WellnessResponse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WellnessResponse_WellnessQuestionId",
                table: "WellnessResponse",
                column: "WellnessQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_WellnessResponse_WellnessQuestion_WellnessQuestionId",
                table: "WellnessResponse",
                column: "WellnessQuestionId",
                principalTable: "WellnessQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
