using Horizons.Controllers;
using Horizons.Data;
using Horizons.Data.Models;
using Horizons.Models;
using Horizons.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Security.Claims;

namespace ReservationTests
{
    public class Tests
    {
        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }

        private ApplicationDbContext context;
        private ReservationService reservationService;

        private const string TestUserId = "test-user";
        private const string AdminEmail = "admin@horizons.com";

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);

            context.Terrains.Add(new Terrain
            {
                Id = 1,
                Name = "Test terrain"
            });

            context.Users.Add(new IdentityUser
            {
                Id = TestUserId,
                UserName = "user@test.com",
                Email = "user@test.com",
                NormalizedEmail = "USER@TEST.COM",
                NormalizedUserName = "USER@TEST.COM"
            });

            context.Users.Add(new IdentityUser
            {
                Id = "admin-id",
                Email = AdminEmail,
                UserName = AdminEmail,
                NormalizedEmail = AdminEmail.ToUpper(),
                NormalizedUserName = AdminEmail.ToUpper()
            });

            context.Destinations.Add(new Destination
            {
                Id = 1,
                Name = "Test Destination",
                Description = "Desc",
                ImageUrl = "/img",
                Location = "Loc",
                LocationUrl = "/map",
                TicketPrice = 10m,
                PublishedOn = DateTime.Now,
                PublisherId = TestUserId,
                TerrainId = 1,
                IsDeleted = false
            });

            context.SaveChanges();

            reservationService = new ReservationService(context);
        }

        private ReservationController CreateController(string userId, string email)
        {
            var controller = new ReservationController(reservationService);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim(ClaimTypes.Name, email)
            }, "mock"));

            controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };

            return controller;
        }

        [Test]
        public async Task GetCreateModelAsync_ReturnsModel_WhenExists()
        {
            var model = await reservationService.GetCreateModelAsync(1);
            Assert.NotNull(model);
            Assert.That(model.DestinationId, Is.EqualTo(1));
        }

        [Test]
        public async Task GetCreateModelAsync_ReturnsNull_WhenMissing()
        {
            var model = await reservationService.GetCreateModelAsync(999);
            Assert.IsNull(model);
        }

        [Test]
        public void CreateReservationAsync_Throws_WhenModelNull()
        {
            Assert.ThrowsAsync<ArgumentException>(() =>
                reservationService.CreateReservationAsync(null, TestUserId));
        }

        [Test]
        public void CreateReservationAsync_Throws_WhenUserNull()
        {
            var model = new ReservationCreateViewModel
            {
                DestinationId = 1,
                PeopleCount = 2,
                Date = DateTime.Now
            };

            Assert.ThrowsAsync<ArgumentException>(() =>
                reservationService.CreateReservationAsync(model, null));
        }

        [Test]
        public async Task CreateReservationAsync_SuccessfullyCreates()
        {
            var model = new ReservationCreateViewModel
            {
                DestinationId = 1,
                PeopleCount = 3,
                Date = DateTime.Today,
                TicketPrice = 10m
            };

            await reservationService.CreateReservationAsync(model, TestUserId);

            Assert.That(context.Reservations.Count(), Is.EqualTo(1));
        }

        [Test]
        public void CreateReservationAsync_Throws_IfDestinationDeleted()
        {
            context.Destinations.First().IsDeleted = true;
            context.SaveChanges();

            var model = new ReservationCreateViewModel
            {
                DestinationId = 1,
                PeopleCount = 2,
                Date = DateTime.Today
            };

            Assert.ThrowsAsync<ArgumentException>(() =>
                reservationService.CreateReservationAsync(model, TestUserId));
        }

        [Test]
        public async Task GetUserReservationsAsync_ReturnsOnlyUser()
        {
            context.Reservations.Add(new Reservation
            {
                DestinationId = 1,
                UserId = TestUserId,
                PeopleCount = 2,
                TicketPrice = 10m,
                Date = DateTime.Today,
                CreatedOn = DateTime.Now
            });

            context.Reservations.Add(new Reservation
            {
                DestinationId = 1,
                UserId = "other",
                PeopleCount = 2,
                TicketPrice = 10m,
                Date = DateTime.Today,
                CreatedOn = DateTime.Now
            });

            context.SaveChanges();

            var result = await reservationService.GetUserReservationsAsync(TestUserId);

            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetUserReservationsAsync_ReturnsEmpty_WhenNone()
        {
            var result = await reservationService.GetUserReservationsAsync("nope");
            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task Controller_CreateGet_NotFound_IfInvalidId()
        {
            var controller = CreateController(TestUserId, "user@mail.com");
            var result = await controller.Create(999);
            Assert.IsInstanceOf<NotFoundResult>(result);
        }

        [Test]
        public async Task Controller_CreateGet_ReturnsView()
        {
            var controller = CreateController(TestUserId, "user@mail.com");
            var result = await controller.Create(1);
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public async Task Controller_CreatePost_ReturnsView_WhenModelInvalid()
        {
            var controller = CreateController(TestUserId, "user@mail.com");
            controller.ModelState.AddModelError("err", "error");

            var model = new ReservationCreateViewModel();

            var result = await controller.Create(model);

            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public async Task Controller_CreatePost_RedirectsOnSuccess()
        {
            var controller = CreateController(TestUserId, "user@mail.com");

            var model = new ReservationCreateViewModel
            {
                DestinationId = 1,
                PeopleCount = 2,
                Date = DateTime.Today,
                TicketPrice = 10m
            };

            var result = await controller.Create(model);

            Assert.IsInstanceOf<RedirectToActionResult>(result);

            var redirect = result as RedirectToActionResult;
            Assert.That(redirect.ActionName, Is.EqualTo("My"));
        }

        [Test]
        public async Task Controller_My_ReturnsUserReservations()
        {
            context.Reservations.Add(new Reservation
            {
                DestinationId = 1,
                UserId = TestUserId,
                PeopleCount = 2,
                TicketPrice = 10m,
                Date = DateTime.Today,
                CreatedOn = DateTime.Now
            });
            context.SaveChanges();

            var controller = CreateController(TestUserId, "u@mail.com");

            var result = await controller.My();

            Assert.IsInstanceOf<ViewResult>(result);

            var model = (result as ViewResult).Model as IEnumerable<ReservationListViewModel>;
            Assert.That(model.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task Controller_Admin_ReturnsForbidden_ForNonAdmin()
        {
            var controller = CreateController(TestUserId, "random@mail.com");

            var result = await controller.Admin();

            Assert.IsInstanceOf<ForbidResult>(result);
        }

        [Test]
        public async Task Controller_Admin_ReturnsView_ForAdmin()
        {
            var controller = CreateController("admin-id", AdminEmail);

            var result = await controller.Admin();

            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public async Task Controller_Admin_ReturnsEmptyList_WhenNoReservations()
        {
            var controller = CreateController("admin-id", AdminEmail);

            var result = await controller.Admin() as ViewResult;
            var model = result.Model as IEnumerable<ReservationListViewModel>;

            Assert.That(model.Count(), Is.EqualTo(0));
        }
    }
}
