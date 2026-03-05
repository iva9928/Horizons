using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class EditedChat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReceiverId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01601e63-32f9-48e8-b05b-633de4633306", "AQAAAAIAAYagAAAAEJIc7hVIHfgUZVKvSAIIYo9YcYvIrwGTYUvcgxMQqYrFR5RJgh4jZnr9/+hIQ+kWYw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6463ba2f-06c4-4e9d-8905-c4fcdac45e3f", "AQAAAAIAAYagAAAAELR2oAI42YOK2Ho8ox3fJd99Qvmmpt8NbspDsTnsfAqEKY9Ov1o2uvSEYQT51eXVBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea567c0f-ee8c-4191-b990-a69da952d58a", "AQAAAAIAAYagAAAAEIb5js6LhKznGFljcNmKOfq3v7HKzR9KeXDsV0q+YGRZOZueC9gAAgqkA5NHLi86Ng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "232b103a-f032-466e-b94d-1dd3270d6a2a", "AQAAAAIAAYagAAAAEMVSo+YtaFoU6YrWm1y9V1gJAsPveMBalZM4Gs5Ffj57a7WpEZqHrSPH9VlnkalrFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "355d7463-438c-4e6b-b019-54e90dcb636a", "AQAAAAIAAYagAAAAEF1jyN2gSBfI/VeMUK0swZCouyPp4hrZ7YFVvDLV+WfXwrqFDE+zfTUNRSzgcPh96w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c48388df-5c67-4a6f-b900-e689ba549e8e", "AQAAAAIAAYagAAAAECNExbAGuG9d7FTzQtpiiX7eELNAJY6lsF7FR+gOXJtaNanyaM/S5hhuooQX2bl1FA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReceiverId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf5ccfcb-4435-4a10-a882-dfdac8d6aac6", "AQAAAAIAAYagAAAAEMBqoICyfiEkPv5wEGrH5udjo8NoDhV3nZzeuA+ME6ar/2eFJV2Sr2z5bKJch9CDNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63e1220a-9b41-4676-b6aa-c8677f464746", "AQAAAAIAAYagAAAAEDHu4N/h1BK1XgoF0i+vWNwFr1/YnaZzdBqf7X62YSTeQ7rO1lq700jZJ3yTUNv15A==" });
        }
    }
}
