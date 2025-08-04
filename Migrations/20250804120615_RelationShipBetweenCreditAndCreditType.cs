using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class RelationShipBetweenCreditAndCreditType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Credits_CreditTypeId",
                table: "Credits",
                column: "CreditTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Credits_CreditType_CreditTypeId",
                table: "Credits",
                column: "CreditTypeId",
                principalTable: "CreditType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Credits_CreditType_CreditTypeId",
                table: "Credits");

            migrationBuilder.DropIndex(
                name: "IX_Credits_CreditTypeId",
                table: "Credits");
        }
    }
}
