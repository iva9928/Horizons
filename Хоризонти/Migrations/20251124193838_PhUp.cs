using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class PhUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b38e10b2-cfbe-4a2f-8927-3b1e18596ed0", "AQAAAAIAAYagAAAAEKtLlsn7bcjWjxjSGkVZi+8CbwNLBEIkN1COfutEDIvjIEsKrhg9LFsmR6hzD8kVig==", "0cbcfa00-4158-47c1-8434-c9f4bf961f46" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.0f6956b90ab335551ef69581b5fb249c?rik=isKYGcW46QN7Wg&riu=http%3a%2f%2fwww.torre-bg.com%2fimages%2ftravel_offer_images%2fsm.jpg&ehk=A4tcxFAyfCoYpcrgn%2bBHb5mJLTDytaoeZw4chEgjM7U%3d&risl=&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.069ba412d447d50a586d1836cc84c66f?rik=dN5O%2b4J3ghtCwA&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse4.mm.bing.net/th/id/OIP.w6SkxFzGIvY4ESdZwcs3mwHaE3?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse4.mm.bing.net/th/id/OIP.XcL7FSfxMczbaMFwc4YEPgHaJ4?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse4.mm.bing.net/th/id/OIP.LLbqun3yJfkPrZZD7Ie6xAHaDC?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.a5291d2e52f73c8001355d5eb15368ca?rik=R0DvhlMQg3M4bA&riu=http%3a%2f%2fwww.bestplacesinbulgaria.com%2fwp-content%2fuploads%2f2016%2f07%2fthe-waterfall-canyon-tourist-eco-route-04.jpg&ehk=oCv5V7rhnBFogS4%2fm7xRsyWvJs0xKlq0uAwRHdAb%2fZI%3d&risl=&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.b048105f8f39b372ffdea8dbcf05c795?rik=FCc9PiWL7rUe5Q&riu=http%3a%2f%2fimgrabo.com%2fpics%2fguide%2f900x600%2f20160601155206_11652.jpeg&ehk=DaVIqKNWclj1HLtnZ9PETVjw7xvfpNsSMMmVTryhjsE%3d&risl=&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.dac78f30028a402c35f83f7c13014156?rik=ai36YaI2926Wgg&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse1.mm.bing.net/th/id/OIP.E3gs9mp6NNpTDsT5a8ZVjgHaE8?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.0a050afe7b3736527938ed15d7e9a03d?rik=57SHvi48b7i2bw&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.9f1c32a1258db100a6f29964c02ff682?rik=oHJQwPzmxk2tYQ&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.ddeeca6d4f5ce0ec0204b62cc8e37980?rik=25fdGAogwznqjw&riu=http%3a%2f%2fblog.hotel-extreme.bg%2fwp-content%2fuploads%2f2017%2f06%2f6_Fotor1400%d0%bb%d0%be%d0%b3%d0%be-min-1068x600.jpg&ehk=WkEtKlbiCqR1bwRIKog51GgKMwxRCKgwFRsxHPecX8g%3d&risl=&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse2.mm.bing.net/th/id/OIP.CO4dsfPS4jbawx7C25h4eQAAAA?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.5471ea23b3474a4421aca6f30071e691?rik=9xyjKKpLceVaFQ&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse3.mm.bing.net/th/id/OIP.DN8OOsa-_uZWXD2EQLyFkgHaFj?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse2.mm.bing.net/th/id/OIP.WkpaLcOORed2Oc25sw9rRQHaFj?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.3d8cc2eb89f0e6b7b09f5a80e9645555?rik=KH2XtILVhMcRxA&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.1bddc5bf1178275fa5ceed3a41b5ba7b?rik=E5tlQ55qqhUTZw&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse1.mm.bing.net/th/id/OIP.FgtZsnzP3v-JbSbsPskOfAHaE8?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse1.mm.bing.net/th/id/OIP.1eT0klYEsE8Vyn0m_PckzgHaFj?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://www.bestplacesinbulgaria.com/wp-content/uploads/2016/03/golyam_perelik_02.jpg", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.38b7087237df7dea6a5c55b2bba060b0?rik=%2bBeclaLOWgBkSg&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse3.mm.bing.net/th/id/OIP.S_fTI4mlWg9XtR06LbxXHwHaEL?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse4.mm.bing.net/th/id/OIP.sWaV4rkPqBco2_K_4KpJYwHaFo?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://planinka.bg/wp-content/uploads/2024/09/DSCF5725-683x1024.webp", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://cs14.pikabu.ru/post_img/big/2023/08/08/4/1691469042148636877.jpg", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse3.mm.bing.net/th/id/OIP.gRBxnuvSn5A0TaMMIRfL4wHaE8?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://th.bing.com/th/id/R.1dae6b2b41ce335644aa4a7945e01631?rik=fx7pNFgWyBe1Uw&pid=ImgRaw&r=0", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://tse3.mm.bing.net/th/id/OIP.qmgnBIPyzwGyuIeDA4L38gHaE8?rs=1&pid=ImgDetMain&o=7&rm=3", new DateTime(2025, 11, 24, 21, 38, 38, 19, DateTimeKind.Local).AddTicks(1323) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13e0b862-4f30-4fb1-ac07-1286907d86f3", "AQAAAAIAAYagAAAAEHtS5im8wd3FTH6tR+fbBCZhPvAtbB+eoAp0c9+Y0LlgVEh8OuwDzntSmYiXix2qIQ==", "73381a08-0a56-4493-ad4e-815ae855eb8e" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxKcGnaJ44fvZ04MDrBy6cfa6enZfFGmFIBw&s", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://pateka.im/wp-content/uploads/2021/08/Dyavolskoto-gurlo-16.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://visitsmolyan.bg/wp-content/uploads/2021/04/Пещера-Ухловица.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/4/45/Trigrad_gorge.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://romantika-bg.com/images/Buinovsko_jdrelo.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://patepisanici.com/wp-content/uploads/2019/01/05-1.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://www.chudnitemostove.bgsait.com/assets/images/850x566.jpeg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/8/80/Kamenna_svatba.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://imgrabo.com/pics/guide/20170905124603_35581.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://imgrabo.com/pics/guide/900x600/20210413115332_92103.jpeg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://planinka.bg/wp-content/uploads/2024/05/DSCF2704.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://drumivdumi.com/wp-content/uploads/2020/11/ekopyteka.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://drumivdumi.com/wp-content/uploads/2015/07/slivodolsko.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://waterfallsbg.info/assets/Samodivskoto.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://drumivdumi.com/wp-content/uploads/2016/08/orfei.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://visitsmolyan.bg/wp-content/uploads/2020/11/smolyan-lakes.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/f/fb/Yazovir_dospat_40.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://static.pochivka.bg/sights.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://static.pochivka.bg/kormisosh.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSiGCZA", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/6/69/Pamporovoresort.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://static.pochivka.bg/perelik.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://imgrabo.com/pics/guide/20160128144426_93270.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://imgrabo.com/pics/guide/20170526165250_94251.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/5/5c/Yagodina_Orlovo_oko_1.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://izbulgaria.com/wp-content/uploads/2021/10/panoramna.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://visitsmolyan.bg/wp-content/uploads/2020/10/Mugla-panorama.png", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://www.visitplovdiv.com/sites/default/files/belintash.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/c/ca/Karadzhov_kamik.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImageUrl", "PublishedOn" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/5/59/TatulSanctuaryHill.jpg", new DateTime(2025, 11, 24, 21, 23, 46, 665, DateTimeKind.Local).AddTicks(2113) });
        }
    }
}
