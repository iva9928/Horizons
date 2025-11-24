using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class RatingChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Ratings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b119032c-46a2-4323-8704-b7f489cb2bc3", "AQAAAAIAAYagAAAAENZ1VhZUxPmuhaW9oZ/1sJvbtXIR5yRTYdKP4a9a1uzzWDmDAq39dywIaTLEG38wjw==", "222da46f-277b-4985-9868-705afb16b562" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 8, 59, 15, 82, DateTimeKind.Local).AddTicks(8592));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

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
        }
    }
}
