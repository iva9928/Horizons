using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMessagesStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40a4ce05-507f-4e50-a842-04080c3c8a6e", "AQAAAAIAAYagAAAAEE9DsZnW2IhJREe0nWEpXh5GtixOot7dfZ5b5EV8WV7tR0sgRPk0/iuISPrtjIRrKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c9dc5d2-230b-4a35-bd3b-1db753073836", "AQAAAAIAAYagAAAAELCm0ConLT5roa9ZJfgL1oDj8Ho3XpUlKsrtc3iVCCUj8v0h0tMt6hXVS7AP3ZMgDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d477bdc4-7b23-468b-90d9-2213db11a3ef", "AQAAAAIAAYagAAAAEMn4n+/mFd3E4UyW0aBh50805zqS7jbtfWz3V6YwpO+ST05zhAuuuuT3gBHPgmRPjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44f8fe01-3e83-4875-bb90-6c10a7acaf2b", "AQAAAAIAAYagAAAAEK5s9yfpyKXyJChEqVqqEfjhHTbLdsVCgSszSepCuaWdyw/mHfVSZlZqptWmth0OKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "bf5ccfcb-4435-4a10-a882-dfdac8d6aac6", "AQAAAAIAAYagAAAAEMBqoICyfiEkPv5wEGrH5udjo8NoDhV3nZzeuA+ME6ar/2eFJV2Sr2z5bKJch9CDNw==", "/images/parkoveM.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63e1220a-9b41-4676-b6aa-c8677f464746", "AQAAAAIAAYagAAAAEDHu4N/h1BK1XgoF0i+vWNwFr1/YnaZzdBqf7X62YSTeQ7rO1lq700jZJ3yTUNv15A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57f63071-d529-4561-9793-655b5d1672f2", "AQAAAAIAAYagAAAAEKlfEiECzXg4wdsZSQEFhlYAxJrG0uQ1Ya6vSp5/G/iXB6JyUYIzpVRoE5g6E48nhw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "197c1182-f55f-472c-a21c-9ecb643f3c36", "AQAAAAIAAYagAAAAEO9nZkxysYqPAPkcOIZnOa74N09a/SxjFDpZlvbJ7KuOm+JOsyvpeWRfQ5lfwfwjHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5dbd4465-97f9-43ad-9de2-41ebc3477911", "AQAAAAIAAYagAAAAED/uLyCS/HmnWyOln1oojM02EMWEjkNQN25fVoWmyv/01oM4vXS5sWWwC2f8C/V1+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "859e0c9e-0a28-4172-b126-eb3b7d218b36", "AQAAAAIAAYagAAAAEPiRXZqtLxm2f63ZO3MgoNr4DpKJaXRggOT+RO/glbL25isdi4OpvucgqPxkmz7+Ng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "6f2e7382-723c-4002-8233-0abbbef0497d", "AQAAAAIAAYagAAAAEIaXHlPNWPbMuWM0bs1xSykiQof5DvB4JWgmRljzPbZls8HabqVTPBbP1ejthN0nRA==", "/images/planinaM.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c174177-4f16-4b4b-8ba8-5d3975459850", "AQAAAAIAAYagAAAAENRg1VmHGWm7gp5QYw5RjzkMlup//AIHXrFwEOK2fqiLWwWGcElGLyEUZN0eLZkzVQ==" });
        }
    }
}
