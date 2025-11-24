using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class Edity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37c40eb4-8d10-4e88-b81d-aef401efdae4", "AQAAAAIAAYagAAAAEMWRpkGkZFGFObne2AXo7nOSkyUqj2wKJi8Q3RMJf7wXryClZ5cJ/7pzUEhC7/Q7+g==", "91a561f9-baaa-4775-93cd-ed42ce4edaef" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Карстова пещера в Буйновското ждрело.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460), 12m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Пропастна пещера в Триградското ждрело.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460), 15m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "PublishedOn", "TicketPrice" },
                values: new object[] { "Една от най-красивите благоустроени пещери.", "https://visitsmolyan.bg/wp-content/uploads/2021/04/Пещера-Ухловица.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460), 10m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Карстово ждрело.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Най-дългото ждрело в България.", "https://romantika-bg.com/images/Buinovsko_jdrelo.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Резерват с водопади.", "https://patepisanici.com/wp-content/uploads/2019/01/05-1.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Мраморни скални арки.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Скални фигури край Кърджали.", "https://upload.wikimedia.org/wikipedia/commons/8/80/Kamenna_svatba.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Панорама над Смолян.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Панорама над Смолян.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460), 2m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Маршрут през долината на Въча.", "https://planinka.bg/wp-content/uploads/2024/05/DSCF2704.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "PublishedOn", "TicketPrice" },
                values: new object[] { "Кръгов маршрут към водопадите.", "https://drumivdumi.com/wp-content/uploads/2020/11/ekopyteka.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460), 2m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Висок водопад в Добростан.", "https://drumivdumi.com/wp-content/uploads/2015/07/slivodolsko.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Водопад в Червената стена.", "https://waterfallsbg.info/assets/Samodivskoto.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Каскада в Каньона на водопадите.", "https://drumivdumi.com/wp-content/uploads/2016/08/orfei.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Група естествени езера.", "https://visitsmolyan.bg/wp-content/uploads/2020/11/smolyan-lakes.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Голям язовир.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Планински язовир.", "https://static.pochivka.bg/sights.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Голям биосферен резерват.", "https://static.pochivka.bg/kormisosh.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Защитена зона с водопади.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSiGCZA", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Иглолистна гора.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "2191 м – най-високият в Родопите.", "https://static.pochivka.bg/perelik.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Панорама и кула.", "https://imgrabo.com/pics/guide/20160128144426_93270.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Масивен връх.", "https://imgrabo.com/pics/guide/20170526165250_94251.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Панорамна площадка.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460), 6m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageUrl", "PublishedOn", "TicketPrice" },
                values: new object[] { "Гледка към Смолян.", "https://izbulgaria.com/wp-content/uploads/2021/10/panoramna.jpg", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460), 4m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ImageUrl", "Name", "PublishedOn" },
                values: new object[] { "Високи ридове.", "https://visitsmolyan.bg/wp-content/uploads/2020/10/Mugla-panorama.png", "Панорама над Мугла", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Тракийско светилище.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460), 6m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Скално светилище.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460), 6m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Археологически комплекс.", new DateTime(2025, 11, 22, 23, 3, 51, 624, DateTimeKind.Local).AddTicks(4460), 6m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Карстова пещера в Буйновското ждрело, част от сложна триетажна система с над 10 км галерии, богати сталактити и пещерно жилище от неолита, благоустроена и осветена за туристически посещения.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Пропастна пещера в Триградското ждрело, в която подземна река образува висок водопад, влиза през естествен вход и изчезва в сифони; свързва се с митове за Орфей и слизането му в подземния свят.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "PublishedOn", "TicketPrice" },
                values: new object[] { "Една от най-красивите благоустроени пещери в Родопите, разположена над село Могилица; известна с многоетажни галерии, ледникови форми, синтрови езерца и т.нар. Ледения водопад от бели кристали.", "https://visitsmolyan.bg/wp-content/uploads/2021/04/%D0%9F%D0%B5%D1%89%D0%B5%D1%80%D0%B0-%D0%A3%D1%85%D0%BB%D0%BE%D0%B2%D0%B8%D1%86%D0%B0-%D0%90%D0%B2%D1%82%D0%BE%D1%80-ardaadventures-8.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Дълбоко карстово ждрело по долината на река Триградска, с отвесни скали над 250 м, тясно шосе и множество тунели; едно от най-внушителните дефилета в България и естествен вход към Дяволското гърло.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Най-дългото ждрело в България, образувано от река Буйновска между Ягодина и Тешел; известно е с тесен каньон, впечатляващи скални венци и множество пещери, включително входа на Ягодинската пещера.", "https://romantika-bg.com/images/Buinovsko_jdrelo_IMG_0286_GDstyles.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Резерват по горното течение на река Еленска над Смолян, където екопътека следва поредица от каскадни водопади, дървени мостчета и панорамни площадки сред иглолистни гори и скалисти склонове.", "https://patepisanici.com/wp-content/uploads/2019/01/05-1.jpg?w=2000&h=1200&crop=1", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Големи мраморни арки в рида Чернатица, останки от срутила се пещера, през които минава река Еркюприя; символ на Родопите и защитена местност с туристически маршрути и алпийски маршрути наблизо.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Скални образувания до село Зимзелен край Кърджали, изградени от вулканични туфи, оформени от ерозия в фигури, наподобяващи сватбено шествие; свързани са с местна легенда за нещастна любов.", "https://upload.wikimedia.org/wikipedia/commons/8/80/Kamenna_svatba_-_The_Groom_and_the_Bride.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Скалисто възвишение над Смолян, свързвано с легендите за Орфей; от площадките се разкриват панорамни гледки към езерата, връх Снежанка и долината, популярно място за кратки преходи и залези.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Къса, но ефектна екопътека над Смолян, която води до скален масив, свързан с легенда за мома Невяста; предлага параклис, панорамна площадка с кръст и изгледи към града и околните върхове.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Маркиран маршрут в долината на река Въча, който преминава по стари пътища, мостчета и открити ридове между Девин и Лъки; съчетава горски участъци, панорамни гледки и традиционни родопски селища.", "https://planinka.bg/wp-content/uploads/2024/05/DSCF2704-1024x683.webp", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "PublishedOn", "TicketPrice" },
                values: new object[] { "Кръгов маршрут в едноименния резерват над Смолян, който изкачва дерето на Еленска река по дървени стълби и мостове покрай серия от водопади, естествени скални прагове и стари смърчови гори.", "https://drumivdumi.com/wp-content/uploads/2020/11/0ekopyteka_kanyona_na_vodopadite_0839.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Водопад по река Сливов дол в рида Добростан, част от резерват Червената стена; с обща височина над 45 м и стръмен достъп през букови гори, смятан за един от най-високите в Родопите.", "https://drumivdumi.com/wp-content/uploads/2015/07/1v_nachaloto_kym_vodopad_slivodolsko_padalo_7826.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Живописен водопад в сърцето на резерват Червената стена, достигащ около 50 м височина; заобиколен от стръмни скали и гори, до него се стига по планинска пътека от село Бачково и хижа Марциганица.", "https://waterfallsbg.info/assets/Samodivskoto/f2085632.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Каскаден водопад по един от притоците в Каньона на водопадите, носещ името на Орфей заради живописното си стечение по скалите; посещава се по екопътеката над Смолян в посока Перелик.", "https://drumivdumi.com/wp-content/uploads/2016/08/4canyon_orfej_0608.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Група от естествени ледникови и свлачищни езера, разположени по долината между Снежанка и Смолян; част от тях са запазени, други са превърнати в рибарници и туристически зони край курорта.", "https://visitsmolyan.bg/wp-content/uploads/2020/11/%D0%A1%D0%BC%D0%BE%D0%BB%D1%8F%D0%BD%D1%81%D0%BA%D0%B8-%D0%B5%D0%B7%D0%B5%D1%80%D0%B0-1-scaled.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Голям язовир на река Доспат, разположен на надморска височина около 1200 м; известен със силно разчленено крайбрежие, борови гори, възможности за риболов, водни спортове и лагеруване.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Планински язовир между връх Голям Перелик и Баташкия дял, заобиколен от гъсти иглолистни гори и множество полуострови; популярен за къмпинг, гребане и фотография на спокойни водни пейзажи.", "https://static.pochivka.bg/sights.bgstay.com/images/01/1071/5465119e2e2f7.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Голям ловно-стопански район и биосферен резерват в Централните Родопи, съхраняващ естествени иглолистни гори и богато животинско разнообразие, включително елени, диви свине и кафява мечка.", "https://static.pochivka.bg/sights.bgstay.com/images/02/2748/5a37883ece1b8.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Стръмен варовиков масив над Бачково и Асеновград, обявен за биосферен резерват заради редките си растителни видове, скални местообитания и водопади като Самодивско пръскало и Сливодолското падало.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSiGCZAqUm6xoaBt5IrLzUYiQTSTCuI9KbzQw&s", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Големи масиви от смърчови и борови гори около курорта Пампорово, поддържащи мек планински климат и множество туристически пътеки и ски писти по склоновете на връх Снежанка.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Най-високият връх в Родопите с височина 2191 м, разположен в масива Перелик; на платото му има военни съоръжения, а склоновете са обрасли с иглолистни гори и пасища с панорами към голяма част от планината.", "https://static.pochivka.bg/sights.bgstay.com/images/00/136/541ad01c4ffec.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Знаков връх над Пампорово, висок 1926 м, на който е издигната телевизионна кула с панорамна тераса; център на ски зоната с множество писти и лифтове, достъпен целогодишно по асфалтов път.", "https://imgrabo.com/pics/guide/900x600/20160128144426_93270.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ImageUrl", "PublishedOn" },
                values: new object[] { "Масивен връх в рида Чернатица, издигащ се до 2091 м над морето; известен с панорама към Чудните мостове, Баташкия дял и Рила, както и с туристическите маршрути от хижа Персенк и село Орехово.", "https://imgrabo.com/pics/guide/900x600/20170526165250_94251.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Метална панорамна площадка над ръба на скала при връх Свети Илия над Ягодина, достигаща над 1500 м височина; предлага драматични гледки към Буйновското ждрело и билата на Родопите.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageUrl", "PublishedOn", "TicketPrice" },
                values: new object[] { "Съвременна площадка с метален кръст върху скалата Невястата, до която се стига по екопътека; от нея се открива гледка към Смолян, езерата и връх Снежанка, а наоколо има и въжен парк за атракции.", "https://izbulgaria.com/wp-content/uploads/2021/10/panoramna-ploshtadka-na-ekopateka-neviastata-1024x768.jpg", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ImageUrl", "Name", "PublishedOn" },
                values: new object[] { "Високите поляни и ридове над отдалеченото родопско село Мугла предлагат обширни 360° гледки към планинските масиви Перелик и Карлък, традиционни ливади, кошари и типичен селски ландшафт.", "https://visitsmolyan.bg/wp-content/uploads/2020/10/%D0%9C%D1%83%D0%B3%D0%BB%D0%B0-%D0%BF%D0%BE%D1%82%D1%8A%D0%BD%D0%B0%D0%BB%D0%B0-%D0%B2-%D0%BB%D0%B5%D0%BA%D0%B0-%D0%BC%D1%8A%D0%B3%D0%BB%D0%B0.png", "Панорама над село Мугла", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Тракийско скално плато върху риолитов масив над село Мостово, използвано като светилище и вероятен астрономически център; върху повърхността му личат издялани улеи, ямки и останки от култови съоръжения.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Висока скална кула в близост до Белинташ, в чието било е поставен голям каменен блок; мястото се смята за древно светилище, а до него се стига по стръмни стълби и пътеки с гледки към долината.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "PublishedOn", "TicketPrice" },
                values: new object[] { "Археологически комплекс край едноименното село, включващ скално светилище и мавзолей, свързван с култа към тракийски владетел или Орфей; датира от късната бронзова и ранножелязна епоха.", new DateTime(2025, 11, 22, 22, 56, 5, 515, DateTimeKind.Local).AddTicks(5434), 0m });
        }
    }
}
