using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class phAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "407a319f-611a-4732-8e4e-0eff44fe8ffb", "AQAAAAIAAYagAAAAEIsgsZX3Rcm/RIWDIUp2c1jH+NVWnowPfSsOf2J6+jgUGF7Zn2kSh7z4olV+Ht81xw==", "5e3b317f-cf10-487d-91bc-9881b69c47c4" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "Област Смолян, Западни Родопи, на по-малко от 2км от Триград, на 25км от Девин и на 34км от Доспат", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "Ухловица е село в Южна България. То се намира в община Смолян, област Смолян", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "Започва на около 1,5 km северно от село Триград на около 1180 m н.в., където Триградска река влиза в пещерата Дяволското гърло и 530 m след това излиза като голям карстов извор. ", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "Буйновското ждрело се намира в Родопите, северно от село Буйново, община Борино. Проломът следва течението на Буйновска река, като е достъпен за разходка от двете му страни, а най-близката голяма община е Доспат. ", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "Каньонът на водопадите се намира в Родопите, близо до град Смолян. За да стигнете до него, трябва да поемете по пътя от Смолян за село Мугла и да потърсите отбивка вдясно, след стара автобаза или бетонновъзел. ", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "Чудните мостове са разположени на около 16 км от главния път Асеновград – Смолян. Малко преди Чепеларе, идвайки от Асеновград вдясно ще видите указателна табела сочеща към Чудните мостове. С кола това разстояние се пропътува за около 20-25 мин.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "Намира  се на 5 км източно от центъра на град Кърджали, край село Зимзелен. Разположен е в Източни родопи", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "В Родопите, на около 3км от центъра на град Девин, Смолянска област, на 45км от Смолян, на 40км от Доспат", "/images/ЕДЛ.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Само на 2-3 км от Смолян, по пътя за село Мугла е изградена красивата екопътека Каньонът на водопадите", "/images/ЕКВ.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Водопадът се намира на около 15 километра южно от Асеновград", "/images/ВСПП.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "в Родопите, в близост до град Девин, на 15 мин от маршрута на екопътека Струилица-Калето-Лъката, Смолянска област, на 40км от Доспат, на 45км от Смолян", "/images/ВСП.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Водопад Орфей се намира в местност Сосковчето, област Смолян, на 5 км от града, като е част от екопътека Каньона на водопадите.", "/images/ВО.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "В покрайнините на град Смолян, пръснати по левия склон на долината на черна река, се намират известните Смолянски езера. ", "/images/СЕ.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Разположен в посока северозапад – югоизток в землищата на градовете Доспат и Сърница, които са свързани с живописен път, минаващ по североизточния му бряг.", "/images/ЯД.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Язовир Широка поляна се намира в борова гора на надморска височина 1500 м в Западните Родопи, на около 30 км от Батак.", "/images/ЯШ.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "Разположен в Резерват Планинският масив на Родопите", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "В сърцето на Родопите, в долината на река Чепеларска и по планинския рид Добростан.", "/images/ЧС.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Намира се близо да зимния курорт на няколко километра от град Смолян", "/images/БГ.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Location", "LocationUrl", "Name", "PublishedOn" },
                values: new object[] { "Връх Голям Перелик е най-високата точка на Родопите и се намира в най-западната част на планината.\r\nДостъп:\r\nДо подножието на върха се стига с кола до хижа Перелик, а оттам пеша за около 40-45 минути.\r\nДостъпът до самия връх Голям Перелик е забранен заради военно поделение.\r\nНай-близкият достъпен връх, до който може да се стигне, е Малък Перелик или Широколъшки снежник.\r\nАлтернативни маршрути:\r\nОт хижа Перелик има маркирани туристически маршрути до връх Широколъшки снежник, село Мугла, Гела и други интересни места.\r\nСъщо така, от хижата могат да се посетят и други забележителности като пещера Ледницата, Каньона на водопадите и пещера Дяволското гърло.\r\nГледки: От района на Перелик се откриват красиви панорамни гледки към Смолян и цялата Родопа планина. \r\nВръх Голям Перелик - Туристически пътеводител на Смолян\r\nВАЖНА ИНФОРМАЦИЯ Същинският връх Голям Перелик попада в зоната на секретно военно поделение, разположено в района. Достъпът до нег...\r\n\r\nvisitsmolyan.bg\r\n\r\nНай-високата точка в Родопите е връх Голям Перелик ...\r\n18.08.2024 г. — Най-високата точка в Родопите е връх Голям Перелик (2191) м. Той се намира на територията на военно поделение и достъ...\r\n\r\n\r\nFacebook·Божидар Савов\r\n\r\n№85 Родопи - връх Голям Перелик - 100 обекта\r\n21.12.2012 г. — Голям Перелик е най-високият връх в Родопите. Намира се на 19 км западно от Смолян. С него (2191 м) Родопите се нареж...\r\n\r\n100obekta.com\r\n\r\nПоказване на всички\r\n", "/images/ПЕР.png", "Връх Голям Перелик", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Намира се в Родопи, близо до Пампорово, на около 15 км от Смолян.", "/images/СНЕЖ.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "най-високият в Родопския дял Чернатица. На юг по билото е свързан с връх Мечкарски камък.", "/images/ГП.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Панорамна площадка", "Орлово око е панорамна площадка, която се намира в Западните Родопи, на връх Свети Илия.", "/images/ОО.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Намира се над град Смолян, в планината Родопи.", "/images/ППН.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "В в Западните Родопи, област Смолян.", "/images/М.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Белинташ се намира в Родопите, на 32,6 км от град Асеновград, над селата Врата и Мостово.", "/images/Б.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Намира се в близост до село Мостово в Западните Родопи.", "/images/KK.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Татул се намира в м. Кая Башъ, в южните покрайнини на малкото източно родопско селце Татул", "/images/Т.png", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8816e9a1-8993-4283-9bd0-3b9225c70f53", "AQAAAAIAAYagAAAAEMbfojDjkP+drmf/tzgCI2lOgdX6ftXrSoivQZZy9U7ne6VPcfNrDPmAUBZTvac1NQ==", "25bbe27e-e2d6-41e0-b435-d37cf703665c" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "бласт Смолян, Западни Родопи, на по-малко от 2км от Триград, на 25км от Девин и на 34км от Доспат", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "е намира на 5 км източно от центъра на град Кърджали, край село Зимзелен. Разположен е в Източни родопи", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Location", "PublishedOn" },
                values: new object[] { "", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Location", "LocationUrl", "Name", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", "Връх Перелик", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "Панорамна площадка.", "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Location", "LocationUrl", "PublishedOn" },
                values: new object[] { "", "/images/ЯП.png", new DateTime(2025, 11, 24, 19, 11, 16, 58, DateTimeKind.Local).AddTicks(5695) });
        }
    }
}
