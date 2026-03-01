using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class FixTourRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_AspNetUsers_GuideId",
                table: "Tours");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Destinations_DestinationId",
                table: "Tours");

            migrationBuilder.AddColumn<int>(
                name: "TourId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TourReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeopleCount = table.Column<int>(type: "int", nullable: false),
                    PricePerPerson = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourReservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TourReservations_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22e168f3-2b16-4984-90ba-bdacc7e2e30e", "AQAAAAIAAYagAAAAED6a8pHqLB6Zo9HzDOOaNCjXJylKBH4EGiqLhqgBG5D6mJ5R0bW9yg4aa5RRtJ5cmg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Bio", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsGuide", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11111111-1111-1111-1111-111111111111", 0, 34, "Планински гид с над 10 години опит в Родопите. Специализира в пещерни маршрути и високопланински преходи.", "678c1ddd-8636-423b-88a5-870c6b7d32d7", "ivan.petrov@horizons.com", true, true, false, null, "IVAN.PETROV@HORIZONS.COM", "IVAN.PETROV@HORIZONS.COM", "AQAAAAIAAYagAAAAEAedJYu6UPTJa0TqobaeRLvswXrvnmazqJkCPZ/mSFOnYpYGrCQDtaiDLjbh2Es4uQ==", null, false, "https://thispersondoesnotexist.com/", "GUIDE1_SECURITY", false, "ivan.petrov@horizons.com" },
                    { "22222222-2222-2222-2222-222222222222", 0, 29, "Лицензиран екскурзовод и любител на екопътеките. Организира турове до водопади и панорамни площадки.", "7a82aa5c-dd90-4070-ac9e-f2ac77cb44ea", "maria.stoyanova@horizons.com", true, true, false, null, "MARIA.STOYANOVA@HORIZONS.COM", "MARIA.STOYANOVA@HORIZONS.COM", "AQAAAAIAAYagAAAAEKMM3k/uYXOVUgKpVQqiGmOtvWd2bQQMh/eH7c6b4mWNLxcjoosqaGQbK8qurMVZJg==", null, false, "https://thispersondoesnotexist.com/", "GUIDE2_SECURITY", false, "maria.stoyanova@horizons.com" },
                    { "33333333-3333-3333-3333-333333333333", 0, 41, "Специалист по исторически маршрути и тракийски светилища. Разказвач на легенди и местен фолклор.", "27a43dda-b322-4f3b-a566-26532df3b880", "georgi.dimitrov@horizons.com", true, true, false, null, "GEORGI.DIMITROV@HORIZONS.COM", "GEORGI.DIMITROV@HORIZONS.COM", "AQAAAAIAAYagAAAAEFOLwKpGmm3gfyJuM5ZccahEaORF98w9GCpNVIgyTqZjZ/kCZ70jlOYmtRF4lwiDEw==", null, false, "https://thispersondoesnotexist.com/", "GUIDE3_SECURITY", false, "georgi.dimitrov@horizons.com" },
                    { "44444444-4444-4444-4444-444444444444", 0, 32, "Професионален планински водач, сертифициран за зимни преходи и снежни маршрути.", "916a79f8-542a-4545-85c4-f6291e91f726", "elena.ivanova@horizons.com", true, true, false, null, "ELENA.IVANOVA@HORIZONS.COM", "ELENA.IVANOVA@HORIZONS.COM", "AQAAAAIAAYagAAAAEFZUJ55P7Dixiy1wG0D0fECyZgJWKZKhqpWLtDJm91nVaG4RV5eu0MKpuNok45+2WQ==", null, false, "https://thispersondoesnotexist.com/", "GUIDE4_SECURITY", false, "elena.ivanova@horizons.com" },
                    { "55555555-5555-5555-5555-555555555555", 0, 38, "Еко-туризъм и приключенски маршрути. Организира групови експедиции до върхове и резервати.", "3bb3afc1-3a0e-4bbe-b412-a557abc1b1e2", "nikolay.kolev@horizons.com", true, true, false, null, "NIKOLAY.KOLEV@HORIZONS.COM", "NIKOLAY.KOLEV@HORIZONS.COM", "AQAAAAIAAYagAAAAECjJzLlPOBTjNGD/IItSGtM2U4I0J7jFl5UyGH+6WFhEhjL4MmZtF/p6ZLjq0Dmp3g==", null, false, "https://thispersondoesnotexist.com/", "GUIDE5_SECURITY", false, "nikolay.kolev@horizons.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_DestinationId",
                table: "Messages",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_TourId",
                table: "Messages",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TourReservations_TourId",
                table: "TourReservations",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TourReservations_UserId",
                table: "TourReservations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Destinations_DestinationId",
                table: "Messages",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Tours_TourId",
                table: "Messages",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_AspNetUsers_GuideId",
                table: "Tours",
                column: "GuideId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Destinations_DestinationId",
                table: "Tours",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Destinations_DestinationId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Tours_TourId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_AspNetUsers_GuideId",
                table: "Tours");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Destinations_DestinationId",
                table: "Tours");

            migrationBuilder.DropTable(
                name: "TourReservations");

            migrationBuilder.DropIndex(
                name: "IX_Messages_DestinationId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_TourId",
                table: "Messages");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555");

            migrationBuilder.DropColumn(
                name: "TourId",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef6ecd5a-8a6b-4b3f-9e53-2f413da9cd99", "AQAAAAIAAYagAAAAELuWKgtrggULomHrwpP705/PpFAgTLPkfgydwW10z8K6dUQ2YzTTS2+77Jwjn2yt3A==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_AspNetUsers_GuideId",
                table: "Tours",
                column: "GuideId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Destinations_DestinationId",
                table: "Tours",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
