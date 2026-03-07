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
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourReservation> TourReservations { get; set; } = null!;

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

           
            builder.Entity<Destination>()
                .Property(d => d.TicketPrice)
                .HasColumnType("decimal(18,2)");

            builder.Entity<Tour>()
                .Property(t => t.PricePerPerson)
                .HasColumnType("decimal(18,2)");

            builder.Entity<TourReservation>()
                .Property(tr => tr.PricePerPerson)
                .HasColumnType("decimal(18,2)");

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

            builder.Entity<Message>()
                .HasOne(m => m.Tour)
                .WithMany()
                .HasForeignKey(m => m.TourId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Message>()
                .HasOne(m => m.Destination)
                .WithMany()
                .HasForeignKey(m => m.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);

           
            builder.Entity<Tour>()
                .HasOne(t => t.Guide)
                .WithMany()
                .HasForeignKey(t => t.GuideId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Tour>()
                .HasOne(t => t.Destination)
                .WithMany()
                .HasForeignKey(t => t.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);

         
            builder.Entity<TourReservation>()
    .HasOne(tr => tr.Tour)
    .WithMany(t => t.Reservations)
    .HasForeignKey(tr => tr.TourId)
    .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<TourReservation>()
                .HasOne(tr => tr.User)
                .WithMany()
                .HasForeignKey(tr => tr.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            const string adminId = "7699db7d-964f-4782-8209-d76562e0fece";

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

            builder.Entity<ApplicationUser>().HasData(defaultUser);

            // ===== GUIDES SEED =====

            var guide1Id = "11111111-1111-1111-1111-111111111111";
            var guide2Id = "22222222-2222-2222-2222-222222222222";
            var guide3Id = "33333333-3333-3333-3333-333333333333";
            var guide4Id = "44444444-4444-4444-4444-444444444444";
            var guide5Id = "55555555-5555-5555-5555-555555555555";

            var guide1 = new ApplicationUser
            {
                Id = guide1Id,
                UserName = "ivan.petrov@horizons.com",
                NormalizedUserName = "IVAN.PETROV@HORIZONS.COM",
                Email = "ivan.petrov@horizons.com",
                NormalizedEmail = "IVAN.PETROV@HORIZONS.COM",
                EmailConfirmed = true,
                SecurityStamp = "GUIDE1_SECURITY",
                Age = 34,
                Bio = "Планински гид с над 10 години опит в Родопите. Специализира в пещерни маршрути и високопланински преходи.",
                IsGuide = true,
                ProfileImageUrl = "/images/planinaM.png"
            };

            var guide2 = new ApplicationUser
            {
                Id = guide2Id,
                UserName = "maria.stoyanova@horizons.com",
                NormalizedUserName = "MARIA.STOYANOVA@HORIZONS.COM",
                Email = "maria.stoyanova@horizons.com",
                NormalizedEmail = "MARIA.STOYANOVA@HORIZONS.COM",
                EmailConfirmed = true,
                SecurityStamp = "GUIDE2_SECURITY",
                Age = 29,
                Bio = "Лицензиран екскурзовод и любител на екопътеките. Организира турове до водопади и панорамни площадки.",
                IsGuide = true,
                ProfileImageUrl = "/images/jenaE.png"
            };

            var guide3 = new ApplicationUser
            {
                Id = guide3Id,
                UserName = "georgi.dimitrov@horizons.com",
                NormalizedUserName = "GEORGI.DIMITROV@HORIZONS.COM",
                Email = "georgi.dimitrov@horizons.com",
                NormalizedEmail = "GEORGI.DIMITROV@HORIZONS.COM",
                EmailConfirmed = true,
                SecurityStamp = "GUIDE3_SECURITY",
                Age = 41,
                Bio = "Специалист по исторически маршрути и тракийски светилища. Разказвач на легенди и местен фолклор.",
                IsGuide = true,
                ProfileImageUrl = "/images/svetilishtaM.png"
            };

            var guide4 = new ApplicationUser
            {
                Id = guide4Id,
                UserName = "elena.ivanova@horizons.com",
                NormalizedUserName = "ELENA.IVANOVA@HORIZONS.COM",
                Email = "elena.ivanova@horizons.com",
                NormalizedEmail = "ELENA.IVANOVA@HORIZONS.COM",
                EmailConfirmed = true,
                SecurityStamp = "GUIDE4_SECURITY",
                Age = 32,
                Bio = "Професионален планински водач, сертифициран за зимни преходи и снежни маршрути.",
                IsGuide = true,
                ProfileImageUrl = "/images/vurhh.png"
            };

            var guide5 = new ApplicationUser
            {
                Id = guide5Id,
                UserName = "nikolay.kolev@horizons.com",
                NormalizedUserName = "NIKOLAY.KOLEV@HORIZONS.COM",
                Email = "nikolay.kolev@horizons.com",
                NormalizedEmail = "NIKOLAY.KOLEV@HORIZONS.COM",
                EmailConfirmed = true,
                SecurityStamp = "GUIDE5_SECURITY",
                Age = 38,
                Bio = "Еко-туризъм и приключенски маршрути. Организира групови експедиции до върхове и резервати.",
                IsGuide = true,
                ProfileImageUrl = "/images/parkoveM.png"
            };

            var hasher = new PasswordHasher<ApplicationUser>();

            guide1.PasswordHash = hasher.HashPassword(guide1, "Guide123!");
            guide2.PasswordHash = hasher.HashPassword(guide2, "Guide123!");
            guide3.PasswordHash = hasher.HashPassword(guide3, "Guide123!");
            guide4.PasswordHash = hasher.HashPassword(guide4, "Guide123!");
            guide5.PasswordHash = hasher.HashPassword(guide5, "Guide123!");

            builder.Entity<ApplicationUser>().HasData(
                guide1, guide2, guide3, guide4, guide5
            );



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

// ПЕЩЕРИ
new Destination
{
    Id = 1,
    Name = "Ягодинска пещера",
    Description = "Ягодинската пещера е една от най-дългите и красиви пещери в България, разположена в живописното Буйновско ждрело в Родопите. Общата ѝ дължина е над 10 километра, но за посетители е достъпна специално изградена туристическа част. Пещерата впечатлява с разнообразни сталактити, сталагмити, сталактони и уникални скални форми, образувани в продължение на милиони години.",
    ImageUrl = "https://th.bing.com/th/id/R.0f6956b90ab335551ef69581b5fb249c?rik=isKYGcW46QN7Wg&riu=http%3a%2f%2fwww.torre-bg.com%2fimages%2ftravel_offer_images%2fsm.jpg&ehk=A4tcxFAyfCoYpcrgn%2bBHb5mJLTDytaoeZw4chEgjM7U%3d&risl=&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 1,
    PublishedOn = now,
    TicketPrice = 12m,
    IsDeleted = false,
    Location = "Ягодинската пещера се намира в Западните Родопи, на около 3 км южно от село Ягодина и близо до Буйновското ждрело. Районът е част от Триградския карстов район и е лесно достъпен по асфалтов път.",
    LocationUrl = "/images/ЯП.png",
    Season = Season.Autumn,
    VideoUrl = "https://www.youtube.com/embed/7eBi4Bq85xE"
},

new Destination
{
    Id = 2,
    Name = "Пещера Дяволското гърло",
    Description = "Дяволското гърло е една от най-мистичните пещери в България, известна със своя огромен подземен водопад.",
    ImageUrl = "https://th.bing.com/th/id/R.069ba412d447d50a586d1836cc84c66f?rik=dN5O%2b4J3ghtCwA&pid=ImgRaw&r=0",
    PublisherId = adminId,
    TerrainId = 1,
    PublishedOn = now,
    TicketPrice = 15m,
    IsDeleted = false,
    Location = "Пещерата Дяволското гърло се намира в Триградското ждрело в Западните Родопи, на около 2 км от село Триград и на 25 км от град Девин.",
    LocationUrl = "/images/ДГ.png",
    Season = Season.Autumn,
    VideoUrl = "https://www.youtube.com/embed/_dg8xrSLYcw?start=28"
},

new Destination
{
    Id = 3,
    Name = "Ухловица",
    Description = "Ухловица е една от най-красивите пещери в Родопите, известна със своите калцитни образувания.",
    ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.w6SkxFzGIvY4ESdZwcs3mwHaE3?rs=1&pid=ImgDetMain&o=7&rm=3",
    PublisherId = adminId,
    TerrainId = 1,
    PublishedOn = now,
    TicketPrice = 10m,
    IsDeleted = false,
    Location = "Пещера Ухловица се намира близо до село Могилица в Западните Родопи, на около 37 км южно от град Смолян.",
    LocationUrl = "/images/У.png",
    Season = Season.Autumn,
    VideoUrl = "https://www.youtube.com/embed/KyUtzNQmQ_I"
},

// ЖДРЕЛА
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
    Location = "Триградското ждрело се намира в Западните Родопи между селата Триград и Девин и е издълбано от река Триградска.",
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
    Location = "Буйновското ждрело се намира в Западните Родопи между селата Тешел и Ягодина и следва течението на река Буйновска.",
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
    Location = "Каньонът на водопадите се намира в местността Сосковчето на около 3 км южно от град Смолян.",
    LocationUrl = "/images/КВ.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/3GhaDD5iaXk"
},// СКАЛНИ ОБРАЗУВАНИЯ
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
    Location = "Чудните мостове се намират в Западните Родопи, на около 16 км от село Забърдо и приблизително 50 км от град Пловдив.",
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
    Location = "Каменната сватба се намира в Източните Родопи, на около 5 км източно от град Кърджали, близо до село Зимзелен.",
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
    Location = "Орфееви скали се намират в Източните Родопи над язовир Студен кладенец, близо до град Кърджали.",
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
    Location = "Екопътека Невястата се намира над град Смолян в Западните Родопи и започва близо до квартал Райково.",
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
    Location = "Екопътеката Девин – Лъки се намира в Родопите и преминава през красиви горски райони близо до град Девин.",
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
    Location = "Екопътека Каньонът на водопадите се намира в местността Сосковчето на около 3 км южно от град Смолян.",
    LocationUrl = "/images/ЕКВ.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/KfT4eUp56Vc"
},// ВОДОПАДИ
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
    Location = "Сливодолското падало се намира в Родопите, на около 15 км южно от град Асеновград, в защитената местност Сливодолско падало.",
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
    Location = "Самодивското пръскало се намира в Родопите близо до град Девин, сред гъсти гори и планински склонове.",
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
    Location = "Водопад Орфей се намира по маршрута на екопътеката Каньонът на водопадите в местността Сосковчето край град Смолян.",
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
    Location = "Смолянските езера се намират в северната част на град Смолян, разположени по склоновете на Родопите на височина около 1500 метра.",
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
    Location = "Язовир Доспат се намира в Западните Родопи между град Доспат и село Сърница и е един от най-големите язовири в планината.",
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
    Location = "Язовир Широка поляна се намира в Западните Родопи, на около 30 км от град Батак, заобиколен от гъсти борови гори.",
    LocationUrl = "/images/ЯШ.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/ZlgSpXgvPQ4?start=53"
},// ГОРИ / РЕЗЕРВАТИ
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
    Location = "Резерват Кормисош се намира в централната част на Родопите и е част от защитените територии на България, известен със своите обширни гори и богато биоразнообразие.",
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
    Location = "Резерват Червената стена се намира в Западните Родопи близо до град Асеновград и е един от най-известните биосферни резервати в България.",
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
    Location = "Боровите гори се намират около курорта Пампорово в Западните Родопи, близо до град Смолян, и са известни със своя чист въздух и красиви планински пейзажи.",
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
    Location = "Връх Голям Перелик се намира в централната част на Родопите и е най-високият връх в планината с височина 2191 метра.",
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
    Location = "Връх Снежанка се намира над курорта Пампорово в Западните Родопи и е известен със своята телевизионна кула и панорамна площадка.",
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
    Location = "Връх Голям Персенк се намира в Родопския дял Чернатица и е един от най-високите върхове в този район.",
    LocationUrl = "/images/ГП.png",
    Season = Season.Summer,
    VideoUrl = "https://www.youtube.com/embed/IJbpxlSFawg"
},// ПАНОРАМИ
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
    Location = "Панорамната площадка Орлово око се намира над Буйновското ждрело в Западните Родопи на височина около 1560 метра, близо до село Ягодина.",
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
    Location = "Панорамната площадка Невястата се намира над град Смолян в Западните Родопи и предлага гледка към града и околните планински върхове.",
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
    Location = "Панорамните ридове над село Мугла се намират в Западните Родопи, област Смолян, и разкриват красиви гледки към планинските долини.",
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
    Location = "Белинташ се намира в Западните Родопи близо до село Мостово и е едно от най-големите тракийски светилища в България.",
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
    Location = "Караджов камък се намира в Родопите близо до село Мостово, недалеч от тракийското светилище Белинташ.",
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
    Location = "Тракийското светилище Татул се намира в Източните Родопи близо до село Татул, на около 15 км от град Момчилград.",
    LocationUrl = "/images/Т.png",
    Season = Season.Spring,
    VideoUrl = "https://www.youtube.com/embed/7cAKSl69e5U?start=564"

        
    }
    
                );

        }

    }
}