using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace play_360.Migrations
{
    /// <inheritdoc />
    public partial class SeedingMpiloAsUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "FirstName", "IdentityNumber", "IsPopiAccepting", "LastName", "Password", "ProfilePhoto", "ReferralCode", "UpdatedAt" },
                values: new object[] { 5, null, new DateTime(2025, 8, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), "ndlovumpilo@icloud.com", "Mpilo", "9003205674083", true, "Ndlovu", "12345", null, "DdEeFe", new DateTime(2025, 8, 1, 14, 30, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
