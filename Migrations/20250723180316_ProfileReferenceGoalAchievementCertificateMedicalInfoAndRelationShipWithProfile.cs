using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class ProfileReferenceGoalAchievementCertificateMedicalInfoAndRelationShipWithProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfileAchievement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AchievementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileAchievement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileAchievement_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileCertificate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    CertificationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Institution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileCertificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileCertificate_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileGoal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    Statement = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileGoal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileGoal_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileMedicalInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    MedicalNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InjuryHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalAidProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalAidNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileMedicalInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileMedicalInfo_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileReference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    ReferenceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileReference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileReference_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileSkill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    SkillName = table.Column<int>(type: "int", nullable: false),
                    ProficiencyLevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileSkill_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileAchievement_ProfileId",
                table: "ProfileAchievement",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileCertificate_ProfileId",
                table: "ProfileCertificate",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileGoal_ProfileId",
                table: "ProfileGoal",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileMedicalInfo_ProfileId",
                table: "ProfileMedicalInfo",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileReference_ProfileId",
                table: "ProfileReference",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSkill_ProfileId",
                table: "ProfileSkill",
                column: "ProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileAchievement");

            migrationBuilder.DropTable(
                name: "ProfileCertificate");

            migrationBuilder.DropTable(
                name: "ProfileGoal");

            migrationBuilder.DropTable(
                name: "ProfileMedicalInfo");

            migrationBuilder.DropTable(
                name: "ProfileReference");

            migrationBuilder.DropTable(
                name: "ProfileSkill");
        }
    }
}
