using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsGuide = table.Column<bool>(type: "bit", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terrains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terrains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PublishedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TerrainId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Season = table.Column<int>(type: "int", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Destinations_AspNetUsers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Destinations_Terrains_TerrainId",
                        column: x => x.TerrainId,
                        principalTable: "Terrains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeopleCount = table.Column<int>(type: "int", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDestinations",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDestinations", x => new { x.UserId, x.DestinationId });
                    table.ForeignKey(
                        name: "FK_UserDestinations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDestinations_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Bio", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsGuide", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7699db7d-964f-4782-8209-d76562e0fece", 0, 30, "Main administrator of Horizons.", "071d6f64-4489-4b38-a670-a2226701b3a9", "admin@horizons.com", true, false, false, null, "ADMIN@HORIZONS.COM", "ADMIN@HORIZONS.COM", "AQAAAAIAAYagAAAAEOvrvoIeILjsgffsvS6xj18tuLwIjISIYNvhuh9uAPGzX4HKbDlvAUVeW4MCsGIaww==", null, false, null, "STATIC_SECURITY_STAMP", false, "admin@horizons.com" });

            migrationBuilder.InsertData(
                table: "Terrains",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Пещера" },
                    { 2, "Ждрело / Каньон" },
                    { 3, "Скални образувания" },
                    { 4, "Екопътека" },
                    { 5, "Водопад" },
                    { 6, "Езеро" },
                    { 7, "Гора / Резерват" },
                    { 8, "Връх" },
                    { 9, "Панорамна площадка" },
                    { 10, "Светилище / Историческо място" }
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Location", "LocationUrl", "Name", "PublishedOn", "PublisherId", "Season", "TerrainId", "TicketPrice", "VideoUrl" },
                values: new object[,]
                {
                    { 1, "Дяволското гърло е мистична пропастна пещера, известна със своя огромен подземен водопад — най-големият на Балканите. Легендата разказва, че именно тук Орфей е слязъл в подземния свят, за да търси любимата си Евридика. Входната зала е колосална и създава оглушителен тътен от водата, която изчезва в неизследван сифон. Пещерата вдъхновява с драматична атмосфера, величествени скални форми и усещане за древна, сурова мощ.", "https://th.bing.com/th/id/R.0f6956b90ab335551ef69581b5fb249c?rik=isKYGcW46QN7Wg&riu=http%3a%2f%2fwww.torre-bg.com%2fimages%2ftravel_offer_images%2fsm.jpg&ehk=A4tcxFAyfCoYpcrgn%2bBHb5mJLTDytaoeZw4chEgjM7U%3d&risl=&pid=ImgRaw&r=0", false, "Ягодинската пещера е разположена в Родопите, само на 3 км от село Ягодина.", "/images/ЯП.png", "Ягодинска пещера", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 3, 1, 12m, "https://www.youtube.com/embed/7eBi4Bq85xE" },
                    { 2, "Дяволското гърло е мистична пропастна пещера, известна със своя огромен подземен водопад — най-големият на Балканите. Легендата разказва, че именно тук Орфей е слязъл в подземния свят, за да търси любимата си Евридика. Входната зала е колосална и създава оглушителен тътен от водата, която изчезва в неизследван сифон. Пещерата вдъхновява с драматична атмосфера, величествени скални форми и усещане за древна, сурова мощ.", "https://th.bing.com/th/id/R.069ba412d447d50a586d1836cc84c66f?rik=dN5O%2b4J3ghtCwA&pid=ImgRaw&r=0", false, "Област Смолян, Западни Родопи, на по-малко от 2км от Триград, на 25км от Девин и на 34км от Доспат", "/images/ДГ.png", "Пещера Дяволското гърло", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 3, 1, 15m, "https://www.youtube.com/embed/_dg8xrSLYcw?start=28" },
                    { 3, "Ухловица е една от най-красивите пещери в Родопите, често наричана „подземната фея“. Тя се отличава с кристално бели калцитни форми, каскадни тераси и уникални подземни езера. Най-впечатляващата част е „Сребърният водопад“ — варовикова каскада, която блести при осветяване. Пещерата се достига по стръмни стълби, но усилието си заслужава заради изумителните природни картини.", "https://tse4.mm.bing.net/th/id/OIP.w6SkxFzGIvY4ESdZwcs3mwHaE3?rs=1&pid=ImgDetMain&o=7&rm=3", false, "Ухловица е село в Южна България. То се намира в община Смолян, област Смолян", "/images/У.png", "Ухловица", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 3, 1, 10m, "https://www.youtube.com/embed/KyUtzNQmQ_I" },
                    { 4, "Триградското ждрело е величествен карстов каньон...", "https://tse4.mm.bing.net/th/id/OIP.XcL7FSfxMczbaMFwc4YEPgHaJ4?rs=1&pid=ImgDetMain&o=7&rm=3", false, "Започва на около 1,5 km северно от село Триград...", "/images/ТЖ.png", "Триградско ждрело", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 2, 0m, "https://www.youtube.com/embed/wmxbIB5JuCI?start=56" },
                    { 5, "Буйновското ждрело е най-дългото ждрело в България...", "https://tse4.mm.bing.net/th/id/OIP.LLbqun3yJfkPrZZD7Ie6xAHaDC?rs=1&pid=ImgDetMain&o=7&rm=3", false, "Буйновското ждрело се намира в Родопите...", "/images/БЖ.png", "Буйновско ждрело", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 2, 0m, "https://www.youtube.com/embed/RXMaOdj88B4" },
                    { 6, "Каньонът на водопадите е природен резерват...", "https://th.bing.com/th/id/R.a5291d2e52f73c8001355d5eb15368ca?rik=R0DvhlMQg3M4bA&riu=http%3a%2f%2fwww.bestplacesinbulgaria.com%2fwp-content%2fuploads%2f2016%2f07%2fthe-waterfall-canyon-tourist-eco-route-04.jpg&ehk=oCv5V7rhnBFogS4%2fm7xRsyWvJs0xKlq0uAwRHdAb%2fZI%3d&risl=&pid=ImgRaw&r=0", false, "Каньонът на водопадите се намира в Родопите...", "/images/КВ.png", "Каньонът на водопадите", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 2, 0m, "https://www.youtube.com/embed/3GhaDD5iaXk" },
                    { 7, "Чудните мостове са природно образувани мраморни арки...", "https://th.bing.com/th/id/R.b048105f8f39b372ffdea8dbcf05c795?rik=FCc9PiWL7rUe5Q&riu=http%3a%2f%2fimgrabo.com%2fpics%2fguide%2f900x600%2f20160601155206_11652.jpeg&ehk=DaVIqKNWclj1HLtnZ9PETVjw7xvfpNsSMMmVTryhjsE%3d&risl=&pid=ImgRaw&r=0", false, "Чудните мостове са разположени на около 16 км...", "/images/ЧМ.png", "Чудните мостове", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 3, 0m, "https://www.youtube.com/embed/sGwA9KiQL-s?start=20" },
                    { 8, "Каменната сватба е група от розово-бели скални фигури...", "https://th.bing.com/th/id/R.dac78f30028a402c35f83f7c13014156?rik=ai36YaI2926Wgg&pid=ImgRaw&r=0", false, "Намира се на 5 км източно от центъра на град Кърджали...", "/images/ВС.png", "Каменната сватба", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 3, 0m, "https://www.youtube.com/embed/qWWHbqvgodI" },
                    { 9, "Орфееви скали са панорамен скален масив...", "https://tse1.mm.bing.net/th/id/OIP.E3gs9mp6NNpTDsT5a8ZVjgHaE8?rs=1&pid=ImgDetMain&o=7&rm=3", false, "Орфееви скали се намира в сърцето на Родопите...", "/images/ОС.png", "Орфееви скали", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 3, 0m, "https://www.youtube.com/embed/TquHEt3VnNA?start=24" },
                    { 10, "Екопътека Невястата е къса, но изключително красива пътека...", "https://th.bing.com/th/id/R.0a050afe7b3736527938ed15d7e9a03d?rik=57SHvi48b7i2bw&pid=ImgRaw&r=0", false, "Екопътека “Невястата” се намира в сърцето на Родопи...", "/images/Н.png", "Екопътека Невястата", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 1, 4, 2m, "https://www.youtube.com/embed/ZKz12LqDtEo" },
                    { 11, "Екопътеката разкрива уникални панорами към долината на река Въча...", "https://i.pinimg.com/originals/7a/ea/e5/7aeae5868a2c405cb35e18f18af472ce.jpg", false, "В Родопите, на около 3км от центъра на град Девин...", "/images/ЕДЛ.png", "Екопътека Девин – Лъки", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 1, 4, 0m, "https://www.youtube.com/embed/OnwO_cKrtOk" },
                    { 12, "Това е една от най-популярните екопътеки в България...", "https://th.bing.com/th/id/R.9f1c32a1258db100a6f29964c02ff682?rik=oHJQwPzmxk2tYQ&pid=ImgRaw&r=0", false, "Само на 2-3 км от Смолян...", "/images/ЕКВ.png", "Екопътека Каньонът на водопадите", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 1, 4, 2m, "https://www.youtube.com/embed/KfT4eUp56Vc" },
                    { 13, "Сливодолското падало е един от най-високите и красиви водопади в Родопите...", "https://th.bing.com/th/id/R.ddeeca6d4f5ce0ec0204b62cc8e37980?rik=25fdGAogwznqjw&riu=http%3a%2f%2fblog.hotel-extreme.bg%2fwp-content%2fuploads%2f2017%2f06%2f6_Fotor1400%d0%bb%d0%be%d0%b3%d0%be-min-1068x600.jpg&ehk=WkEtKlbiCqR1bwRIKog51GgKMwxRCKgwFRsxHPecX8g%3d&risl=&pid=ImgRaw&r=0", false, "Водопадът се намира на около 15 километра южно от Асеновград", "/images/ВСПП.png", "Сливодолското падало", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 1, 5, 0m, "https://www.youtube.com/embed/C7tUIZPyLgM?start=46" },
                    { 14, "Според легендите тук са танцували самодиви...", "https://tse2.mm.bing.net/th/id/OIP.CO4dsfPS4jbawx7C25h4eQAAAA?rs=1&pid=ImgDetMain&o=7&rm=3", false, "В Родопите, в близост до град Девин...", "/images/ВСП.png", "Самодивско пръскало", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 1, 5, 0m, "https://www.youtube.com/embed/xkymhO4rF6o?start=71" },
                    { 15, "Водопад Орфей е част от Каньона на водопадите...", "https://th.bing.com/th/id/R.5471ea23b3474a4421aca6f30071e691?rik=9xyjKKpLceVaFQ&pid=ImgRaw&r=0", false, "Водопад Орфей се намира в местност Сосковчето...", "/images/ВО.png", "Водопад Орфей", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 1, 5, 0m, "https://www.youtube.com/embed/vtiVLTa6CWY" },
                    { 16, "Смолянските езера са група от 20 естествени езера...", "https://tse3.mm.bing.net/th/id/OIP.DN8OOsa-_uZWXD2EQLyFkgHaFj?rs=1&pid=ImgDetMain&o=7&rm=3", false, "В покрайнините на град Смолян...", "/images/СЕ.png", "Смолянски езера", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 6, 0m, "https://www.youtube.com/embed/yeXTCyjg2lE" },
                    { 17, "Язовир Доспат е един от най-красивите язовири...", "https://tse2.mm.bing.net/th/id/OIP.WkpaLcOORed2Oc25sw9rRQHaFj?rs=1&pid=ImgDetMain&o=7&rm=3", false, "Разположен в посока северозапад – югоизток...", "/images/ЯД.png", "Язовир Доспат", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 6, 0m, "https://www.youtube.com/embed/JkWGJC_kjZk?start=24" },
                    { 18, "Широка поляна е любим язовир за риболовци...", "https://th.bing.com/th/id/R.3d8cc2eb89f0e6b7b09f5a80e9645555?rik=KH2XtILVhMcRxA&pid=ImgRaw&r=0", false, "Язовир Широка поляна се намира в борова гора...", "/images/ЯШ.png", "Язовир Широка поляна", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 6, 0m, "https://www.youtube.com/embed/ZlgSpXgvPQ4?start=53" },
                    { 19, "Кормисош е огромен биосферен резерват...", "https://th.bing.com/th/id/R.1bddc5bf1178275fa5ceed3a41b5ba7b?rik=E5tlQ55qqhUTZw&pid=ImgRaw&r=0", false, "Разположен в Родопите", "/images/ЯП.png", "Резерват Кормисош", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 3, 7, 0m, "https://www.youtube.com/embed/yAmSJVYXewY" },
                    { 20, "Червената стена е биосферен резерват под закрилата на UNESCO...", "https://tse1.mm.bing.net/th/id/OIP.FgtZsnzP3v-JbSbsPskOfAHaE8?rs=1&pid=ImgDetMain&o=7&rm=3", false, "В сърцето на Родопите...", "/images/ЧС.png", "Резерват Червената стена", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 3, 7, 0m, "https://www.youtube.com/embed/Tbo4FVD8e0w?start=22" },
                    { 21, "Боровите гори около Пампорово създават усещане за алпийски пейзаж...", "https://tse1.mm.bing.net/th/id/OIP.1eT0klYEsE8Vyn0m_PckzgHaFj?rs=1&pid=ImgDetMain&o=7&rm=3", false, "Намира се близо до зимния курорт...", "/images/БГ.png", "Борова гора край Пампорово", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 3, 7, 0m, "https://www.youtube.com/embed/B0vsbEh8jtk" },
                    { 22, "Голям Перелик е най-високият връх в Родопите (2191 м)...", "https://www.bestplacesinbulgaria.com/wp-content/uploads/2016/03/golyam_perelik_02.jpg", false, "Връх Голям Перелик е най-високата точка на Родопите...", "/images/ПЕР.png", "Връх Голям Перелик", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 4, 8, 0m, "https://www.youtube.com/embed/uARzLBZ4_UA" },
                    { 23, "Снежанка е известен със своята телевизионна кула...", "https://th.bing.com/th/id/R.38b7087237df7dea6a5c55b2bba060b0?rik=%2bBeclaLOWgBkSg&pid=ImgRaw&r=0", false, "Намира се в Родопи, близо до Пампорово...", "/images/СНЕЖ.png", "Връх Снежанка", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 4, 8, 0m, "https://www.youtube.com/embed/aFIq2S2fXEI" },
                    { 24, "Голям Персенк е един от най-красивите върхове в Родопите...", "https://tse3.mm.bing.net/th/id/OIP.S_fTI4mlWg9XtR06LbxXHwHaEL?rs=1&pid=ImgDetMain&o=7&rm=3", false, "Най-високият в Родопския дял Чернатица...", "/images/ГП.png", "Голям Персенк", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 8, 0m, "https://www.youtube.com/embed/IJbpxlSFawg" },
                    { 25, "Орлово око е панорамна площадка...", "https://tse4.mm.bing.net/th/id/OIP.sWaV4rkPqBco2_K_4KpJYwHaFo?rs=1&pid=ImgDetMain&o=7&rm=3", false, "Орлово око се намира в Западните Родопи...", "/images/ОО.png", "Орлово око", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 9, 6m, "https://www.youtube.com/embed/uARzLBZ4_UA" },
                    { 26, "Площадката предлага чудесна гледка към град Смолян...", "https://planinka.bg/wp-content/uploads/2024/09/DSCF5725-683x1024.webp", false, "Намира се над град Смолян...", "/images/ППН.png", "Панорамна площадка Невястата", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 9, 4m, "https://www.youtube.com/embed/9FvP5rcw6kk" },
                    { 27, "Панорамните ридове над село Мугла...", "https://cs14.pikabu.ru/post_img/big/2023/08/08/4/1691469042148636877.jpg", false, "В Западните Родопи, област Смолян.", "/images/М.png", "Панорама над Мугла", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 2, 9, 0m, "https://www.youtube.com/embed/94xSOxLhuXY?start=46" },
                    { 28, "Белинташ е едно от най-известните тракийски светилища...", "https://tse3.mm.bing.net/th/id/OIP.gRBxnuvSn5A0TaMMIRfL4wHaE8?rs=1&pid=ImgDetMain&o=7&rm=3", false, "Белинташ се намира в Родопите...", "/images/Б.png", "Белинташ", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 1, 10, 6m, "https://www.youtube.com/embed/b55bpx1JN48" },
                    { 29, "Караджов камък е величествена скална арка...", "https://th.bing.com/th/id/R.1dae6b2b41ce335644aa4a7945e01631?rik=fx7pNFgWyBe1Uw&pid=ImgRaw&r=0", false, "Намира се в близост до село Мостово...", "/images/KK.png", "Караджов камък", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 1, 10, 6m, "https://www.youtube.com/embed/s4iG2ux2gQc?start=28" },
                    { 30, "Татул е древно тракийско светилище...", "https://tse3.mm.bing.net/th/id/OIP.qmgnBIPyzwGyuIeDA4L38gHaE8?rs=1&pid=ImgDetMain&o=7&rm=3", false, "Татул се намира в м. Кая Башъ...", "/images/Т.png", "Татул", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7699db7d-964f-4782-8209-d76562e0fece", 1, 10, 6m, "https://www.youtube.com/embed/7cAKSl69e5U?start=564" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_PublisherId",
                table: "Destinations",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_TerrainId",
                table: "Destinations",
                column: "TerrainId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_DestinationId",
                table: "Ratings",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DestinationId",
                table: "Reservations",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDestinations_DestinationId",
                table: "UserDestinations",
                column: "DestinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "UserDestinations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Terrains");
        }
    }
}
