using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class AddChatAndGuides : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SentOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guide-cave");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guide-eco");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "071d6f64-4489-4b38-a670-a2226701b3a9", "AQAAAAIAAYagAAAAEOvrvoIeILjsgffsvS6xj18tuLwIjISIYNvhuh9uAPGzX4HKbDlvAUVeW4MCsGIaww==" });
        }
    }
}
