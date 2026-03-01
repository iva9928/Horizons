using Horizons.Data;
using Horizons.Data.Models;
using Horizons.Models;
using Horizons.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
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
            context.SaveChanges();
        }

        [TearDown]
        public void TearDown() => context.Dispose();

        // ================= ADD =================

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
                LocationUrl = "url"
            };

            await service.AddDestinationAsync(model, "publisher1");

            Assert.AreEqual(1, context.Destinations.Count());
        }

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
                LocationUrl = "url"
            };

            await service.AddDestinationAsync(model, "publisher1");

            Assert.AreEqual("Sofia", context.Destinations.First().Location);
        }

        // ================= EDIT =================

        [Test]
        public async Task Edit_ShouldUpdateFields()
        {
            context.Destinations.Add(new Destination
            {
                Id = 1,
                Name = "Old",
                Description = "Desc",
                ImageUrl = "img",
                PublisherId = "p1",
                TerrainId = 1,
                TicketPrice = 1,
                PublishedOn = DateTime.Now,
                Location = "L",
                LocationUrl = "url"
            });
            context.SaveChanges();

            var model = new DestinationEditViewModel
            {
                Id = 1,
                Name = "New",
                Description = "NewDesc",
                ImageUrl = "NewImg",
                TerrainId = 1,
                TicketPrice = 20,
                PublishedOn = "01-01-2024",
                Location = "NewLoc",
                LocationUrl = "new"
            };

            await service.EditDestinationAsync(model, "p1");

            var d = context.Destinations.First();
            Assert.AreEqual("New", d.Name);
            Assert.AreEqual(20, d.TicketPrice);
        }

        [Test]
        public void Edit_ShouldThrow_WhenNotFound()
        {
            var model = new DestinationEditViewModel { Id = 999 };

            Assert.ThrowsAsync<InvalidOperationException>(() =>
                service.EditDestinationAsync(model, "user"));
        }

        // ================= DELETE =================

        [Test]
        public async Task Delete_ShouldMarkAsDeleted()
        {
            context.Destinations.Add(new Destination
            {
                Id = 1,
                Name = "Test",
                Description = "D",
                ImageUrl = "img",
                PublisherId = "me",
                TerrainId = 1,
                PublishedOn = DateTime.Now,
                Location = "L",
                LocationUrl = "url"
            });
            context.SaveChanges();

            await service.DeleteDestinationAsync(1, "me");

            Assert.IsTrue(context.Destinations.First().IsDeleted);
        }

        [Test]
        public void Delete_ShouldThrow_WhenWrongPublisher()
        {
            context.Destinations.Add(new Destination
            {
                Id = 2,
                Name = "Test",
                Description = "D",
                ImageUrl = "img",
                PublisherId = "owner",
                TerrainId = 1,
                PublishedOn = DateTime.Now,
                Location = "L",
                LocationUrl = "url"
            });
            context.SaveChanges();

            Assert.ThrowsAsync<UnauthorizedAccessException>(() =>
                service.DeleteDestinationAsync(2, "other"));
        }

        // ================= FAVORITES =================

        [Test]
        public async Task AddToFavorites_ShouldAdd()
        {
            await service.AddToFavoritesAsync(1, "u1");
            Assert.AreEqual(1, context.UserDestinations.Count());
        }

        [Test]
        public async Task AddToFavorites_ShouldNotDuplicate()
        {
            context.UserDestinations.Add(new UserDestination
            {
                UserId = "u1",
                DestinationId = 1
            });
            context.SaveChanges();

            await service.AddToFavoritesAsync(1, "u1");

            Assert.AreEqual(1, context.UserDestinations.Count());
        }

        [Test]
        public async Task RemoveFromFavorites_ShouldRemove()
        {
            context.UserDestinations.Add(new UserDestination
            {
                UserId = "u1",
                DestinationId = 1
            });
            context.SaveChanges();

            await service.RemoveFromFavoritesAsync(1, "u1");

            Assert.AreEqual(0, context.UserDestinations.Count());
        }

        // ================= DETAILS =================

        [Test]
        public async Task Details_ShouldReturnNull_WhenNotFound()
        {
            var result = await service.GetDestinationDetailsAsync(999, "u1");
            Assert.IsNull(result);
        }

        // ================= TERRAINS =================

        [Test]
        public async Task GetAllTerrains_ShouldReturnList()
        {
            var terrains = await service.GetAllTerrainsAsync();
            Assert.AreEqual(1, terrains.Count());
        }

        // ================= RESERVATION =================

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
        public void Reservation_ShouldThrow_WhenInvalidPeople()
        {
            var r = new Reservation { PeopleCount = 0, TicketPrice = 1 };

            Assert.Throws<ValidationException>(() =>
            {
                Validator.ValidateObject(r, new ValidationContext(r), true);
            });
        }
    }
}