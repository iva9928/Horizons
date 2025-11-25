using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class Chnages4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LocationUrl",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd957211-a53c-41f6-a197-4aa520088ffe", "AQAAAAIAAYagAAAAEKVWLVhDC+psjXitDHds3C9k1c7yKO5J9EqyNq7RKB72IXkRDjMq1gcZYK+Hnceknw==", "2c38663e-7384-4265-aacf-3a201ea8470b" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Ягодинската пещера е разположена в Родопите, само на 3 км от село Ягодина.", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "бласт Смолян, Западни Родопи, на по-малко от 2км от Триград, на 25км от Девин и на 34км от Доспат", "ДГ.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "У.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ТЖ.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "БЖ.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "КВ.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЧМ.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "е намира на 5 км източно от центъра на град Кърджали, край село Зимзелен. Разположен е в Източни родопи", "ВС.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Орфееви скали се намира в сърцето на Родопите, недалеч от курортен комплекс Пампорово. Разположени са под самия връх, на няколко стотин метра разстояние", "ОС.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Екопътека “Невястата” се намира в сърцето на Родопи, точно по средата на пътя между Смолян и Пампорово. Разположена е на 8.7 км от Смолян и на 8.9 кмот Пампорово.", "Н.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "ЯП.png", new DateTime(2025, 11, 24, 12, 41, 17, 980, DateTimeKind.Local).AddTicks(1957) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "LocationUrl",
                table: "Destinations");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ab3558e-8897-4da8-93a1-dc97a1a3fe56", "AQAAAAIAAYagAAAAECAI87KMCuvbuOTYp0XG83a8yvTAQqCsecDcGVAOs2hREC4TR4dZ9fWGpEFP35N7/g==", "4af68d62-a9ec-4a9a-b49a-9cb763ba5d60" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 9, 19, 34, 449, DateTimeKind.Local).AddTicks(6473));
        }
    }
}
