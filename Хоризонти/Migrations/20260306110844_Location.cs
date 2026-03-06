using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class Location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "790e9a48-c449-41c0-9e1c-ff9f4d840ccf", "AQAAAAIAAYagAAAAEAe3j5PsaW2uVH5IjOTy50xsCZNY93kN4lae0DXgVBQAuMVW0sxHOM2z7Qjx5qdWcg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46546dc1-c2ef-4911-8ac9-de796b62e3ec", "AQAAAAIAAYagAAAAEFxZ699IUE2d81bphhJECaTt7t44xo6jp6jU4T72xxOZdpRcxt+NcLrYiNSNc8m80A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15af93d5-600a-47de-9a14-8cf3ee47ee93", "AQAAAAIAAYagAAAAECApCrOiOELw2P562rLoZMZMONqCUZFKo6ImwPCe0PieQHR8NWiUGEsLiLCmrgZivg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c9a02a8-5291-4e9b-a23f-24921a93ae26", "AQAAAAIAAYagAAAAEMyAti/1vwkLIN3/+GZwjZ4e7nWk2b/VQ28snalF9rz+gtVkdLTQWQJR+AzYKWo3wg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0a5233c-0a1f-4fb0-8166-01412edce639", "AQAAAAIAAYagAAAAEPnxd3QPmHlls6Tp+7Iz7puuULWBYyNib91cmpGyx6vdz8VX0SAbzvJW/bjO0xT6wA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c08d4fa-c0f2-4e35-b863-7ce0970627b0", "AQAAAAIAAYagAAAAEMS27IaJ1MKu+Sxpf3qrfCnZOC47o7NdqNw71dxxoZ8clKpG2RJYe3KCgUMN+pzowA==" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Location" },
                values: new object[] { "Ягодинската пещера е една от най-дългите и красиви пещери в България, разположена в живописното Буйновско ждрело в Родопите. Общата ѝ дължина е над 10 километра, но за посетители е достъпна специално изградена туристическа част. Пещерата впечатлява с разнообразни сталактити, сталагмити, сталактони и уникални скални форми, образувани в продължение на милиони години.", "Ягодинската пещера се намира в Западните Родопи, на около 3 км южно от село Ягодина и близо до Буйновското ждрело. Районът е част от Триградския карстов район и е лесно достъпен по асфалтов път." });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Location" },
                values: new object[] { "Дяволското гърло е една от най-мистичните пещери в България, известна със своя огромен подземен водопад.", "Пещерата Дяволското гърло се намира в Триградското ждрело в Западните Родопи, на около 2 км от село Триград и на 25 км от град Девин." });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Location" },
                values: new object[] { "Ухловица е една от най-красивите пещери в Родопите, известна със своите калцитни образувания.", "Пещера Ухловица се намира близо до село Могилица в Западните Родопи, на около 37 км южно от град Смолян." });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: "Триградското ждрело се намира в Западните Родопи между селата Триград и Девин и е издълбано от река Триградска.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: "Буйновското ждрело се намира в Западните Родопи между селата Тешел и Ягодина и следва течението на река Буйновска.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Location",
                value: "Каньонът на водопадите се намира в местността Сосковчето на около 3 км южно от град Смолян.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Location",
                value: "Чудните мостове се намират в Западните Родопи, на около 16 км от село Забърдо и приблизително 50 км от град Пловдив.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Location",
                value: "Каменната сватба се намира в Източните Родопи, на около 5 км източно от град Кърджали, близо до село Зимзелен.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "Орфееви скали се намират в Източните Родопи над язовир Студен кладенец, близо до град Кърджали.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Location",
                value: "Екопътека Невястата се намира над град Смолян в Западните Родопи и започва близо до квартал Райково.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                column: "Location",
                value: "Екопътеката Девин – Лъки се намира в Родопите и преминава през красиви горски райони близо до град Девин.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                column: "Location",
                value: "Екопътека Каньонът на водопадите се намира в местността Сосковчето на около 3 км южно от град Смолян.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                column: "Location",
                value: "Сливодолското падало се намира в Родопите, на около 15 км южно от град Асеновград, в защитената местност Сливодолско падало.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                column: "Location",
                value: "Самодивското пръскало се намира в Родопите близо до град Девин, сред гъсти гори и планински склонове.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                column: "Location",
                value: "Водопад Орфей се намира по маршрута на екопътеката Каньонът на водопадите в местността Сосковчето край град Смолян.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                column: "Location",
                value: "Смолянските езера се намират в северната част на град Смолян, разположени по склоновете на Родопите на височина около 1500 метра.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                column: "Location",
                value: "Язовир Доспат се намира в Западните Родопи между град Доспат и село Сърница и е един от най-големите язовири в планината.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                column: "Location",
                value: "Язовир Широка поляна се намира в Западните Родопи, на около 30 км от град Батак, заобиколен от гъсти борови гори.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                column: "Location",
                value: "Резерват Кормисош се намира в централната част на Родопите и е част от защитените територии на България, известен със своите обширни гори и богато биоразнообразие.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                column: "Location",
                value: "Резерват Червената стена се намира в Западните Родопи близо до град Асеновград и е един от най-известните биосферни резервати в България.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                column: "Location",
                value: "Боровите гори се намират около курорта Пампорово в Западните Родопи, близо до град Смолян, и са известни със своя чист въздух и красиви планински пейзажи.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                column: "Location",
                value: "Връх Голям Перелик се намира в централната част на Родопите и е най-високият връх в планината с височина 2191 метра.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                column: "Location",
                value: "Връх Снежанка се намира над курорта Пампорово в Западните Родопи и е известен със своята телевизионна кула и панорамна площадка.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                column: "Location",
                value: "Връх Голям Персенк се намира в Родопския дял Чернатица и е един от най-високите върхове в този район.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                column: "Location",
                value: "Панорамната площадка Орлово око се намира над Буйновското ждрело в Западните Родопи на височина около 1560 метра, близо до село Ягодина.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                column: "Location",
                value: "Панорамната площадка Невястата се намира над град Смолян в Западните Родопи и предлага гледка към града и околните планински върхове.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                column: "Location",
                value: "Панорамните ридове над село Мугла се намират в Западните Родопи, област Смолян, и разкриват красиви гледки към планинските долини.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                column: "Location",
                value: "Белинташ се намира в Западните Родопи близо до село Мостово и е едно от най-големите тракийски светилища в България.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                column: "Location",
                value: "Караджов камък се намира в Родопите близо до село Мостово, недалеч от тракийското светилище Белинташ.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                column: "Location",
                value: "Тракийското светилище Татул се намира в Източните Родопи близо до село Татул, на около 15 км от град Момчилград.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "766dd66e-5580-42ad-a12d-10652c0053bc", "AQAAAAIAAYagAAAAEOf+DW+k214AxS3mrLsVI5uTvsLVmrFRuPTbQ6sI9qap0prrbLm2NfH1LPPG76W+Sg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f975cdc1-1893-4f4d-9400-2646ccdaf4d7", "AQAAAAIAAYagAAAAEALL2BWH97+zP/v/nfu6Ii2KHs0D7z5XwvvRmGCqRDqnxx0h9XfEJWVRgnz1VWITFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2dcf8a3c-3a5d-409e-a1e6-3b01363205c8", "AQAAAAIAAYagAAAAEKhUjqvNLaZskCHNwsmHyDLsYZJ6S7IWbfbBZcIMpBIchNg7qZt1onJjudxMzxZFoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ccbc6e2b-1944-49e5-bc98-06f88817c005", "AQAAAAIAAYagAAAAEAQyP8p6bRXoDNh20Y3KpXxcd2w+0qfbiv72Yf/wx1pYBv6pRgy/i6ouLwokLb/9pQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91f76700-d5ed-4ea6-a3d0-2086ecd414ca", "AQAAAAIAAYagAAAAEIs7neW+ovPUQWr07eIaKQlmCSFgoElh3noeFMTw8gZeOI0U3Y/U6Zyu+oMrnMhUig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39d28dde-6300-4d80-8085-5e66152e5a5a", "AQAAAAIAAYagAAAAEApyBU+9yrym7h1oVU9PVw9btP44d52KWaECGpOzayiBQ854vNFRpcnWp9c2VX/HfA==" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Location" },
                values: new object[] { "Дяволското гърло е мистична пропастна пещера, известна със своя огромен подземен водопад — най-големият на Балканите. Легендата разказва, че именно тук Орфей е слязъл в подземния свят, за да търси любимата си Евридика. Входната зала е колосална и създава оглушителен тътен от водата, която изчезва в неизследван сифон. Пещерата вдъхновява с драматична атмосфера, величествени скални форми и усещане за древна, сурова мощ.", "Ягодинската пещера е разположена в Родопите, само на 3 км от село Ягодина." });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Location" },
                values: new object[] { "Дяволското гърло е мистична пропастна пещера, известна със своя огромен подземен водопад — най-големият на Балканите. Легендата разказва, че именно тук Орфей е слязъл в подземния свят, за да търси любимата си Евридика. Входната зала е колосална и създава оглушителен тътен от водата, която изчезва в неизследван сифон. Пещерата вдъхновява с драматична атмосфера, величествени скални форми и усещане за древна, сурова мощ.", "Област Смолян, Западни Родопи, на по-малко от 2км от Триград, на 25км от Девин и на 34км от Доспат" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Location" },
                values: new object[] { "Ухловица е една от най-красивите пещери в Родопите, често наричана „подземната фея“. Тя се отличава с кристално бели калцитни форми, каскадни тераси и уникални подземни езера. Най-впечатляващата част е „Сребърният водопад“ — варовикова каскада, която блести при осветяване. Пещерата се достига по стръмни стълби, но усилието си заслужава заради изумителните природни картини.", "Ухловица е село в Южна България. То се намира в община Смолян, област Смолян" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: "Започва на около 1,5 km северно от село Триград...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: "Буйновското ждрело се намира в Родопите...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Location",
                value: "Каньонът на водопадите се намира в Родопите...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Location",
                value: "Чудните мостове са разположени на около 16 км...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Location",
                value: "Намира се на 5 км източно от центъра на град Кърджали...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "Орфееви скали се намира в сърцето на Родопите...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Location",
                value: "Екопътека “Невястата” се намира в сърцето на Родопи...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 11,
                column: "Location",
                value: "В Родопите, на около 3км от центъра на град Девин...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 12,
                column: "Location",
                value: "Само на 2-3 км от Смолян...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 13,
                column: "Location",
                value: "Водопадът се намира на около 15 километра южно от Асеновград");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 14,
                column: "Location",
                value: "В Родопите, в близост до град Девин...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 15,
                column: "Location",
                value: "Водопад Орфей се намира в местност Сосковчето...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 16,
                column: "Location",
                value: "В покрайнините на град Смолян...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 17,
                column: "Location",
                value: "Разположен в посока северозапад – югоизток...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 18,
                column: "Location",
                value: "Язовир Широка поляна се намира в борова гора...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 19,
                column: "Location",
                value: "Разположен в Родопите");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 20,
                column: "Location",
                value: "В сърцето на Родопите...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 21,
                column: "Location",
                value: "Намира се близо до зимния курорт...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 22,
                column: "Location",
                value: "Връх Голям Перелик е най-високата точка на Родопите...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 23,
                column: "Location",
                value: "Намира се в Родопи, близо до Пампорово...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 24,
                column: "Location",
                value: "Най-високият в Родопския дял Чернатица...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 25,
                column: "Location",
                value: "Орлово око се намира в Западните Родопи...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 26,
                column: "Location",
                value: "Намира се над град Смолян...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 27,
                column: "Location",
                value: "В Западните Родопи, област Смолян.");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 28,
                column: "Location",
                value: "Белинташ се намира в Родопите...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 29,
                column: "Location",
                value: "Намира се в близост до село Мостово...");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 30,
                column: "Location",
                value: "Татул се намира в м. Кая Башъ...");
        }
    }
}
