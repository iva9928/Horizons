using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class AddTours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guide-cave");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guide-eco");

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    GuideId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxPeople = table.Column<int>(type: "int", nullable: false),
                    PricePerPerson = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_AspNetUsers_GuideId",
                        column: x => x.GuideId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tours_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef6ecd5a-8a6b-4b3f-9e53-2f413da9cd99", "AQAAAAIAAYagAAAAELuWKgtrggULomHrwpP705/PpFAgTLPkfgydwW10z8K6dUQ2YzTTS2+77Jwjn2yt3A==" });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_DestinationId",
                table: "Tours",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_GuideId",
                table: "Tours",
                column: "GuideId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85459cf9-d2d6-4b32-8ea0-b0e001c787cf", "AQAAAAIAAYagAAAAEKXPe5TT3Y64djyQN9+EH8fxVXCd4F0WOyttrMPFHmNuHEkrqognwTmb8MqZS0jsEw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Bio", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsGuide", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "guide-cave", 0, 34, "Спелеолог с 12 години опит.", "bca7c034-c991-4e12-bcd5-50d3e0d8f6d7", "cave@horizons.com", true, true, false, null, "CAVE@HORIZONS.COM", "CAVE@HORIZONS.COM", "AQAAAAIAAYagAAAAEPeq0JkiJjkAEIJwSFxz/2fNuh0i6VVhcPboVUBfdvLENxe0YEzXmcWUCnF8Q6bbtg==", null, false, "/images/guides/cave.png", "ed0581ec-d337-4d84-83f0-8c6f9e19987c", false, "cave@horizons.com" },
                    { "guide-eco", 0, 29, "Еколог и водач на екопътеки.", "d639f02d-c7e1-4f4a-aa65-d21cdcc43d45", "eco@horizons.com", true, true, false, null, "ECO@HORIZONS.COM", "ECO@HORIZONS.COM", "AQAAAAIAAYagAAAAEAh26Z5bzSedBxc9LaGMLytkhvNT6F+ylvNrkhpZRZX7oy9PgYsfMGJT/pXEjLcMqw==", null, false, "/images/guides/eco.png", "8a0ffbcf-01c2-4403-9b80-7beb9d955047", false, "eco@horizons.com" }
                });
        }
    }
}
