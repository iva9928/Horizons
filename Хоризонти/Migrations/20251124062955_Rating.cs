using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class Rating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Destinations_DestinationId",
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
                values: new object[] { "4658a04b-c086-437f-8670-3c379c030418", "AQAAAAIAAYagAAAAEGa1ad0VW9J8YjrCOH7pIccfyVELJX0rRXOpSXYEExpQiriOLXtCt3bre2Gg3Xuuew==", "92a7dc5f-8a23-4f0d-be2e-619f129811c4" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 29, 55, 313, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_DestinationId",
                table: "Ratings",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a503189-261a-484b-8586-b8a4b471e72d", "AQAAAAIAAYagAAAAEBoR0EBz6yapYPN359mbImEUPbhnuY0naAXdogzXTtikyDb+PM4c6LMnjmItfc+2sQ==", "41fa8817-02e6-4340-88c9-a445986cc2eb" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 23, 22, 58, 46, 599, DateTimeKind.Local).AddTicks(7891));
        }
    }
}
