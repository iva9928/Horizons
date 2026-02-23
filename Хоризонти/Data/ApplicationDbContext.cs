using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Horizons.Data.Models;



    namespace Horizons.Data
    {
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Destination> Destinations { get; set; } = null!;
            public DbSet<UserDestination> UserDestinations { get; set; } = null!;
            public DbSet<Terrain> Terrains { get; set; } = null!;
            public DbSet<Reservation> Reservations { get; set; } = null!;
            public DbSet<Rating> Ratings { get; set; } = null!;
            public DbSet<Message> Messages { get; set; } = null!;

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
            builder.Entity<Message>()
    .HasOne(m => m.Sender)
    .WithMany()
    .HasForeignKey(m => m.SenderId)
    .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            const string adminId = "7699db7d-964f-4782-8209-d76562e0fece";

                // ✅ ВАЖНО: ApplicationUser вместо IdentityUser
                var defaultUser = new ApplicationUser
                {
                    Id = adminId,
                    UserName = "admin@horizons.com",
                    NormalizedUserName = "ADMIN@HORIZONS.COM",
                    Email = "admin@horizons.com",
                    NormalizedEmail = "ADMIN@HORIZONS.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "STATIC_SECURITY_STAMP",
                    Age = 30,
                    Bio = "Main administrator of Horizons.",
                    IsGuide = false,
                    ProfileImageUrl = null
                };

                var passwordHasher = new PasswordHasher<ApplicationUser>();
                defaultUser.PasswordHash =
                    passwordHasher.HashPassword(defaultUser, "Admin123!");

                // ✅ ВАЖНО: ApplicationUser
                builder.Entity<ApplicationUser>().HasData(defaultUser);

           

            var guides = new List<ApplicationUser>
{
    new ApplicationUser
    {
        Id = "guide-cave",
        UserName = "cave@horizons.com",
        NormalizedUserName = "CAVE@HORIZONS.COM",
        Email = "cave@horizons.com",
        NormalizedEmail = "CAVE@HORIZONS.COM",
        EmailConfirmed = true,
        SecurityStamp = Guid.NewGuid().ToString(),
        Age = 34,
        Bio = "Спелеолог с 12 години опит.",
        IsGuide = true,
        ProfileImageUrl = "/images/guides/cave.png"
    },
    new ApplicationUser
    {
        Id = "guide-eco",
        UserName = "eco@horizons.com",
        NormalizedUserName = "ECO@HORIZONS.COM",
        Email = "eco@horizons.com",
        NormalizedEmail = "ECO@HORIZONS.COM",
        EmailConfirmed = true,
        SecurityStamp = Guid.NewGuid().ToString(),
        Age = 29,
        Bio = "Еколог и водач на екопътеки.",
        IsGuide = true,
        ProfileImageUrl = "/images/guides/eco.png"
    }
};

            foreach (var guide in guides)
            {
                guide.PasswordHash = passwordHasher.HashPassword(guide, "Guide123!");
                builder.Entity<ApplicationUser>().HasData(guide);
            }

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

                var now = new DateTime(2024, 1, 1);



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
                    LocationUrl = "/images/ЯП.png",
                    Season = Season.Autumn, 
                    VideoUrl = "https://www.youtube.com/embed/7eBi4Bq85xE"
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
                    LocationUrl = "/images/ДГ.png",
                    Season = Season.Autumn,
                    VideoUrl = "https://www.youtube.com/embed/_dg8xrSLYcw?start=28"

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
                    LocationUrl = "/images/У.png",
                    Season = Season.Autumn,
                    VideoUrl = "https://www.youtube.com/embed/KyUtzNQmQ_I"
                },

                // ЖДРЕЛА / КАНЬОНИ
                new Destination
                {
                    Id = 4,
                    Name = "Триградско ждрело",
                    Description = "Триградското ждрело е величествен карстов каньон...",
                    ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.XcL7FSfxMczbaMFwc4YEPgHaJ4?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 2,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Започва на около 1,5 km северно от село Триград...",
                    LocationUrl = "/images/ТЖ.png",
                    Season = Season.Summer,
                    VideoUrl = "https://www.youtube.com/embed/wmxbIB5JuCI?start=56"
                },
                new Destination
                {
                    Id = 5,
                    Name = "Буйновско ждрело",
                    Description = "Буйновското ждрело е най-дългото ждрело в България...",
                    ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.LLbqun3yJfkPrZZD7Ie6xAHaDC?rs=1&pid=ImgDetMain&o=7&rm=3",
                    PublisherId = adminId,
                    TerrainId = 2,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Буйновското ждрело се намира в Родопите...",
                    LocationUrl = "/images/БЖ.png",
                    Season = Season.Summer,
                    VideoUrl = "https://www.youtube.com/embed/RXMaOdj88B4"
                },
                new Destination
                {
                    Id = 6,
                    Name = "Каньонът на водопадите",
                    Description = "Каньонът на водопадите е природен резерват...",
                    ImageUrl = "https://th.bing.com/th/id/R.a5291d2e52f73c8001355d5eb15368ca?rik=R0DvhlMQg3M4bA&riu=http%3a%2f%2fwww.bestplacesinbulgaria.com%2fwp-content%2fuploads%2f2016%2f07%2fthe-waterfall-canyon-tourist-eco-route-04.jpg&ehk=oCv5V7rhnBFogS4%2fm7xRsyWvJs0xKlq0uAwRHdAb%2fZI%3d&risl=&pid=ImgRaw&r=0",
                    PublisherId = adminId,
                    TerrainId = 2,
                    PublishedOn = now,
                    TicketPrice = 0m,
                    IsDeleted = false,
                    Location = "Каньонът на водопадите се намира в Родопите...",
                    LocationUrl = "/images/КВ.png",
                    Season = Season.Summer,
                    VideoUrl = "https://www.youtube.com/embed/3GhaDD5iaXk"
                },

                // СКАЛНИ ОБРАЗУВАНИЯ
new Destination
{
    Id = 7,
    Name = "Чудните мостове",
    Description = "Чудните мостове са природно образувани мраморни арки...",
    ImageUrl = "https://th.bing.com/th/id/R.b048105f8f39b372ffdea8dbcf05c795?rik=FCc9PiWL7rUe5Q&riu=http%3a%2f%2fimgrabo.com%2fpics%2fguide%2f900x600%2f20160601155206_11652.jpeg&ehk=DaVIqKNWclj1HLtnZ9PETVjw7xvfpNsSMMmVTryhjsE%3d&risl=&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 3,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Чудните мостове са разположени на около 16 км...",
    LocationUrl = "/images/ЧМ.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/sGwA9KiQL-s?start=20"
},
new Destination
{
    Id = 8,
    Name = "Каменната сватба",
    Description = "Каменната сватба е група от розово-бели скални фигури...",
    ImageUrl = "https://th.bing.com/th/id/R.dac78f30028a402c35f83f7c13014156?rik=ai36YaI2926Wgg&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 3,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Намира се на 5 км източно от центъра на град Кърджали...",
    LocationUrl = "/images/ВС.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/qWWHbqvgodI"
},
new Destination
{
    Id = 9,
    Name = "Орфееви скали",
    Description = "Орфееви скали са панорамен скален масив...",
    ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.E3gs9mp6NNpTDsT5a8ZVjgHaE8?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 3,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Орфееви скали се намира в сърцето на Родопите...",
    LocationUrl = "/images/ОС.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/TquHEt3VnNA?start=24"
},

// ЕКОПЪТЕКИ
new Destination
{
    Id = 10,
    Name = "Екопътека Невястата",
    Description = "Екопътека Невястата е къса, но изключително красива пътека...",
    ImageUrl = "https://th.bing.com/th/id/R.0a050afe7b3736527938ed15d7e9a03d?rik=57SHvi48b7i2bw&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 4,
    PublishedOn = now,
    TicketPrice = 2m,
    IsDeleted = false,
    Location = "Екопътека “Невястата” се намира в сърцето на Родопи...",
    LocationUrl = "/images/Н.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/ZKz12LqDtEo"
},
new Destination
{
    Id = 11,
    Name = "Екопътека Девин – Лъки",
    Description = "Екопътеката разкрива уникални панорами към долината на река Въча...",
    ImageUrl = "https://i.pinimg.com/originals/7a/ea/e5/7aeae5868a2c405cb35e18f18af472ce.jpg",
    PublisherId = adminId,
    TerrainId = 4,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "В Родопите, на около 3км от центъра на град Девин...",
    LocationUrl = "/images/ЕДЛ.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/OnwO_cKrtOk"
},
new Destination
{
    Id = 12,
    Name = "Екопътека Каньонът на водопадите",
    Description = "Това е една от най-популярните екопътеки в България...",
    ImageUrl = "https://th.bing.com/th/id/R.9f1c32a1258db100a6f29964c02ff682?rik=oHJQwPzmxk2tYQ&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 4,
    PublishedOn = now,
    TicketPrice = 2m,
    IsDeleted = false,
    Location = "Само на 2-3 км от Смолян...",
    LocationUrl = "/images/ЕКВ.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/KfT4eUp56Vc"
},
// ВОДОПАДИ
new Destination
{
    Id = 13,
    Name = "Сливодолското падало",
    Description = "Сливодолското падало е един от най-високите и красиви водопади в Родопите...",
    ImageUrl = "https://th.bing.com/th/id/R.ddeeca6d4f5ce0ec0204b62cc8e37980?rik=25fdGAogwznqjw&riu=http%3a%2f%2fblog.hotel-extreme.bg%2fwp-content%2fuploads%2f2017%2f06%2f6_Fotor1400%d0%bb%d0%be%d0%b3%d0%be-min-1068x600.jpg&ehk=WkEtKlbiCqR1bwRIKog51GgKMwxRCKgwFRsxHPecX8g%3d&risl=&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 5,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Водопадът се намира на около 15 километра южно от Асеновград",
    LocationUrl = "/images/ВСПП.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/C7tUIZPyLgM?start=46"
},
new Destination
{
    Id = 14,
    Name = "Самодивско пръскало",
    Description = "Според легендите тук са танцували самодиви...",
    ImageUrl = "https://tse2.mm.bing.net/th/id/OIP.CO4dsfPS4jbawx7C25h4eQAAAA?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 5,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "В Родопите, в близост до град Девин...",
    LocationUrl = "/images/ВСП.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/xkymhO4rF6o?start=71"
},
new Destination
{
    Id = 15,
    Name = "Водопад Орфей",
    Description = "Водопад Орфей е част от Каньона на водопадите...",
    ImageUrl = "https://th.bing.com/th/id/R.5471ea23b3474a4421aca6f30071e691?rik=9xyjKKpLceVaFQ&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 5,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Водопад Орфей се намира в местност Сосковчето...",
    LocationUrl = "/images/ВО.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/vtiVLTa6CWY"
},

// ЕЗЕРА
new Destination
{
    Id = 16,
    Name = "Смолянски езера",
    Description = "Смолянските езера са група от 20 естествени езера...",
    ImageUrl = "https://tse3.mm.bing.net/th/id/OIP.DN8OOsa-_uZWXD2EQLyFkgHaFj?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 6,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "В покрайнините на град Смолян...",
    LocationUrl = "/images/СЕ.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/yeXTCyjg2lE"
},
new Destination
{
    Id = 17,
    Name = "Язовир Доспат",
    Description = "Язовир Доспат е един от най-красивите язовири...",
    ImageUrl = "https://tse2.mm.bing.net/th/id/OIP.WkpaLcOORed2Oc25sw9rRQHaFj?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 6,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Разположен в посока северозапад – югоизток...",
    LocationUrl = "/images/ЯД.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/JkWGJC_kjZk?start=24"
},
new Destination
{
    Id = 18,
    Name = "Язовир Широка поляна",
    Description = "Широка поляна е любим язовир за риболовци...",
    ImageUrl = "https://th.bing.com/th/id/R.3d8cc2eb89f0e6b7b09f5a80e9645555?rik=KH2XtILVhMcRxA&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 6,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Язовир Широка поляна се намира в борова гора...",
    LocationUrl = "/images/ЯШ.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/ZlgSpXgvPQ4?start=53"
},

// ГОРИ / РЕЗЕРВАТИ
new Destination
{
    Id = 19,
    Name = "Резерват Кормисош",
    Description = "Кормисош е огромен биосферен резерват...",
    ImageUrl = "https://th.bing.com/th/id/R.1bddc5bf1178275fa5ceed3a41b5ba7b?rik=E5tlQ55qqhUTZw&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 7,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Разположен в Родопите",
    LocationUrl = "/images/ЯП.png",
    Season = Season.Autumn,
    VideoUrl = "https://www.youtube.com/embed/yAmSJVYXewY"
},
new Destination
{
    Id = 20,
    Name = "Резерват Червената стена",
    Description = "Червената стена е биосферен резерват под закрилата на UNESCO...",
    ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.FgtZsnzP3v-JbSbsPskOfAHaE8?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 7,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "В сърцето на Родопите...",
    LocationUrl = "/images/ЧС.png",
    Season = Season.Autumn,
    VideoUrl = "https://www.youtube.com/embed/Tbo4FVD8e0w?start=22"
},
new Destination
{
    Id = 21,
    Name = "Борова гора край Пампорово",
    Description = "Боровите гори около Пампорово създават усещане за алпийски пейзаж...",
    ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.1eT0klYEsE8Vyn0m_PckzgHaFj?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 7,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Намира се близо до зимния курорт...",
    LocationUrl = "/images/БГ.png",
    Season = Season.Autumn,
    VideoUrl = "https://www.youtube.com/embed/B0vsbEh8jtk"
},
// ВЪРХОВЕ
new Destination
{
    Id = 22,
    Name = "Връх Голям Перелик",
    Description = "Голям Перелик е най-високият връх в Родопите (2191 м)...",
    ImageUrl = "https://www.bestplacesinbulgaria.com/wp-content/uploads/2016/03/golyam_perelik_02.jpg",
    PublisherId = adminId,
    TerrainId = 8,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Връх Голям Перелик е най-високата точка на Родопите...",
    LocationUrl = "/images/ПЕР.png",
    Season = Season.Winter,
    VideoUrl = "https://www.youtube.com/embed/uARzLBZ4_UA"
},
new Destination
{
    Id = 23,
    Name = "Връх Снежанка",
    Description = "Снежанка е известен със своята телевизионна кула...",
    ImageUrl = "https://th.bing.com/th/id/R.38b7087237df7dea6a5c55b2bba060b0?rik=%2bBeclaLOWgBkSg&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 8,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Намира се в Родопи, близо до Пампорово...",
    LocationUrl = "/images/СНЕЖ.png",
    Season = Season.Winter,
    VideoUrl = "https://www.youtube.com/embed/aFIq2S2fXEI"
},
new Destination
{
    Id = 24,
    Name = "Голям Персенк",
    Description = "Голям Персенк е един от най-красивите върхове в Родопите...",
    ImageUrl = "https://tse3.mm.bing.net/th/id/OIP.S_fTI4mlWg9XtR06LbxXHwHaEL?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 8,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "Най-високият в Родопския дял Чернатица...",
    LocationUrl = "/images/ГП.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/IJbpxlSFawg"
},

// ПАНОРАМИ
new Destination
{
    Id = 25,
    Name = "Орлово око",
    Description = "Орлово око е панорамна площадка...",
    ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.sWaV4rkPqBco2_K_4KpJYwHaFo?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 9,
    PublishedOn = now,
    TicketPrice = 6m,
    IsDeleted = false,
    Location = "Орлово око се намира в Западните Родопи...",
    LocationUrl = "/images/ОО.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/uARzLBZ4_UA"
},
new Destination
{
    Id = 26,
    Name = "Панорамна площадка Невястата",
    Description = "Площадката предлага чудесна гледка към град Смолян...",
    ImageUrl = "https://planinka.bg/wp-content/uploads/2024/09/DSCF5725-683x1024.webp",
    PublisherId = adminId,
    TerrainId = 9,
    PublishedOn = now,
    TicketPrice = 4m,
    IsDeleted = false,
    Location = "Намира се над град Смолян...",
    LocationUrl = "/images/ППН.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/9FvP5rcw6kk"
},
new Destination
{
    Id = 27,
    Name = "Панорама над Мугла",
    Description = "Панорамните ридове над село Мугла...",
    ImageUrl = "https://cs14.pikabu.ru/post_img/big/2023/08/08/4/1691469042148636877.jpg",
    PublisherId = adminId,
    TerrainId = 9,
    PublishedOn = now,
    TicketPrice = 0m,
    IsDeleted = false,
    Location = "В Западните Родопи, област Смолян.",
    LocationUrl = "/images/М.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/94xSOxLhuXY?start=46"
},

// СВЕТИЛИЩА
new Destination
{
    Id = 28,
    Name = "Белинташ",
    Description = "Белинташ е едно от най-известните тракийски светилища...",
    ImageUrl = "https://tse3.mm.bing.net/th/id/OIP.gRBxnuvSn5A0TaMMIRfL4wHaE8?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 10,
    PublishedOn = now,
    TicketPrice = 6m,
    IsDeleted = false,
    Location = "Белинташ се намира в Родопите...",
    LocationUrl = "/images/Б.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/b55bpx1JN48"
},
new Destination
{
    Id = 29,
    Name = "Караджов камък",
    Description = "Караджов камък е величествена скална арка...",
    ImageUrl = "https://th.bing.com/th/id/R.1dae6b2b41ce335644aa4a7945e01631?rik=fx7pNFgWyBe1Uw&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 10,
    PublishedOn = now,
    TicketPrice = 6m,
    IsDeleted = false,
    Location = "Намира се в близост до село Мостово...",
    LocationUrl = "/images/KK.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/s4iG2ux2gQc?start=28"
},
new Destination
{
    Id = 30,
    Name = "Татул",
    Description = "Татул е древно тракийско светилище...",
    ImageUrl = "https://tse3.mm.bing.net/th/id/OIP.qmgnBIPyzwGyuIeDA4L38gHaE8?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 10,
    PublishedOn = now,
    TicketPrice = 6m,
    IsDeleted = false,
    Location = "Татул се намира в м. Кая Башъ...",
    LocationUrl = "/images/Т.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/7cAKSl69e5U?start=564"
}

            );
        }
    }
}
