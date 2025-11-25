using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class AddTicketPriceToDestination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<decimal>(
                name: "TicketPrice",
                table: "Destinations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f4609bb-610a-4d90-9010-04262980342d", "AQAAAAIAAYagAAAAEBf43BBMUJpu60dJUpYVwA3kyF1TzFBgoxjgf8ZS8QcYpN4qgskjbwZ8pMJEI+YXGg==", "25ce80f9-689d-42a1-9add-492ec0ec7bbb" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PublishedOn", "TicketPrice" },
                values: new object[] { new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketPrice",
                table: "Destinations");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Destinations",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Destinations",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39c54599-d04b-489b-8cc0-6ebbf776d51a", "AQAAAAIAAYagAAAAEOHJiB5p6EFWl900STF7AgUUpZhgS1DYlZtG284jvrJ8k/UiIYC8FyjHf+NMaTP/kg==", "c32ca084-ff61-4788-8c68-f20945ff0e32" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 22, 22, 24, 27, 523, DateTimeKind.Local).AddTicks(8669));
        }
    }
}
