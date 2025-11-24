using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class DescChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d6d9867-d902-40fb-8586-ccd63e723b5a", "AQAAAAIAAYagAAAAEHp/CHJbkZ0tWBbEQDEHFXoZQdh1KJLLUrJ4l8txRsX7srQ+/y0EQE9+IZgComL2fA==", "2aa2cf34-9959-4ea9-99c4-e1e53929c61c" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Дяволското гърло е мистична пропастна пещера, известна със своя огромен подземен водопад — най-големият на Балканите. Легендата разказва, че именно тук Орфей е слязъл в подземния свят, за да търси любимата си Евридика. Входната зала е колосална и създава оглушителен тътен от водата, която изчезва в неизследван сифон. Пещерата вдъхновява с драматична атмосфера, величествени скални форми и усещане за древна, сурова мощ.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Дяволското гърло е мистична пропастна пещера, известна със своя огромен подземен водопад — най-големият на Балканите. Легендата разказва, че именно тук Орфей е слязъл в подземния свят, за да търси любимата си Евридика. Входната зала е колосална и създава оглушителен тътен от водата, която изчезва в неизследван сифон. Пещерата вдъхновява с драматична атмосфера, величествени скални форми и усещане за древна, сурова мощ.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Ухловица е една от най-красивите пещери в Родопите, често наричана „подземната фея“. Тя се отличава с кристално бели калцитни форми, каскадни тераси и уникални подземни езера. Най-впечатляващата част е „Сребърният водопад“ — варовикова каскада, която блести при осветяване. Пещерата се достига по стръмни стълби, но усилието си заслужава заради изумителните природни картини.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Триградското ждрело е величествен карстов каньон, чиито високи скали се извисяват над 250 метра. Реката преминава през тясна пропаст, след което потъва в Дяволското гърло. Пътят, който преминава през ждрелото, е един от най-живописните в България — стръмни отвеси, сенчести гори и прохладен въздух. Това място е рай за фотографи, любители на природата и хора, търсещи истинска планинска тишина.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Буйновското ждрело е най-дългото ждрело в България и е известено с уникалната си „Тунелна пещера“, където скалите почти се събират над главите на посетителите. Панорамният път следва реката и разкрива множество природни карти — стръмни отвеси, скални ниши и вековни дървета. Мястото е тихо, свято, усеща се мощната енергия на Родопите и неподправената им красота.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Каньонът на водопадите е природен резерват с над 46 водопада, подредени като каскада в гъста родопска гора. По екопътеката има множество мостове, стълби и панорамни площадки, които позволяват изключително близък досег до природата. Най-известните водопади са Орфей, Райското пръскало и Каскадата. Мястото е магическо — прохладен въздух, мъгла от водни пръски и величествени скали.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Чудните мостове са природно образувани мраморни арки, останали след рухването на древна пещера. Двете огромни „мостови“ структури впечатляват с мащаба си — първата арка е висока над 40 метра. Районът е спокоен, покрит със смърчови гори и е едно от най-емблематичните места в Родопите. Мистично място, изпълнено с легенди и уютна природна атмосфера.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Каменната сватба е група от розово-бели скални фигури, наподобяващи причудливи хора, животни и постройки. Според местната легенда те са превърнати в камък младоженци и гостите на тяхната нещастна сватба. Мястото е силно енергийно, особено при залез, когато слънцето обагря скалите в огнени цветове.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Орфееви скали са панорамен скален масив, свързан в легендите с Орфей. Оттук се открива величествена гледка към Смолян, Пампорово и част от Родопите. Пътеката до скалите е кратка, лесна и изключително приятна. Мястото е тихо, ветровито и повлияно от древните митове и духовност.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Екопътека Невястата е къса, но изключително красива пътека, водеща до панорамна площадка над Смолян. Маршрутът минава през гора, скали и причудливи образувания. Според легендата тук девойка е скочила от скалата, за да избегне насилствен брак. Мястото е романтично, тихо и магнетично.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Екопътеката разкрива уникални панорами към долината на река Въча. Преминава през планински ридове, сенчести гори и красиви гледки към язовири и върхове. Мястото е предпочитано от туристи, които обичат спокойните маршрути без стръмни изкачвания.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Това е една от най-популярните екопътеки в България. Маршрутът е кръгов, преминава през гъсти гори, над дървени мостове и покрай десетки водопади. Най-вълнуваща е гледката към водопад Орфей. Атмосферата е прохладна, свежа и идеална за лятно разхлаждане.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Сливодолското падало е един от най-високите и красиви водопади в Родопите. Пътеката до него минава през свежа гора и малки дървени мостчета. Водопадът се спуска по висока скална стена, а шумът му се чува отдалеч. Мястото е тихо, прохладно и чудесно за разходки.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Според легендите тук са танцували самодиви — и мястото наистина изглежда магично. Водопадът е скрит сред гъста гора, а водните пръски образуват красива мъгла около скалите. Пътеката е лека и много приятна. Мястото е чудесно за снимки и пикник.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Водопад Орфей е част от Каньона на водопадите и се отличава със своето многоетажно падане на водата. Носи името на Орфей заради своята мистична красота. По пътя до него можете да видите множество по-малки каскади. Идеално място за любителите на природата.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Смолянските езера са група от 20 естествени езера, разположени стъпаловидно по склоновете на Родопите. Днес са останали 7, но всеки от тях е уникален — с кристална вода, борови гори наоколо и спокойна атмосфера. Районът е идеален за разходки, пикници и риболов.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Язовир Доспат е един от най-красивите язовири в България. Известен е със своята чиста вода, възможности за риболов, каравани, кемпинг и лодки. Обграден е от гъсти борови гори и предлага невероятни гледки, особено при изгрев и залез.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Широка поляна е любим язовир за риболовци, фотографи и любители на планинската тишина. Околността е покрита с високи борове и криволичещи пътища. Водата е тиха, гладка като огледало. Идеално място за палатки и почивка далеч от шума.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Кормисош е огромен биосферен резерват, дом на мечки, елени, диви кози и редки птици. Районът е див, малко посещаван и запазва автентичната красота на Родопите. Гъсти гори, скалисти била и чист планински въздух го правят идеално място за приключенски туризъм.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Червената стена е биосферен резерват под закрилата на UNESCO. Известен е с уникалната си флора — редки растения, орхидеи, скални образувания и диви животни. Екопътеките минават през каньони, водопади и сенчести гори. Мястото е впечатляващо за любители на природата.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Боровите гори около Пампорово създават усещане за алпийски пейзаж — високи смърчове, чист въздух и приятни туристически маршрути. Районът е подходящ както за летни разходки, така и за зимни спортове. Мястото е спокойно, красиво и леснодостъпно.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Голям Перелик е най-високият връх в Родопите (2191 м). Въпреки че самият връх е в зона с ограничен достъп, районът около него предлага невероятни гледки към планинските хребети. Маршрутите до хижа Перелик и околните места са сред най-красивите в Родопите.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Снежанка е известен със своята телевизионна кула — символ на Пампорово. На върха има панорамна тераса, откъдето се виждат десетки километри разстояние. Мястото е достъпно с лифт и е сред най-посещаваните върхове в Родопите.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Голям Персенк е един от най-красивите върхове в Родопите. Известен е със стръмните си скални склонове и великолепните гледки към околните ридове. Районът е спокоен, изпълнен с диви билки, цветя и горски аромати.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Орлово око е панорамна площадка, разположена на ръба на скален масив над Ягодина. Построена е върху метална конструкция, която се издига над пропастта и позволява 360° гледка към Родопите. Мястото е едно от най-популярните за снимки в България.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Площадката предлага чудесна гледка към град Смолян, язовирите и върховете в района. Мястото е достъпно по лека екопътека и е любимо за туристи, които искат да посрещнат изгрев или залез от високо.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Панорамните ридове над село Мугла разкриват суровата красота на Родопите. Районът е тих, без туристически тълпи, подходящ за любители на фотография, преходи и спокойствие.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Белинташ е едно от най-известните тракийски светилища. Платото е покрито с издялани скални улеи и култови знаци, чието предназначение и днес остава загадка. Мястото е известно със силната си енергия и панорамните гледки към Родопите..", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Караджов камък е величествена скална арка, разположена на върха на отвесен каньон. До него води древна пътека. Според легендите траките са го използвали като жертвено място. Изгледът от върха е драматичен и незабравим.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Татул е древно тракийско светилище, свързвано с култа към Орфей. Има уникална архитектура — монолитна скала, оформена като саркофаг, и култов комплекс около нея. Мястото носи атмосфера на древна духовност и е сред най-значимите археологически обекти в Родопите.", new DateTime(2025, 11, 24, 20, 23, 29, 515, DateTimeKind.Local).AddTicks(4664) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Карстова пещера в Буйновското ждрело.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Пропастна пещера в Триградското ждрело.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Една от най-красивите благоустроени пещери.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Карстово ждрело.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Най-дългото ждрело в България.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Резерват с водопади.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Мраморни скални арки.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Скални фигури край Кърджали.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Панорама над Смолян.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Панорама над Смолян.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Маршрут през долината на Въча.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Кръгов маршрут към водопадите.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Висок водопад в Добростан.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Водопад в Червената стена.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Каскада в Каньона на водопадите.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Група естествени езера.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Голям язовир.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Планински язовир.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Голям биосферен резерват.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Защитена зона с водопади.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Иглолистна гора.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "2191 м – най-високият в Родопите.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Панорама и кула.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Масивен връх.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Панорамна площадка", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Гледка към Смолян.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Високи ридове.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Тракийско светилище.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Скално светилище.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "PublishedOn" },
                values: new object[] { "Археологически комплекс.", new DateTime(2025, 11, 24, 19, 54, 45, 216, DateTimeKind.Local).AddTicks(1481) });
        }
    }
}
