using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class C1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DestinationImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DestinationImages_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7aeeb9e-3875-4011-bf38-a3e6e655511d", "AQAAAAIAAYagAAAAEFdTNszfwqIJ90T7wIfzCnQvm1MyO8Qnhwfn1//Mh+m/JCl0Sn8jCTMMdU/iHdI3TQ==", "4b405b97-dd27-4142-9704-90f749e08864" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 59, 27, 625, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.CreateIndex(
                name: "IX_DestinationImages_DestinationId",
                table: "DestinationImages",
                column: "DestinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DestinationImages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85910fbe-c14d-45e2-ba89-14e5cfc2c520", "AQAAAAIAAYagAAAAEFRqZ8Eqnthawd4MBRyNMYhnpnQoKhXM1tz/X6jsvB0bhOueUHEXQHCiu/QVzJQm+A==", "d24fa7a5-b790-4790-93b7-04b9f993804f" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 20, 10, 22, 360, DateTimeKind.Local).AddTicks(6913));
        }
    }
}
