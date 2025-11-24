using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class Reserve : Migration
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
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PublishedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerrainId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7699db7d-964f-4782-8209-d76562e0fece", 0, "3d4cb4f8-51cd-4570-b55a-1a61d3e73ca9", "admin@horizons.com", true, false, null, "ADMIN@HORIZONS.COM", "ADMIN@HORIZONS.COM", "AQAAAAIAAYagAAAAEOxUhtfbrHR/DMVUhpEvTHET7dSOkn28dPNa74FDjDkMoIXYyMKjCmJU7q1FxPx9Ig==", null, false, "49d24562-a9bd-4a6c-ba45-1282e63474ff", false, "admin@horizons.com" });

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
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Name", "PublishedOn", "PublisherId", "TerrainId" },
                values: new object[,]
                {
                    { 1, "Карстова пещера в Буйновското ждрело, част от сложна триетажна система с над 10 км галерии, богати сталактити и пещерно жилище от неолита, благоустроена и осветена за туристически посещения.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxKcGnaJ44fvZ04MDrBy6cfa6enZfFGmFIBw&s", false, "Ягодинска пещера", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 1 },
                    { 2, "Пропастна пещера в Триградското ждрело, в която подземна река образува висок водопад, влиза през естествен вход и изчезва в сифони; свързва се с митове за Орфей и слизането му в подземния свят.", "https://pateka.im/wp-content/uploads/2021/08/Dyavolskoto-gurlo-16.jpg", false, "Пещера Дяволското гърло", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 1 },
                    { 3, "Една от най-красивите благоустроени пещери в Родопите, разположена над село Могилица; известна с многоетажни галерии, ледникови форми, синтрови езерца и т.нар. Ледения водопад от бели кристали.", "https://visitsmolyan.bg/wp-content/uploads/2021/04/%D0%9F%D0%B5%D1%89%D0%B5%D1%80%D0%B0-%D0%A3%D1%85%D0%BB%D0%BE%D0%B2%D0%B8%D1%86%D0%B0-%D0%90%D0%B2%D1%82%D0%BE%D1%80-ardaadventures-8.jpg", false, "Ухловица", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 1 },
                    { 4, "Дълбоко карстово ждрело по долината на река Триградска, с отвесни скали над 250 м, тясно шосе и множество тунели; едно от най-внушителните дефилета в България и естествен вход към Дяволското гърло.", "https://upload.wikimedia.org/wikipedia/commons/4/45/Trigrad_gorge.jpg", false, "Триградско ждрело", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 2 },
                    { 5, "Най-дългото ждрело в България, образувано от река Буйновска между Ягодина и Тешел; известно е с тесен каньон, впечатляващи скални венци и множество пещери, включително входа на Ягодинската пещера.", "https://romantika-bg.com/images/Buinovsko_jdrelo_IMG_0286_GDstyles.jpg", false, "Буйновско ждрело", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 2 },
                    { 6, "Резерват по горното течение на река Еленска над Смолян, където екопътека следва поредица от каскадни водопади, дървени мостчета и панорамни площадки сред иглолистни гори и скалисти склонове.", "https://patepisanici.com/wp-content/uploads/2019/01/05-1.jpg?w=2000&h=1200&crop=1", false, "Каньонът на водопадите", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 2 },
                    { 7, "Големи мраморни арки в рида Чернатица, останки от срутила се пещера, през които минава река Еркюприя; символ на Родопите и защитена местност с туристически маршрути и алпийски маршрути наблизо.", "https://www.chudnitemostove.bgsait.com/assets/images/850x566.jpeg", false, "Чудните мостове", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 3 },
                    { 8, "Скални образувания до село Зимзелен край Кърджали, изградени от вулканични туфи, оформени от ерозия в фигури, наподобяващи сватбено шествие; свързани са с местна легенда за нещастна любов.", "https://upload.wikimedia.org/wikipedia/commons/8/80/Kamenna_svatba_-_The_Groom_and_the_Bride.jpg", false, "Каменната сватба", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 3 },
                    { 9, "Скалисто възвишение над Смолян, свързвано с легендите за Орфей; от площадките се разкриват панорамни гледки към езерата, връх Снежанка и долината, популярно място за кратки преходи и залези.", "https://imgrabo.com/pics/guide/20170905124603_35581.jpg", false, "Орфееви скали", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 3 },
                    { 10, "Къса, но ефектна екопътека над Смолян, която води до скален масив, свързан с легенда за мома Невяста; предлага параклис, панорамна площадка с кръст и изгледи към града и околните върхове.", "https://imgrabo.com/pics/guide/900x600/20210413115332_92103.jpeg", false, "Екопътека Невястата", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 4 },
                    { 11, "Маркиран маршрут в долината на река Въча, който преминава по стари пътища, мостчета и открити ридове между Девин и Лъки; съчетава горски участъци, панорамни гледки и традиционни родопски селища.", "https://planinka.bg/wp-content/uploads/2024/05/DSCF2704-1024x683.webp", false, "Екопътека Девин – Лъки", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 4 },
                    { 12, "Кръгов маршрут в едноименния резерват над Смолян, който изкачва дерето на Еленска река по дървени стълби и мостове покрай серия от водопади, естествени скални прагове и стари смърчови гори.", "https://drumivdumi.com/wp-content/uploads/2020/11/0ekopyteka_kanyona_na_vodopadite_0839.jpg", false, "Екопътека Каньонът на водопадите", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 4 },
                    { 13, "Водопад по река Сливов дол в рида Добростан, част от резерват Червената стена; с обща височина над 45 м и стръмен достъп през букови гори, смятан за един от най-високите в Родопите.", "https://drumivdumi.com/wp-content/uploads/2015/07/1v_nachaloto_kym_vodopad_slivodolsko_padalo_7826.jpg", false, "Сливодолското падало", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 5 },
                    { 14, "Живописен водопад в сърцето на резерват Червената стена, достигащ около 50 м височина; заобиколен от стръмни скали и гори, до него се стига по планинска пътека от село Бачково и хижа Марциганица.", "https://waterfallsbg.info/assets/Samodivskoto/f2085632.jpg", false, "Самодивско пръскало", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 5 },
                    { 15, "Каскаден водопад по един от притоците в Каньона на водопадите, носещ името на Орфей заради живописното си стечение по скалите; посещава се по екопътеката над Смолян в посока Перелик.", "https://drumivdumi.com/wp-content/uploads/2016/08/4canyon_orfej_0608.jpg", false, "Водопад Орфей", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 5 },
                    { 16, "Група от естествени ледникови и свлачищни езера, разположени по долината между Снежанка и Смолян; част от тях са запазени, други са превърнати в рибарници и туристически зони край курорта.", "https://visitsmolyan.bg/wp-content/uploads/2020/11/%D0%A1%D0%BC%D0%BE%D0%BB%D1%8F%D0%BD%D1%81%D0%BA%D0%B8-%D0%B5%D0%B7%D0%B5%D1%80%D0%B0-1-scaled.jpg", false, "Смолянски езера", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 6 },
                    { 17, "Голям язовир на река Доспат, разположен на надморска височина около 1200 м; известен със силно разчленено крайбрежие, борови гори, възможности за риболов, водни спортове и лагеруване.", "https://upload.wikimedia.org/wikipedia/commons/f/fb/Yazovir_dospat_40.jpg", false, "Язовир Доспат", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 6 },
                    { 18, "Планински язовир между връх Голям Перелик и Баташкия дял, заобиколен от гъсти иглолистни гори и множество полуострови; популярен за къмпинг, гребане и фотография на спокойни водни пейзажи.", "https://static.pochivka.bg/sights.bgstay.com/images/01/1071/5465119e2e2f7.jpg", false, "Язовир Широка поляна", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 6 },
                    { 19, "Голям ловно-стопански район и биосферен резерват в Централните Родопи, съхраняващ естествени иглолистни гори и богато животинско разнообразие, включително елени, диви свине и кафява мечка.", "https://static.pochivka.bg/sights.bgstay.com/images/02/2748/5a37883ece1b8.jpg", false, "Резерват Кормисош", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 7 },
                    { 20, "Стръмен варовиков масив над Бачково и Асеновград, обявен за биосферен резерват заради редките си растителни видове, скални местообитания и водопади като Самодивско пръскало и Сливодолското падало.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSiGCZAqUm6xoaBt5IrLzUYiQTSTCuI9KbzQw&s", false, "Резерват Червената стена", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 7 },
                    { 21, "Големи масиви от смърчови и борови гори около курорта Пампорово, поддържащи мек планински климат и множество туристически пътеки и ски писти по склоновете на връх Снежанка.", "https://upload.wikimedia.org/wikipedia/commons/6/69/Pamporovoresort.jpg", false, "Борова гора край Пампорово", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 7 },
                    { 22, "Най-високият връх в Родопите с височина 2191 м, разположен в масива Перелик; на платото му има военни съоръжения, а склоновете са обрасли с иглолистни гори и пасища с панорами към голяма част от планината.", "https://static.pochivka.bg/sights.bgstay.com/images/00/136/541ad01c4ffec.jpg", false, "Връх Перелик", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 8 },
                    { 23, "Знаков връх над Пампорово, висок 1926 м, на който е издигната телевизионна кула с панорамна тераса; център на ски зоната с множество писти и лифтове, достъпен целогодишно по асфалтов път.", "https://imgrabo.com/pics/guide/900x600/20160128144426_93270.jpg", false, "Връх Снежанка", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 8 },
                    { 24, "Масивен връх в рида Чернатица, издигащ се до 2091 м над морето; известен с панорама към Чудните мостове, Баташкия дял и Рила, както и с туристическите маршрути от хижа Персенк и село Орехово.", "https://imgrabo.com/pics/guide/900x600/20170526165250_94251.jpg", false, "Голям Персенк", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 8 },
                    { 25, "Метална панорамна площадка над ръба на скала при връх Свети Илия над Ягодина, достигаща над 1500 м височина; предлага драматични гледки към Буйновското ждрело и билата на Родопите.", "https://upload.wikimedia.org/wikipedia/commons/5/5c/Yagodina_Orlovo_oko_1.jpg", false, "Орлово око", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 9 },
                    { 26, "Съвременна площадка с метален кръст върху скалата Невястата, до която се стига по екопътека; от нея се открива гледка към Смолян, езерата и връх Снежанка, а наоколо има и въжен парк за атракции.", "https://izbulgaria.com/wp-content/uploads/2021/10/panoramna-ploshtadka-na-ekopateka-neviastata-1024x768.jpg", false, "Панорамна площадка Невястата", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 9 },
                    { 27, "Високите поляни и ридове над отдалеченото родопско село Мугла предлагат обширни 360° гледки към планинските масиви Перелик и Карлък, традиционни ливади, кошари и типичен селски ландшафт.", "https://visitsmolyan.bg/wp-content/uploads/2020/10/%D0%9C%D1%83%D0%B3%D0%BB%D0%B0-%D0%BF%D0%BE%D1%82%D1%8A%D0%BD%D0%B0%D0%BB%D0%B0-%D0%B2-%D0%BB%D0%B5%D0%BA%D0%B0-%D0%BC%D1%8A%D0%B3%D0%BB%D0%B0.png", false, "Панорама над село Мугла", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 9 },
                    { 28, "Тракийско скално плато върху риолитов масив над село Мостово, използвано като светилище и вероятен астрономически център; върху повърхността му личат издялани улеи, ямки и останки от култови съоръжения.", "https://www.visitplovdiv.com/sites/default/files/belintash.jpg", false, "Белинташ", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 10 },
                    { 29, "Висока скална кула в близост до Белинташ, в чието било е поставен голям каменен блок; мястото се смята за древно светилище, а до него се стига по стръмни стълби и пътеки с гледки към долината.", "https://upload.wikimedia.org/wikipedia/commons/c/ca/Karadzhov_kamik.jpg", false, "Караджов камък", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 10 },
                    { 30, "Археологически комплекс край едноименното село, включващ скално светилище и мавзолей, свързван с култа към тракийски владетел или Орфей; датира от късната бронзова и ранножелязна епоха.", "https://upload.wikimedia.org/wikipedia/commons/5/59/TatulSanctuaryHill.jpg", false, "Татул", new DateTime(2025, 11, 21, 12, 36, 35, 388, DateTimeKind.Local).AddTicks(152), "7699db7d-964f-4782-8209-d76562e0fece", 10 }
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
