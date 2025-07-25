using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationshipBetweenTransactionAndCredit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreditId",
                table: "Transaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CreditId",
                table: "Transaction",
                column: "CreditId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Credits_CreditId",
                table: "Transaction",
                column: "CreditId",
                principalTable: "Credits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Credits_CreditId",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CreditId",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "CreditId",
                table: "Transaction");
        }
    }
}
