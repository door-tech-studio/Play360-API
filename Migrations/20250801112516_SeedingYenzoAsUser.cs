using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class SeedingYenzoAsUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReferralCode",
                value: "AaBbCc");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "FirstName", "IdentityNumber", "IsPopiAccepting", "LastName", "Password", "ProfilePhoto", "ReferralCode", "UpdatedAt" },
                values: new object[] { 3, null, new DateTime(2025, 8, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), "yenzom@icloud.com", "Yenzo", "9003205674083", true, "Mdladla", "12345", null, "BbCcDd", new DateTime(2025, 8, 1, 14, 30, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReferralCode",
                value: "AaBbCc            ");
        }
    }
}
