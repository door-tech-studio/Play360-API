using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class MadeAchievementValueNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Users_UserId",
                table: "Achievements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Achievements",
                table: "Achievements");

            migrationBuilder.RenameTable(
                name: "Achievements",
                newName: "UserAchievement");

            migrationBuilder.RenameIndex(
                name: "IX_Achievements_UserId",
                table: "UserAchievement",
                newName: "IX_UserAchievement_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAchievement",
                table: "UserAchievement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievement_Users_UserId",
                table: "UserAchievement",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievement_Users_UserId",
                table: "UserAchievement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAchievement",
                table: "UserAchievement");

            migrationBuilder.RenameTable(
                name: "UserAchievement",
                newName: "Achievements");

            migrationBuilder.RenameIndex(
                name: "IX_UserAchievement_UserId",
                table: "Achievements",
                newName: "IX_Achievements_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Achievements",
                table: "Achievements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Users_UserId",
                table: "Achievements",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
