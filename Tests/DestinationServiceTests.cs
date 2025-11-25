using Horizons.Data;
using Horizons.Data.Models;
using Horizons.Models;
using Horizons.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Horizons.Tests
{
    [TestFixture]
    public class DestinationServiceTests
    {
        private ApplicationDbContext context;
        private DestinationService service;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);
            service = new DestinationService(context);

            context.Terrains.Add(new Terrain { Id = 1, Name = "Пещера" });
            context.Terrains.Add(new Terrain { Id = 2, Name = "Гора" });

            context.Users.Add(new IdentityUser { Id = "publisher1", UserName = "pub" });

            context.SaveChanges();
        }

        [TearDown]
        public void TearDown() => context.Dispose();

        // 1
        [Test]
        public async Task AddDestination_ShouldAdd()
        {
            var model = new DestinationAddViewModel
            {
                Name = "Test",
                Description = "Desc",
                ImageUrl = "img",
                PublishedOn = "01-01-2024",
                TerrainId = 1,
                TicketPrice = 10,
                Location = "Sofia",
                LocationUrl = "test-url"
            };

            await service.AddDestinationAsync(model, "publisher1");

            Assert.AreEqual(1, context.Destinations.Count());
        }

        // 2
        [Test]
        public async Task AddDestination_ShouldTrimLocation()
        {
            var model = new DestinationAddViewModel
            {
                Name = "Test",
                Description = "Desc",
                ImageUrl = "img",
                PublishedOn = "01-01-2024",
                TerrainId = 1,
                TicketPrice = 10,
                Location = "   Sofia   ",
                LocationUrl = "test-url"
            };

            await service.AddDestinationAsync(model, "publisher1");

            Assert.AreEqual("Sofia", context.Destinations.First().Location);
        }

        // 3
        [Test]
        public async Task AddDestination_ShouldSetPublisher()
        {
            var model = new DestinationAddViewModel
            {
                Name = "X",
                Description = "D",
                ImageUrl = "i",
                PublishedOn = "01-01-2024",
                TerrainId = 1,
                TicketPrice = 1,
                Location = "Loc",
                LocationUrl = "test-url"
            };

            await service.AddDestinationAsync(model, "publisher1");
            Assert.AreEqual("publisher1", context.Destinations.First().PublisherId);
        }


        // 6
        [Test]
        public async Task Edit_ShouldModifyFields()
        {
            context.Destinations.Add(new Destination
            {
                Id = 1,
                Name = "Old",
                Description = "O",
                ImageUrl = "i",
                PublisherId = "publisher1",
                TerrainId = 1,
                TicketPrice = 1,
                Location = "L",
                LocationUrl = "old",
                PublishedOn = DateTime.Now
            });

            context.SaveChanges();

            var model = new DestinationEditViewModel
            {
                Id = 1,
                Name = "New",
                Description = "NewDesc",
                ImageUrl = "newImg",
                TerrainId = 1,
                TicketPrice = 20,
                PublishedOn = "01-01-2024",
                Location = "NewL",
                LocationUrl = "test-url",
                PublisherId = "publisher1"
            };

            await service.EditDestinationAsync(model, "publisher1");

            var x = context.Destinations.First();
            Assert.AreEqual("New", x.Name);
            Assert.AreEqual(20, x.TicketPrice);
        }

        // 7
        

        // 8
        [Test]
        public void Edit_ShouldThrow_IfNotFound()
        {
            var model = new DestinationEditViewModel
            {
                Id = 100,
                Name = "X"
            };

            Assert.ThrowsAsync<InvalidOperationException>(() =>
                service.EditDestinationAsync(model, "publisher1"));
        }

      

        // 11
        [Test]
        public void Delete_ShouldThrow_IfNotFound()
        {
            Assert.ThrowsAsync<InvalidOperationException>(() =>
                service.DeleteDestinationAsync(999, "x"));
        }

       
        [Test]
        public async Task Details_ShouldReturnNull_IfNotFound()
        {
            var result = await service.GetDestinationDetailsAsync(999, "u1");
            Assert.IsNull(result);
        }

        // 18
        [Test]
        public async Task Details_ShouldReturnValidData()
        {
            var user = new IdentityUser { Id = "pub", UserName = "Publisher" };
            context.Users.Add(user);

            context.Destinations.Add(new Destination
            {
                Id = 1,
                Name = "Test",
                Description = "D",
                ImageUrl = "I",
                TerrainId = 1,
                PublisherId = "pub",
                Publisher = user,
                Location = "L",
                LocationUrl = "test",
                PublishedOn = DateTime.Now
            });

            context.SaveChanges();

            var res = await service.GetDestinationDetailsAsync(1, "u1");

            Assert.AreEqual("Test", res.Name);
            Assert.AreEqual("Publisher", res.Publisher);
        }

       

        // 20
        [Test]
        public async Task GetAllTerrains_ShouldReturnCorrect()
        {
            var terrains = await service.GetAllTerrainsAsync();
            Assert.AreEqual(2, terrains.Count());
        }

      
        // 23
        [Test]
        public async Task GetEditModel_ShouldReturnNull_IfMissing()
        {
            var r = await service.GetEditModelAsync(999);
            Assert.IsNull(r);
        }

    


        // 29
        [Test]
        public async Task Add_ShouldRequireLocationUrl()
        {
            var model = new DestinationAddViewModel
            {
                Name = "Test",
                Description = "D",
                ImageUrl = "img",
                PublishedOn = "01-01-2024",
                TerrainId = 1,
                TicketPrice = 1,
                Location = "L",
                LocationUrl = "test-url"
            };

            await service.AddDestinationAsync(model, "publisher1");

            Assert.AreEqual("test-url", context.Destinations.First().LocationUrl);
        }
        private Destination ValidDestination(string publisher = "user1", int id = 1)
        {
            return new Destination
            {
                Id = id,
                Name = "Test",
                Description = "Desc",
                ImageUrl = "img",
                TicketPrice = 10,
                PublishedOn = DateTime.Now,
                TerrainId = 1,
                PublisherId = publisher,
                Location = "Here",
                LocationUrl = "url.png",
                Terrain = new Terrain { Id = 1, Name = "T" },
                Publisher = new IdentityUser { Id = publisher, UserName = publisher }
            };
        }
        // 1
        [Test]
        public async Task AddDestination_ShouldAddValidDestination()
        {
            var model = new DestinationAddViewModel
            {
                Name = "Test",
                Description = "Desc",
                ImageUrl = "img",
                PublishedOn = "01-01-2024",
                TerrainId = 1,
                TicketPrice = 5,
                Location = "Loc",
                LocationUrl = "u.png"
            };

            await service.AddDestinationAsync(model, "user1");

            Assert.AreEqual(1, context.Destinations.Count());
        }

    

        // 3
        [Test]
        public async Task AddDestination_ShouldSaveLocationUrlOrNull()
        {
            var model = new DestinationAddViewModel
            {
                Name = "Test",
                Description = "Desc",
                ImageUrl = "img",
                PublishedOn = "01-01-2024",
                TerrainId = 1,
                TicketPrice = 10,
                Location = "Loc",
                LocationUrl = ""
            };

            await service.AddDestinationAsync(model, "user1");

            Assert.IsNull(context.Destinations.First().LocationUrl);
        }

        // 11
        [Test]
        public void Delete_ShouldThrow_WhenNotFound()
        {
            Assert.ThrowsAsync<InvalidOperationException>(() =>
                service.DeleteDestinationAsync(123, "user"));
        }


        // 17
        [Test]
        public async Task GetDetails_ShouldReturnNull_WhenNotFound()
        {
            var result = await service.GetDestinationDetailsAsync(123, "u");
            Assert.IsNull(result);
        }


        
       

        // 23
        [Test]
        public async Task GetEditModel_ShouldReturnNull_WhenMissing()
        {
            var result = await service.GetEditModelAsync(555);
            Assert.IsNull(result);
        }

     

    }
}


namespace Horizons.Tests
{
    [TestFixture]
    public class DestinationServiceTests2
    {
        private ApplicationDbContext context;
        private DestinationService service;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);
            service = new DestinationService(context);

            context.Terrains.Add(new Terrain { Id = 1, Name = "Test Terrain" });
            context.SaveChanges();
        }

        [TearDown] public void Teardown() => context.Dispose();


        [Test]
        public async Task AddDestination_ShouldAdd_WhenValid()
        {
            var model = new DestinationAddViewModel
            {
                Name = "Name",
                Description = "Desc",
                ImageUrl = "img",
                PublishedOn = "01-01-2023",
                TerrainId = 1,
                Location = "Sofia"
            };

            await service.AddDestinationAsync(model, "u1");

            Assert.AreEqual(1, context.Destinations.Count());
        }

        [Test]
        public async Task AddDestination_ShouldTrimLocation()
        {
            var model = new DestinationAddViewModel
            {
                Name = "Name",
                Description = "Desc",
                ImageUrl = "img",
                PublishedOn = "01-01-2023",
                TerrainId = 1,
                Location = "   Sofia   "
            };

            await service.AddDestinationAsync(model, "u1");

            Assert.AreEqual("Sofia", context.Destinations.First().Location);
        }

        [Test]
        public async Task AddDestination_ShouldSetPublisher()
        {
            var model = new DestinationAddViewModel
            {
                Name = "N",
                Description = "D",
                ImageUrl = "i",
                PublishedOn = "01-01-2023",
                TerrainId = 1,
                Location = "Loc"
            };

            await service.AddDestinationAsync(model, "publisher");

            Assert.AreEqual("publisher", context.Destinations.First().PublisherId);
        }

       

        [Test]
        public async Task GetById_ShouldReturnNull_WhenDeleted()
        {
            context.Destinations.Add(new Destination
            {
                Id = 1,
                Name = "N",
                Description = "D",
                ImageUrl = "i",
                PublisherId = "u",
                TerrainId = 1,
                PublishedOn = DateTime.Now,
                Location = "L",
                LocationUrl = "/"
            });

            context.SaveChanges();

            context.Destinations.First().IsDeleted = true;
            context.SaveChanges();

            var result = await service.GetDestinationByIdAsync(1);
            Assert.IsNull(result);
        }

      

        [Test]
        public async Task Edit_ShouldUpdateFields()
        {
            context.Destinations.Add(new Destination
            {
                Id = 1,
                Name = "Old",
                Description = "D",
                ImageUrl = "i",
                PublisherId = "p1",
                TerrainId = 1,
                PublishedOn = DateTime.Now,
                Location = "L",
                LocationUrl = "/"
            });

            context.SaveChanges();

            var model = new DestinationEditViewModel
            {
                Id = 1,
                Name = "NewName",
                Description = "NewDesc",
                ImageUrl = "NewImg",
                PublishedOn = "01-01-2024",
                TerrainId = 1,
                TicketPrice = 20,
                Location = "NewLoc",
                LocationUrl = "/new"
            };

            await service.EditDestinationAsync(model, "p1");

            var d = context.Destinations.First();
            Assert.AreEqual("NewName", d.Name);
            Assert.AreEqual("NewLoc", d.Location);
        }

        [Test]
        public void Edit_ShouldThrow_WhenWrongPublisher()
        {
            context.Destinations.Add(new Destination
            {
                Id = 1,
                Name = "N",
                Description = "D",
                ImageUrl = "i",
                PublisherId = "real",
                TerrainId = 1,
                PublishedOn = DateTime.Now,
                Location = "L",
                LocationUrl = "/"
            });
            context.SaveChanges();

            var model = new DestinationEditViewModel { Id = 1, Name = "New" };

            Assert.ThrowsAsync<UnauthorizedAccessException>(() =>
                service.EditDestinationAsync(model, "fake"));
        }

        [Test]
        public void Edit_ShouldThrow_WhenNotFound()
        {
            var model = new DestinationEditViewModel { Id = 999 };
            Assert.ThrowsAsync<InvalidOperationException>(() =>
                service.EditDestinationAsync(model, "u"));
        }

        // ===================== DELETE ======================

        [Test]
        public async Task Delete_ShouldMarkAsDeleted()
        {
            context.Destinations.Add(new Destination
            {
                Id = 10,
                Name = "N",
                Description = "D",
                ImageUrl = "i",
                PublisherId = "me",
                TerrainId = 1,
                PublishedOn = DateTime.Now,
                Location = "L",
                LocationUrl = "/"
            });
            context.SaveChanges();

            await service.DeleteDestinationAsync(10, "me");

            Assert.IsTrue(context.Destinations.First().IsDeleted);
        }

        [Test]
        public void Delete_ShouldThrow_WrongPublisher()
        {
            context.Destinations.Add(new Destination
            {
                Id = 9,
                Name = "N",
                Description = "D",
                ImageUrl = "i",
                PublisherId = "owner",
                TerrainId = 1,
                PublishedOn = DateTime.Now,
                Location = "L",
                LocationUrl = "/"
            });
            context.SaveChanges();

            Assert.ThrowsAsync<UnauthorizedAccessException>(() =>
                service.DeleteDestinationAsync(9, "other"));
        }

        [Test]
        public void Delete_ShouldThrow_WhenNotFound()
        {
            Assert.ThrowsAsync<InvalidOperationException>(() =>
                service.DeleteDestinationAsync(555, "u"));
        }

        // ===================== FAVORITES ======================

        [Test]
        public async Task AddToFavorites_ShouldAdd()
        {
            SeedValidDestination(1);

            await service.AddToFavoritesAsync("u1", 1);
            Assert.AreEqual(1, context.UserDestinations.Count());
        }

        [Test]
        public async Task AddToFavorites_ShouldNotDuplicate()
        {
            SeedValidDestination(1);
            context.UserDestinations.Add(new UserDestination { UserId = "u1", DestinationId = 1 });
            context.SaveChanges();

            await service.AddToFavoritesAsync("u1", 1);
            Assert.AreEqual(1, context.UserDestinations.Count());
        }

        [Test]
        public async Task RemoveFromFavorites_ShouldRemove()
        {
            SeedValidDestination(1);
            context.UserDestinations.Add(new UserDestination { UserId = "u1", DestinationId = 1 });
            context.SaveChanges();

            await service.RemoveFromFavoritesAsync("u1", 1);
            Assert.AreEqual(0, context.UserDestinations.Count());
        }

   

        [Test]
        public async Task AddRating_ShouldCreate()
        {
            SeedValidDestination(1);

            await service.AddRatingAsync("u1", 1, 5, "Nice");
            Assert.AreEqual(1, context.Ratings.Count());
        }

        [Test]
        public async Task AddRating_ShouldUpdateExisting()
        {
            SeedValidDestination(1);
            context.Ratings.Add(new Rating
            {
                UserId = "u1",
                DestinationId = 1,
                Stars = 2,
                Comment = "old"
            });
            context.SaveChanges();

            await service.AddRatingAsync("u1", 1, 5, "new");

            Assert.AreEqual(5, context.Ratings.First().Stars);
        }

     

        [Test]
        public async Task Details_ShouldReturnNull_WhenMissing()
        {
            var result = await service.GetDestinationDetailsAsync(1234, "u");
            Assert.IsNull(result);
        }

      

      

        [Test]
        public async Task GetTerrains_ShouldReturnList()
        {
            var t = await service.GetAllTerrainsAsync();
            Assert.AreEqual(1, t.Count());
        }

   

        [Test]
        public async Task GetEditModel_ShouldReturnData()
        {
            SeedValidDestination(1, "p1");

            var m = await service.GetEditModelAsync(1);
            Assert.AreEqual(1, m.Id);
        }

        [Test]
        public async Task GetEditModel_ShouldReturnNull_IfMissing()
        {
            var m = await service.GetEditModelAsync(222);
            Assert.IsNull(m);
        }

      
        [Test]
        public async Task FavoriteList_ShouldReturnCorrect()
        {
            SeedValidDestination(1);
            context.UserDestinations.Add(new UserDestination { UserId = "u", DestinationId = 1 });
            context.SaveChanges();

            var fav = await service.GetFavoriteDestinationsAsync("u");

            Assert.AreEqual(1, fav.Count());
        }

       

        [Test]
        public void ReservationPrice_ShouldCalculateCorrectly()
        {
            var r = new ReservationCreateViewModel
            {
                TicketPrice = 10,
                PeopleCount = 3
            };
            Assert.AreEqual(30, r.TotalPrice);
        }

        [Test]
        public void Reservation_ShouldThrow_WhenPeopleInvalid()
        {
            var r = new Reservation { PeopleCount = 0, TicketPrice = 1 };
            Assert.Throws<ValidationException>(() =>
            {
                Validator.ValidateObject(r, new ValidationContext(r), true);
            });
        }

     
        private void SeedValidDestination(int id, string publisher = "u1")
        {
            context.Users.Add(new IdentityUser { Id = publisher, UserName = publisher });
            context.Destinations.Add(new Destination
            {
                Id = id,
                Name = "Name" + id,
                Description = "Desc",
                ImageUrl = "img",
                PublisherId = publisher,
                Location = "Loc",
                LocationUrl = "/l",
                TerrainId = 1,
                PublishedOn = DateTime.Now,
                TicketPrice = 10
            });
            context.SaveChanges();
        }
    }
}

