using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Horizons.Data.Models;

namespace Horizons.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Destination> Destinations { get; set; } = null!;
        public DbSet<UserDestination> UserDestinations { get; set; } = null!;
        public DbSet<Terrain> Terrains { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<Rating> Ratings { get; set; } = null!;   // ← Остава само това
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserDestination>()
                .HasKey(ud => new { ud.UserId, ud.DestinationId });

            builder.Entity<Destination>()
                .HasOne(d => d.Publisher)
                .WithMany()
                .HasForeignKey(d => d.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);

            const string adminId = "7699db7d-964f-4782-8209-d76562e0fece";

            var defaultUser = new IdentityUser
            {
                Id = adminId,
                UserName = "admin@horizons.com",
                NormalizedUserName = "ADMIN@HORIZONS.COM",
                Email = "admin@horizons.com",
                NormalizedEmail = "ADMIN@HORIZONS.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var passwordHasher = new PasswordHasher<IdentityUser>();
            defaultUser.PasswordHash = passwordHasher.HashPassword(defaultUser, "Admin123!");

            builder.Entity<IdentityUser>().HasData(defaultUser);


            builder.Entity<Terrain>().HasData(
                new Terrain { Id = 1, Name = "Пещера" },
                new Terrain { Id = 2, Name = "Ждрело / Каньон" },
                new Terrain { Id = 3, Name = "Скални образувания" },
                new Terrain { Id = 4, Name = "Екопътека" },
                new Terrain { Id = 5, Name = "Водопад" },
                new Terrain { Id = 6, Name = "Езеро" },
                new Terrain { Id = 7, Name = "Гора / Резерват" },
                new Terrain { Id = 8, Name = "Връх" },
                new Terrain { Id = 9, Name = "Панорамна площадка" },
                new Terrain { Id = 10, Name = "Светилище / Историческо място" }
            );


            var now = DateTime.Now;

            // ПЕЩЕРИ
            builder.Entity<Destination>().HasData(

                new Destination
                {
                    Id = 1,
                    Name = "Ягодинска пещера",
                    Description = "Дяволското гърло е мистична пропастна пещера, известна със своя огромен подземен водопад — най-големият на Балканите. Легендата разказва, че именно тук Орфей е слязъл в подземния свят, за да търси любимата си Евридика. Входната зала е колосална и създава оглушителен тътен от водата, която изчезва в неизследван сифон. Пещерата вдъхновява с драматична атмосфера, величествени скални форми и усещане за древна, сурова мощ.",
                    ImageUrl = "https://th.bing.com/th/id/R.0f6956b90ab335551ef69581b5fb249c?rik=isKYGcW46QN7Wg&riu=http%3a%2f%2fwww.torre-bg.com%2fimages%2ftravel_offer_images%2fsm.jpg&ehk=A4tcxFAyfCoYpcrgn%2bBHb5mJLTDytaoeZw4chEgjM7U%3d&risl=&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 1,
                    PublishedOn = now,
                    TicketPrice = 12m,
                    IsDeleted = false,
                    Location = "Ягодинската пещера е разположена в Родопите, само на 3 км от село Ягодина.",
                    LocationUrl = "/images/ЯП.png"
                },
                new Destination
                {
                    Id = 2,
                    Name = "Пещера Дяволското гърло",
                    Description = "Дяволското гърло е мистична пропастна пещера, известна със своя огромен подземен водопад — най-големият на Балканите. Легендата разказва, че именно тук Орфей е слязъл в подземния свят, за да търси любимата си Евридика. Входната зала е колосална и създава оглушителен тътен от водата, която изчезва в неизследван сифон. Пещерата вдъхновява с драматична атмосфера, величествени скални форми и усещане за древна, сурова мощ.",
                    ImageUrl = "https://th.bing.com/th/id/R.069ba412d447d50a586d1836cc84c66f?rik=dN5O%2b4J3ghtCwA&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 1,
                    PublishedOn = now,
                    TicketPrice = 15m,
                    IsDeleted = false,
                    Location = "Област Смолян, Западни Родопи, на по-малко от 2км от Триград, на 25км от Девин и на 34км от Доспат",
                    LocationUrl = "/images/ДГ.png"
                },
                new Destination
                {
                    Id = 3,
                    Name = "Ухловица",
                    Description = "Ухловица е една от най-красивите пещери в Родопите, често наричана „подземната фея“. Тя се отличава с кристално бели калцитни форми, каскадни тераси и уникални подземни езера. Най-впечатляващата част е „Сребърният водопад“ — варовикова каскада, която блести при осветяване. Пещерата се достига по стръмни стълби, но усилието си заслужава заради изумителните природни картини.",
                    ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.w6SkxFzGIvY4ESdZwcs3mwHaE3?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 1,
                    PublishedOn = now,
                    TicketPrice = 10m,
                    IsDeleted = false,
                    Location = "Ухловица е село в Южна България. То се намира в община Смолян, област Смолян",
                    LocationUrl = "/images/У.png"
                },

                // ЖДРЕЛА / КАНЬОНИ
                new Destination
                {
                    Id = 4,
                    Name = "Триградско ждрело",
                    Description = "Триградското ждрело е величествен карстов каньон, чиито високи скали се извисяват над 250 метра. Реката преминава през тясна пропаст, след което потъва в Дяволското гърло. Пътят, който преминава през ждрелото, е един от най-живописните в България — стръмни отвеси, сенчести гори и прохладен въздух. Това място е рай за фотографи, любители на природата и хора, търсещи истинска планинска тишина.",
                    ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.XcL7FSfxMczbaMFwc4YEPgHaJ4?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 2,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Започва на около 1,5 km северно от село Триград на около 1180 m н.в., където Триградска река влиза в пещерата Дяволското гърло и 530 m след това излиза като голям карстов извор. ",
                    LocationUrl = "/images/ТЖ.png"
                },
                new Destination
                {
                    Id = 5,
                    Name = "Буйновско ждрело",
                    Description = "Буйновското ждрело е най-дългото ждрело в България и е известено с уникалната си „Тунелна пещера“, където скалите почти се събират над главите на посетителите. Панорамният път следва реката и разкрива множество природни карти — стръмни отвеси, скални ниши и вековни дървета. Мястото е тихо, свято, усеща се мощната енергия на Родопите и неподправената им красота.",
                    ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.LLbqun3yJfkPrZZD7Ie6xAHaDC?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 2,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Буйновското ждрело се намира в Родопите, северно от село Буйново, община Борино. Проломът следва течението на Буйновска река, като е достъпен за разходка от двете му страни, а най-близката голяма община е Доспат. ",
                    LocationUrl = "/images/БЖ.png"
                },
                new Destination
                {
                    Id = 6,
                    Name = "Каньонът на водопадите",
                    Description = "Каньонът на водопадите е природен резерват с над 46 водопада, подредени като каскада в гъста родопска гора. По екопътеката има множество мостове, стълби и панорамни площадки, които позволяват изключително близък досег до природата. Най-известните водопади са Орфей, Райското пръскало и Каскадата. Мястото е магическо — прохладен въздух, мъгла от водни пръски и величествени скали.",
                    ImageUrl = "https://th.bing.com/th/id/R.a5291d2e52f73c8001355d5eb15368ca?rik=R0DvhlMQg3M4bA&riu=http%3a%2f%2fwww.bestplacesinbulgaria.com%2fwp-content%2fuploads%2f2016%2f07%2fthe-waterfall-canyon-tourist-eco-route-04.jpg&ehk=oCv5V7rhnBFogS4%2fm7xRsyWvJs0xKlq0uAwRHdAb%2fZI%3d&risl=&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 2,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Каньонът на водопадите се намира в Родопите, близо до град Смолян. За да стигнете до него, трябва да поемете по пътя от Смолян за село Мугла и да потърсите отбивка вдясно, след стара автобаза или бетонновъзел. ",
                    LocationUrl = "/images/КВ.png"
                },

                // СКАЛНИ ОБРАЗУВАНИЯ
                new Destination
                {
                    Id = 7,
                    Name = "Чудните мостове",
                    Description = "Чудните мостове са природно образувани мраморни арки, останали след рухването на древна пещера. Двете огромни „мостови“ структури впечатляват с мащаба си — първата арка е висока над 40 метра. Районът е спокоен, покрит със смърчови гори и е едно от най-емблематичните места в Родопите. Мистично място, изпълнено с легенди и уютна природна атмосфера.",
                    ImageUrl = "https://th.bing.com/th/id/R.b048105f8f39b372ffdea8dbcf05c795?rik=FCc9PiWL7rUe5Q&riu=http%3a%2f%2fimgrabo.com%2fpics%2fguide%2f900x600%2f20160601155206_11652.jpeg&ehk=DaVIqKNWclj1HLtnZ9PETVjw7xvfpNsSMMmVTryhjsE%3d&risl=&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 3,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Чудните мостове са разположени на около 16 км от главния път Асеновград – Смолян. Малко преди Чепеларе, идвайки от Асеновград вдясно ще видите указателна табела сочеща към Чудните мостове. С кола това разстояние се пропътува за около 20-25 мин.",
                    LocationUrl = "/images/ЧМ.png"
                },
                new Destination
                {
                    Id = 8,
                    Name = "Каменната сватба",
                    Description = "Каменната сватба е група от розово-бели скални фигури, наподобяващи причудливи хора, животни и постройки. Според местната легенда те са превърнати в камък младоженци и гостите на тяхната нещастна сватба. Мястото е силно енергийно, особено при залез, когато слънцето обагря скалите в огнени цветове.",
                    ImageUrl = "https://th.bing.com/th/id/R.dac78f30028a402c35f83f7c13014156?rik=ai36YaI2926Wgg&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 3,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Намира  се на 5 км източно от центъра на град Кърджали, край село Зимзелен. Разположен е в Източни родопи",
                    LocationUrl = "/images/ВС.png"
                },
                new Destination
                {
                    Id = 9,
                    Name = "Орфееви скали",
                    Description = "Орфееви скали са панорамен скален масив, свързан в легендите с Орфей. Оттук се открива величествена гледка към Смолян, Пампорово и част от Родопите. Пътеката до скалите е кратка, лесна и изключително приятна. Мястото е тихо, ветровито и повлияно от древните митове и духовност.",
                    ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.E3gs9mp6NNpTDsT5a8ZVjgHaE8?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 3,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Орфееви скали се намира в сърцето на Родопите, недалеч от курортен комплекс Пампорово. Разположени са под самия връх, на няколко стотин метра разстояние",
                    LocationUrl = "/images/ОС.png"
                },

                // ЕКОПЪТЕКИ
                new Destination
                {
                    Id = 10,
                    Name = "Екопътека Невястата",
                    Description = "Екопътека Невястата е къса, но изключително красива пътека, водеща до панорамна площадка над Смолян. Маршрутът минава през гора, скали и причудливи образувания. Според легендата тук девойка е скочила от скалата, за да избегне насилствен брак. Мястото е романтично, тихо и магнетично.",
                    ImageUrl = "https://th.bing.com/th/id/R.0a050afe7b3736527938ed15d7e9a03d?rik=57SHvi48b7i2bw&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 4,
                    PublishedOn = now,
                    TicketPrice = 2m,
                    IsDeleted = false,
                    Location = "Екопътека “Невястата” се намира в сърцето на Родопи, точно по средата на пътя между Смолян и Пампорово. Разположена е на 8.7 км от Смолян и на 8.9 кмот Пампорово.",
                    LocationUrl = "/images/Н.png"
                },
                new Destination
                {
                    Id = 11,
                    Name = "Екопътека Девин – Лъки",
                    Description = "Екопътеката разкрива уникални панорами към долината на река Въча. Преминава през планински ридове, сенчести гори и красиви гледки към язовири и върхове. Мястото е предпочитано от туристи, които обичат спокойните маршрути без стръмни изкачвания.",
                    ImageUrl = "https://i.pinimg.com/originals/7a/ea/e5/7aeae5868a2c405cb35e18f18af472ce.jpg",
                    PublisherId = adminId,
                    TerrainId = 4,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "В Родопите, на около 3км от центъра на град Девин, Смолянска област, на 45км от Смолян, на 40км от Доспат",
                    LocationUrl = "/images/ЕДЛ.png"
                },
                new Destination
                {
                    Id = 12,
                    Name = "Екопътека Каньонът на водопадите",
                    Description = "Това е една от най-популярните екопътеки в България. Маршрутът е кръгов, преминава през гъсти гори, над дървени мостове и покрай десетки водопади. Най-вълнуваща е гледката към водопад Орфей. Атмосферата е прохладна, свежа и идеална за лятно разхлаждане.",
                    ImageUrl = "https://th.bing.com/th/id/R.9f1c32a1258db100a6f29964c02ff682?rik=oHJQwPzmxk2tYQ&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 4,
                    PublishedOn = now,
                    TicketPrice = 2m,
                    IsDeleted = false,
                    Location = "Само на 2-3 км от Смолян, по пътя за село Мугла е изградена красивата екопътека Каньонът на водопадите",
                    LocationUrl = "/images/ЕКВ.png"
                },

                // ВОДОПАДИ
                new Destination
                {
                    Id = 13,
                    Name = "Сливодолското падало",
                    Description = "Сливодолското падало е един от най-високите и красиви водопади в Родопите. Пътеката до него минава през свежа гора и малки дървени мостчета. Водопадът се спуска по висока скална стена, а шумът му се чува отдалеч. Мястото е тихо, прохладно и чудесно за разходки.",
                    ImageUrl = "https://th.bing.com/th/id/R.ddeeca6d4f5ce0ec0204b62cc8e37980?rik=25fdGAogwznqjw&riu=http%3a%2f%2fblog.hotel-extreme.bg%2fwp-content%2fuploads%2f2017%2f06%2f6_Fotor1400%d0%bb%d0%be%d0%b3%d0%be-min-1068x600.jpg&ehk=WkEtKlbiCqR1bwRIKog51GgKMwxRCKgwFRsxHPecX8g%3d&risl=&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 5,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Водопадът се намира на около 15 километра южно от Асеновград",
                    LocationUrl = "/images/ВСПП.png"
                },
                new Destination
                {
                    Id = 14,
                    Name = "Самодивско пръскало",
                    Description = "Според легендите тук са танцували самодиви — и мястото наистина изглежда магично. Водопадът е скрит сред гъста гора, а водните пръски образуват красива мъгла около скалите. Пътеката е лека и много приятна. Мястото е чудесно за снимки и пикник.",
                    ImageUrl = "https://tse2.mm.bing.net/th/id/OIP.CO4dsfPS4jbawx7C25h4eQAAAA?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 5,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "в Родопите, в близост до град Девин, на 15 мин от маршрута на екопътека Струилица-Калето-Лъката, Смолянска област, на 40км от Доспат, на 45км от Смолян",
                    LocationUrl = "/images/ВСП.png"
                },
                new Destination
                {
                    Id = 15,
                    Name = "Водопад Орфей",
                    Description = "Водопад Орфей е част от Каньона на водопадите и се отличава със своето многоетажно падане на водата. Носи името на Орфей заради своята мистична красота. По пътя до него можете да видите множество по-малки каскади. Идеално място за любителите на природата.",
                    ImageUrl = "https://th.bing.com/th/id/R.5471ea23b3474a4421aca6f30071e691?rik=9xyjKKpLceVaFQ&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 5,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Водопад Орфей се намира в местност Сосковчето, област Смолян, на 5 км от града, като е част от екопътека Каньона на водопадите.",
                    LocationUrl = "/images/ВО.png"
                },

                // ЕЗЕРА
                new Destination
                {
                    Id = 16,
                    Name = "Смолянски езера",
                    Description = "Смолянските езера са група от 20 естествени езера, разположени стъпаловидно по склоновете на Родопите. Днес са останали 7, но всеки от тях е уникален — с кристална вода, борови гори наоколо и спокойна атмосфера. Районът е идеален за разходки, пикници и риболов.",
                    ImageUrl = "https://tse3.mm.bing.net/th/id/OIP.DN8OOsa-_uZWXD2EQLyFkgHaFj?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 6,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "В покрайнините на град Смолян, пръснати по левия склон на долината на черна река, се намират известните Смолянски езера. ",
                    LocationUrl = "/images/СЕ.png"
                },
                new Destination
                {
                    Id = 17,
                    Name = "Язовир Доспат",
                    Description = "Язовир Доспат е един от най-красивите язовири в България. Известен е със своята чиста вода, възможности за риболов, каравани, кемпинг и лодки. Обграден е от гъсти борови гори и предлага невероятни гледки, особено при изгрев и залез.",
                    ImageUrl = "https://tse2.mm.bing.net/th/id/OIP.WkpaLcOORed2Oc25sw9rRQHaFj?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 6,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Разположен в посока северозапад – югоизток в землищата на градовете Доспат и Сърница, които са свързани с живописен път, минаващ по североизточния му бряг.",
                    LocationUrl = "/images/ЯД.png"
                },
                new Destination
                {
                    Id = 18,
                    Name = "Язовир Широка поляна",
                    Description = "Широка поляна е любим язовир за риболовци, фотографи и любители на планинската тишина. Околността е покрита с високи борове и криволичещи пътища. Водата е тиха, гладка като огледало. Идеално място за палатки и почивка далеч от шума.",
                    ImageUrl = "https://th.bing.com/th/id/R.3d8cc2eb89f0e6b7b09f5a80e9645555?rik=KH2XtILVhMcRxA&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 6,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Язовир Широка поляна се намира в борова гора на надморска височина 1500 м в Западните Родопи, на около 30 км от Батак.",
                    LocationUrl = "/images/ЯШ.png"
                },

                // ГОРИ / РЕЗЕРВАТИ
                new Destination
                {
                    Id = 19,
                    Name = "Резерват Кормисош",
                    Description = "Кормисош е огромен биосферен резерват, дом на мечки, елени, диви кози и редки птици. Районът е див, малко посещаван и запазва автентичната красота на Родопите. Гъсти гори, скалисти била и чист планински въздух го правят идеално място за приключенски туризъм.",
                    ImageUrl = "https://th.bing.com/th/id/R.1bddc5bf1178275fa5ceed3a41b5ba7b?rik=E5tlQ55qqhUTZw&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 7,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Разположен в Резерват Планинският масив на Родопите",
                    LocationUrl = "/images/ЯП.png"
                },
                new Destination
                {
                    Id = 20,
                    Name = "Резерват Червената стена",
                    Description = "Червената стена е биосферен резерват под закрилата на UNESCO. Известен е с уникалната си флора — редки растения, орхидеи, скални образувания и диви животни. Екопътеките минават през каньони, водопади и сенчести гори. Мястото е впечатляващо за любители на природата.",
                    ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.FgtZsnzP3v-JbSbsPskOfAHaE8?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 7,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "В сърцето на Родопите, в долината на река Чепеларска и по планинския рид Добростан.",
                    LocationUrl = "/images/ЧС.png"
                },
                new Destination
                {
                    Id = 21,
                    Name = "Борова гора край Пампорово",
                    Description = "Боровите гори около Пампорово създават усещане за алпийски пейзаж — високи смърчове, чист въздух и приятни туристически маршрути. Районът е подходящ както за летни разходки, така и за зимни спортове. Мястото е спокойно, красиво и леснодостъпно.",
                    ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.1eT0klYEsE8Vyn0m_PckzgHaFj?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 7,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Намира се близо да зимния курорт на няколко километра от град Смолян",
                    LocationUrl = "/images/БГ.png"
                },

                // ВЪРХОВЕ
                new Destination
                {
                    Id = 22,
                    Name = "Връх Голям Перелик",
                    Description = "Голям Перелик е най-високият връх в Родопите (2191 м). Въпреки че самият връх е в зона с ограничен достъп, районът около него предлага невероятни гледки към планинските хребети. Маршрутите до хижа Перелик и околните места са сред най-красивите в Родопите.",
                    ImageUrl = "https://www.bestplacesinbulgaria.com/wp-content/uploads/2016/03/golyam_perelik_02.jpg",
                    PublisherId = adminId,
                    TerrainId = 8,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Връх Голям Перелик е най-високата точка на Родопите и се намира в най-западната част на планината.\r\nДостъп:\r\nДо подножието на върха се стига с кола до хижа Перелик, а оттам пеша за около 40-45 минути.\r\nДостъпът до самия връх Голям Перелик е забранен заради военно поделение.\r\nНай-близкият достъпен връх, до който може да се стигне, е Малък Перелик или Широколъшки снежник.\r\nАлтернативни маршрути:\r\nОт хижа Перелик има маркирани туристически маршрути до връх Широколъшки снежник, село Мугла, Гела и други интересни места.\r\nСъщо така, от хижата могат да се посетят и други забележителности като пещера Ледницата, Каньона на водопадите и пещера Дяволското гърло.\r\nГледки: От района на Перелик се откриват красиви панорамни гледки към Смолян и цялата Родопа планина. \r\nВръх Голям Перелик - Туристически пътеводител на Смолян\r\nВАЖНА ИНФОРМАЦИЯ Същинският връх Голям Перелик попада в зоната на секретно военно поделение, разположено в района. Достъпът до нег...\r\n\r\nvisitsmolyan.bg\r\n\r\nНай-високата точка в Родопите е връх Голям Перелик ...\r\n18.08.2024 г. — Най-високата точка в Родопите е връх Голям Перелик (2191) м. Той се намира на територията на военно поделение и достъ...\r\n\r\n\r\nFacebook·Божидар Савов\r\n\r\n№85 Родопи - връх Голям Перелик - 100 обекта\r\n21.12.2012 г. — Голям Перелик е най-високият връх в Родопите. Намира се на 19 км западно от Смолян. С него (2191 м) Родопите се нареж...\r\n\r\n100obekta.com\r\n\r\nПоказване на всички\r\n",
                    LocationUrl = "/images/ПЕР.png"
                },
                new Destination
                {
                    Id = 23,
                    Name = "Връх Снежанка",
                    Description = "Снежанка е известен със своята телевизионна кула — символ на Пампорово. На върха има панорамна тераса, откъдето се виждат десетки километри разстояние. Мястото е достъпно с лифт и е сред най-посещаваните върхове в Родопите.",
                    ImageUrl = "https://th.bing.com/th/id/R.38b7087237df7dea6a5c55b2bba060b0?rik=%2bBeclaLOWgBkSg&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 8,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Намира се в Родопи, близо до Пампорово, на около 15 км от Смолян.",
                    LocationUrl = "/images/СНЕЖ.png"
                },
                new Destination
                {
                    Id = 24,
                    Name = "Голям Персенк",
                    Description = "Голям Персенк е един от най-красивите върхове в Родопите. Известен е със стръмните си скални склонове и великолепните гледки към околните ридове. Районът е спокоен, изпълнен с диви билки, цветя и горски аромати.",
                    ImageUrl = "https://tse3.mm.bing.net/th/id/OIP.S_fTI4mlWg9XtR06LbxXHwHaEL?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 8,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "най-високият в Родопския дял Чернатица. На юг по билото е свързан с връх Мечкарски камък.",
                    LocationUrl = "/images/ГП.png"
                },

                // ПАНОРАМИ
                new Destination
                {
                    Id = 25,
                    Name = "Орлово око",
                    Description = "Орлово око е панорамна площадка, разположена на ръба на скален масив над Ягодина. Построена е върху метална конструкция, която се издига над пропастта и позволява 360° гледка към Родопите. Мястото е едно от най-популярните за снимки в България.",
                    ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.sWaV4rkPqBco2_K_4KpJYwHaFo?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 9,
                    PublishedOn = now,
                    TicketPrice = 6m,
                    IsDeleted = false,
                    Location = "Орлово око е панорамна площадка, която се намира в Западните Родопи, на връх Свети Илия.",
                    LocationUrl = "/images/ОО.png"
                },
                new Destination
                {
                    Id = 26,
                    Name = "Панорамна площадка Невястата",
                    Description = "Площадката предлага чудесна гледка към град Смолян, язовирите и върховете в района. Мястото е достъпно по лека екопътека и е любимо за туристи, които искат да посрещнат изгрев или залез от високо.",
                    ImageUrl = "https://planinka.bg/wp-content/uploads/2024/09/DSCF5725-683x1024.webp",
                    PublisherId = adminId,
                    TerrainId = 9,
                    PublishedOn = now,
                    TicketPrice = 4m,
                    IsDeleted = false,
                    Location = "Намира се над град Смолян, в планината Родопи.",
                    LocationUrl = "/images/ППН.png"
                },
                new Destination
                {
                    Id = 27,
                    Name = "Панорама над Мугла",
                    Description = "Панорамните ридове над село Мугла разкриват суровата красота на Родопите. Районът е тих, без туристически тълпи, подходящ за любители на фотография, преходи и спокойствие.",
                    ImageUrl = "https://cs14.pikabu.ru/post_img/big/2023/08/08/4/1691469042148636877.jpg",
                    PublisherId = adminId,
                    TerrainId = 9,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "В в Западните Родопи, област Смолян.",
                    LocationUrl = "/images/М.png"
                },

                // СВЕТИЛИЩА
                new Destination
                {
                    Id = 28,
                    Name = "Белинташ",
                    Description = "Белинташ е едно от най-известните тракийски светилища. Платото е покрито с издялани скални улеи и култови знаци, чието предназначение и днес остава загадка. Мястото е известно със силната си енергия и панорамните гледки към Родопите..",
                    ImageUrl = "https://tse3.mm.bing.net/th/id/OIP.gRBxnuvSn5A0TaMMIRfL4wHaE8?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 10,
                    PublishedOn = now,
                    TicketPrice = 6m,
                    IsDeleted = false,
                    Location = "Белинташ се намира в Родопите, на 32,6 км от град Асеновград, над селата Врата и Мостово.",
                    LocationUrl = "/images/Б.png"
                },
                new Destination
                {
                    Id = 29,
                    Name = "Караджов камък",
                    Description = "Караджов камък е величествена скална арка, разположена на върха на отвесен каньон. До него води древна пътека. Според легендите траките са го използвали като жертвено място. Изгледът от върха е драматичен и незабравим.",
                    ImageUrl = "https://th.bing.com/th/id/R.1dae6b2b41ce335644aa4a7945e01631?rik=fx7pNFgWyBe1Uw&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 10,
                    PublishedOn = now,
                    TicketPrice = 6m,
                    IsDeleted = false,
                    Location = "Намира се в близост до село Мостово в Западните Родопи.",
                    LocationUrl = "/images/KK.png"
                },
                new Destination
                {
                    Id = 30,
                    Name = "Татул",
                    Description = "Татул е древно тракийско светилище, свързвано с култа към Орфей. Има уникална архитектура — монолитна скала, оформена като саркофаг, и култов комплекс около нея. Мястото носи атмосфера на древна духовност и е сред най-значимите археологически обекти в Родопите.",
                    ImageUrl = "https://tse3.mm.bing.net/th/id/OIP.qmgnBIPyzwGyuIeDA4L38gHaE8?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 10,
                    PublishedOn = now,
                    TicketPrice = 6m,
                    IsDeleted = false,
                    Location = "Татул се намира в м. Кая Башъ, в южните покрайнини на малкото източно родопско селце Татул",
                    LocationUrl = "/images/Т.png"
                }
            );
        }
    }
}
