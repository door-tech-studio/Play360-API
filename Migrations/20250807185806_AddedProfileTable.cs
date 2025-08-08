using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class AddedProfileTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Users_UserId",
                table: "Profile");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileAchievement_Profile_ProfileId",
                table: "ProfileAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileCertificate_Profile_ProfileId",
                table: "ProfileCertificate");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileEducation_Profile_ProfileId",
                table: "ProfileEducation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileGoal_Profile_ProfileId",
                table: "ProfileGoal");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileMedicalInfo_Profile_ProfileId",
                table: "ProfileMedicalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileReference_Profile_ProfileId",
                table: "ProfileReference");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileSkill_Profile_ProfileId",
                table: "ProfileSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileTeam_Profile_ProfileId",
                table: "ProfileTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.RenameTable(
                name: "Profile",
                newName: "Profiles");

            migrationBuilder.RenameIndex(
                name: "IX_Profile_UserId",
                table: "Profiles",
                newName: "IX_Profiles_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileAchievement_Profiles_ProfileId",
                table: "ProfileAchievement",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileCertificate_Profiles_ProfileId",
                table: "ProfileCertificate",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileEducation_Profiles_ProfileId",
                table: "ProfileEducation",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileGoal_Profiles_ProfileId",
                table: "ProfileGoal",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileMedicalInfo_Profiles_ProfileId",
                table: "ProfileMedicalInfo",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileReference_Profiles_ProfileId",
                table: "ProfileReference",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Users_UserId",
                table: "Profiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileSkill_Profiles_ProfileId",
                table: "ProfileSkill",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileTeam_Profiles_ProfileId",
                table: "ProfileTeam",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileAchievement_Profiles_ProfileId",
                table: "ProfileAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileCertificate_Profiles_ProfileId",
                table: "ProfileCertificate");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileEducation_Profiles_ProfileId",
                table: "ProfileEducation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileGoal_Profiles_ProfileId",
                table: "ProfileGoal");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileMedicalInfo_Profiles_ProfileId",
                table: "ProfileMedicalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileReference_Profiles_ProfileId",
                table: "ProfileReference");

            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Users_UserId",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileSkill_Profiles_ProfileId",
                table: "ProfileSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileTeam_Profiles_ProfileId",
                table: "ProfileTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "Profile");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_UserId",
                table: "Profile",
                newName: "IX_Profile_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Users_UserId",
                table: "Profile",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileAchievement_Profile_ProfileId",
                table: "ProfileAchievement",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileCertificate_Profile_ProfileId",
                table: "ProfileCertificate",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileEducation_Profile_ProfileId",
                table: "ProfileEducation",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileGoal_Profile_ProfileId",
                table: "ProfileGoal",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileMedicalInfo_Profile_ProfileId",
                table: "ProfileMedicalInfo",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileReference_Profile_ProfileId",
                table: "ProfileReference",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileSkill_Profile_ProfileId",
                table: "ProfileSkill",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileTeam_Profile_ProfileId",
                table: "ProfileTeam",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
