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

namespace HorizonsTests
{
    [TestFixture]
    public class DestinationServiceTests
    {
        private ApplicationDbContext GetDb()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new ApplicationDbContext(options);
        }

        [Test]
        public async Task AddDestination_ShouldAddCorrectly()
        {
            var db = GetDb();
            db.Terrains.Add(new Terrain { Id = 1, Name = "Mountain" });
            db.Users.Add(new IdentityUser { Id = "u1" });
            db.SaveChanges();

            var service = new DestinationService(db);

            var model = new DestinationAddViewModel
            {
                Name = "Test",
                Description = "Desc",
                ImageUrl = "img",
                PublishedOn = "01-01-2024",
                TerrainId = 1,
                TicketPrice = 20,
                Location = "Loc",
                LocationUrl = "Url"
            };

            await service.AddDestinationAsync(model, "u1");

            Assert.AreEqual(1, db.Destinations.Count());
            Assert.AreEqual("Test", db.Destinations.First().Name);
        }

        
        [Test]
        public void AddDestination_InvalidDate_ShouldThrow()
        {
            var db = GetDb();
            db.Terrains.Add(new Terrain { Id = 1, Name = "Forest" });
            db.Users.Add(new IdentityUser { Id = "u1" });
            db.SaveChanges();

            var service = new DestinationService(db);

            var model = new DestinationAddViewModel
            {
                Name = "Bad",
                Description = "Bad",
                ImageUrl = "Img",
                PublishedOn = "INVALID",
                TerrainId = 1
            };

            Assert.ThrowsAsync<FormatException>(() =>
                service.AddDestinationAsync(model, "u1"));
        }

      
        [Test]
        public async Task EditDestination_ShouldModifyCorrectly()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "publisher" });
            db.Terrains.Add(new Terrain { Id = 1, Name = "Old" });
            db.Terrains.Add(new Terrain { Id = 2, Name = "New" });

            db.Destinations.Add(new Destination
            {
                Id = 5,
                Name = "OldName",
                PublisherId = "publisher",
                PublishedOn = DateTime.Today,
                TerrainId = 1,
                ImageUrl = "old.jpg",
                Description = "Old",
                TicketPrice = 5,
                Location = "L1",
                LocationUrl = "Url1"
            });

            db.SaveChanges();

            var service = new DestinationService(db);

            var model = new DestinationEditViewModel
            {
                Id = 5,
                Name = "NewName",
                Description = "New",
                ImageUrl = "new.jpg",
                PublishedOn = "02-02-2024",
                TerrainId = 2,
                Location = "L2",
                LocationUrl = "Url2",
                TicketPrice = 15
            };

            await service.EditDestinationAsync(model, "publisher");

            var d = db.Destinations.First();

            Assert.AreEqual("NewName", d.Name);
            Assert.AreEqual(2, d.TerrainId);
            Assert.AreEqual("new.jpg", d.ImageUrl);
        }

       
        [Test]
        public void EditDestination_NotFound_ShouldThrow()
        {
            var db = GetDb();
            var service = new DestinationService(db);

            var model = new DestinationEditViewModel { Id = 999 };

            Assert.ThrowsAsync<InvalidOperationException>(() =>
                service.EditDestinationAsync(model, "any"));
        }

       
        [Test]
        public async Task Details_NotFound_ShouldReturnNull()
        {
            var db = GetDb();
            var service = new DestinationService(db);

            var result = await service.GetDestinationDetailsAsync(123, "u");

            Assert.IsNull(result);
        }

      
        [Test]
        public async Task AddToFavorites_ShouldAdd()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "u1" });
            db.SaveChanges();

            var service = new DestinationService(db);

            await service.AddToFavoritesAsync("u1", 55);

            Assert.AreEqual(1, db.UserDestinations.Count());
        }

      
        [Test]
        public async Task AddToFavorites_NoDuplicate()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "u1" });
            db.UserDestinations.Add(new UserDestination { UserId = "u1", DestinationId = 10 });

            db.SaveChanges();

            var service = new DestinationService(db);

            await service.AddToFavoritesAsync("u1", 10);

            Assert.AreEqual(1, db.UserDestinations.Count());
        }

       
        [Test]
        public async Task RemoveFavorites_ShouldRemove()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "u1" });
            db.UserDestinations.Add(new UserDestination { UserId = "u1", DestinationId = 3 });

            db.SaveChanges();

            var service = new DestinationService(db);

            await service.RemoveFromFavoritesAsync("u1", 3);

            Assert.AreEqual(0, db.UserDestinations.Count());
        }

        
        [Test]
        public async Task RemoveFavorites_NonExisting_ShouldNotCrash()
        {
            var db = GetDb();
            var service = new DestinationService(db);

            await service.RemoveFromFavoritesAsync("x", 99);

            Assert.Pass(); 
        }

      
        [Test]
        public void DeleteDestination_NotFound_ShouldThrow()
        {
            var service = new DestinationService(GetDb());

            Assert.ThrowsAsync<InvalidOperationException>(() =>
                service.DeleteDestinationAsync(999, "u"));
        }

       
        [Test]
        public async Task GetAllTerrains_ShouldReturnList()
        {
            var db = GetDb();

            db.Terrains.Add(new Terrain { Id = 1, Name = "A" });
            db.Terrains.Add(new Terrain { Id = 2, Name = "B" });

            db.SaveChanges();

            var service = new DestinationService(db);

            var list = await service.GetAllTerrainsAsync();

            Assert.AreEqual(2, list.Count());
        }

        
      
    }
    public class DestinationControllerTests
    {
        private ApplicationDbContext GetDb()
        {
            var o = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            return new ApplicationDbContext(o);
        }

        private DestinationController GetController(ApplicationDbContext db, string userId, string? username = null)
        {
            var service = new DestinationService(db);

            var controller = new DestinationController(service);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim(ClaimTypes.Name, username ?? userId)
            }, "TestAuth"));

            controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };

            return controller;
        }

        [Test]
        public async Task Add_Get_ShouldReturnView()
        {
            var db = GetDb();
            db.Terrains.Add(new Terrain { Id = 1, Name = "T" });
            db.SaveChanges();

            var c = GetController(db, "u1");
            var result = await c.Add();

            Assert.IsInstanceOf<ViewResult>(result);
        }

       
        [Test]
        public async Task Add_Post_InvalidModel_ShouldReturnView()
        {
            var db = GetDb();
            db.Terrains.Add(new Terrain { Id = 1, Name = "T" });
            db.SaveChanges();

            var c = GetController(db, "u1");
            c.ModelState.AddModelError("Name", "err");

            var model = new DestinationAddViewModel();

            var result = await c.Add(model);
            Assert.IsInstanceOf<ViewResult>(result);
        }

       

       
       

        [Test]
        public async Task Details_NotFound_ReturnsNotFound()
        {
            var db = GetDb();
            var c = GetController(db, "u");

            var result = await c.Details(999);

            Assert.IsInstanceOf<NotFoundResult>(result);
        }

      

        [Test]
        public async Task Edit_Get_NotFound()
        {
            var db = GetDb();
            var c = GetController(db, "u");

            var r = await c.Edit(123);
            Assert.IsInstanceOf<NotFoundResult>(r);
        }

       
       
        [Test]
        public async Task Edit_Post_InvalidModel_ReturnsView()
        {
            var db = GetDb();
            var c = GetController(db, "u");
            c.ModelState.AddModelError("x", "err");

            var m = new DestinationEditViewModel { Id = 1 };

            var r = await c.Edit(m);
            Assert.IsInstanceOf<ViewResult>(r);
        }

      

        [Test]
        public async Task Delete_Get_NotFound()
        {
            var db = GetDb();
            var c = GetController(db, "u");

            var result = await c.Delete(100);
            Assert.IsInstanceOf<BadRequestResult>(result);
        }

    }
    public class DestinationControllerTests_P4
        {
            private ApplicationDbContext GetDb()
            {
                var o = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
                return new ApplicationDbContext(o);
            }

            private DestinationController GetController(ApplicationDbContext db, string userId, string? name = null)
            {
                var service = new DestinationService(db);
                var c = new DestinationController(service);

                var user = new ClaimsPrincipal(new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim(ClaimTypes.Name, name ?? userId)
            }, "auth"));

                c.ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext { User = user }
                };

                return c;
            }

          

            [Test]
            public async Task AddToFavorites_Redirects()
            {
                var db = GetDb();
                var c = GetController(db, "u1");

                var r = await c.AddToFavorites(10);

                Assert.IsInstanceOf<RedirectToActionResult>(r);
            }

            [Test]
            public async Task RemoveFromFavorites_Redirects()
            {
                var db = GetDb();
                var c = GetController(db, "u1");

                var r = await c.RemoveFromFavorites(20);

                Assert.IsInstanceOf<RedirectToActionResult>(r);
            }

            
          
            [Test]
            public async Task Delete_Post_InvalidId_ReturnsBadRequest()
            {
                var db = GetDb();
                var c = GetController(db, "u");

                var m = new DestinationDeleteViewModel { Id = 100 };

                var r = await c.Delete(m);

                Assert.IsInstanceOf<BadRequestResult>(r);
            }

          
          
        }

    [TestFixture]
    public class DestinationServiceTests_P2
    {
        private ApplicationDbContext GetDb()
        {
            var o = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            return new ApplicationDbContext(o);
        }

        [Test]
        public void AddDestination_NullModel_ShouldThrow()
        {
            var db = GetDb();
            var service = new DestinationService(db);

            Assert.ThrowsAsync<NullReferenceException>(() =>
                service.AddDestinationAsync(null!, "u"));
        }

       

        [Test]
        public async Task GetAllDestinations_ShouldReturnEmptyIfNoneFound()
        {
            var db = GetDb();
            var service = new DestinationService(db);

            var list = await service.GetAllDestinationsAsync("u");

            Assert.AreEqual(0, list.Count());
        }

       
      

        [Test]
        public async Task RemoveFromFavorites_InvalidUser_ShouldNotThrow()
        {
            var db = GetDb();
            var service = new DestinationService(db);

            await service.RemoveFromFavoritesAsync("unknown", 1);

            Assert.Pass();
        }

       

        [Test]
        public async Task GetFavoriteDestinations_EmptyList()
        {
            var db = GetDb();
            var service = new DestinationService(db);

            var list = await service.GetFavoriteDestinationsAsync("u");

            Assert.AreEqual(0, list.Count());
        }

       
        [Test]
        public async Task AddDestination_ShouldAddCorrectly()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "u1", UserName = "User1" });
            db.Terrains.Add(new Terrain { Id = 1, Name = "Mountain" });
            db.SaveChanges();

            var service = new DestinationService(db);

            var model = new DestinationAddViewModel
            {
                Name = "Test",
                Description = "Desc",
                ImageUrl = "img",
                PublishedOn = "01-01-2024",
                TerrainId = 1,
                TicketPrice = 20,
                Location = "Loc",
                LocationUrl = "Url"
            };

            await service.AddDestinationAsync(model, "u1");

            var d = db.Destinations.First();
            Assert.AreEqual("Test", d.Name);
            Assert.AreEqual("u1", d.PublisherId);
        }

        [Test]
        public void AddDestination_InvalidDate_ShouldThrow()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "u1" });
            db.Terrains.Add(new Terrain { Id = 1, Name = "Forest" });
            db.SaveChanges();

            var service = new DestinationService(db);

            var model = new DestinationAddViewModel
            {
                Name = "Bad",
                Description = "Bad",
                ImageUrl = "Img",
                PublishedOn = "INVALID",
                TerrainId = 1,
                Location = "X",
                LocationUrl = "Y"
            };

            Assert.ThrowsAsync<FormatException>(() =>
                service.AddDestinationAsync(model, "u1"));
        }

   

        [Test]
        public void EditDestination_NotFound_ShouldThrow()
        {
            var service = new DestinationService(GetDb());

            var m = new DestinationEditViewModel { Id = 999 };

            Assert.ThrowsAsync<InvalidOperationException>(() =>
                service.EditDestinationAsync(m, "u"));
        }

        [Test]
        public async Task Details_NotFound_ShouldReturnNull()
        {
            var db = GetDb();
            var service = new DestinationService(db);

            var result = await service.GetDestinationDetailsAsync(123, "u");

            Assert.IsNull(result);
        }

      

        
        [Test]
        public async Task AddToFavorites_ShouldAdd()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "u1" });
            db.SaveChanges();

            var service = new DestinationService(db);

            await service.AddToFavoritesAsync("u1", 55);

            Assert.AreEqual(1, db.UserDestinations.Count());
        }

        [Test]
        public async Task AddToFavorites_NoDuplicate()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "u1" });
            db.UserDestinations.Add(new UserDestination { UserId = "u1", DestinationId = 10 });
            db.SaveChanges();

            var s = new DestinationService(db);

            await s.AddToFavoritesAsync("u1", 10);

            Assert.AreEqual(1, db.UserDestinations.Count());
        }

        [Test]
        public async Task RemoveFavorites_ShouldRemove()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "u1" });
            db.UserDestinations.Add(new UserDestination { UserId = "u1", DestinationId = 3 });
            db.SaveChanges();

            var s = new DestinationService(db);

            await s.RemoveFromFavoritesAsync("u1", 3);

            Assert.AreEqual(0, db.UserDestinations.Count());
        }

        [Test]
        public async Task RemoveFavorites_NonExisting_ShouldNotCrash()
        {
            var db = GetDb();
            var service = new DestinationService(db);

            await service.RemoveFromFavoritesAsync("u", 999);

            Assert.Pass();
        }

        
        
       

        
        [Test]
        public void DeleteDestination_NotFound_ShouldThrow()
        {
            var service = new DestinationService(GetDb());

            Assert.ThrowsAsync<InvalidOperationException>(() =>
                service.DeleteDestinationAsync(999, "u"));
        }

        [Test]
        public async Task AddRating_ShouldAddNew()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "u1" });
            db.Terrains.Add(new Terrain { Id = 2 });
            db.Destinations.Add(new Destination
            {
                Id = 1,
                Name = "A",
                Description = "D",
                ImageUrl = "i",
                Location = "L",
                LocationUrl = "U",
                PublishedOn = DateTime.Today,
                PublisherId = "u1",
                Publisher = db.Users.First(),
                TerrainId = 2,
                Terrain = db.Terrains.First()
            });

            db.SaveChanges();

            var s = new DestinationService(db);

            await s.AddRatingAsync("u1", 1, 5, "Great");

            Assert.AreEqual(1, db.Ratings.Count());
        }

       

        
        [Test]
        public async Task GetAllTerrains_ShouldReturnList()
        {
            var db = GetDb();

            db.Terrains.Add(new Terrain { Id = 1, Name = "A" });
            db.Terrains.Add(new Terrain { Id = 2, Name = "B" });
            db.SaveChanges();

            var s = new DestinationService(db);

            var list = await s.GetAllTerrainsAsync();

            Assert.AreEqual(2, list.Count());
        }

  
        [Test]
        public async Task Add_Get_ShouldReturnView()
        {
            var db = GetDb();
            db.Terrains.Add(new Terrain { Id = 1, Name = "T" });
            db.SaveChanges();

            var c = GetController(db, "u1");

            var result = await c.Add();

            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public async Task Add_Post_ValidModel_ShouldRedirect()
        {
            var db = GetDb();

            db.Users.Add(new IdentityUser { Id = "u1" });
            db.Terrains.Add(new Terrain { Id = 1, Name = "T" });
            db.SaveChanges();

            var c = GetController(db, "u1");

            var m = new DestinationAddViewModel
            {
                Name = "A",
                Description = "D",
                ImageUrl = "i",
                PublishedOn = "01-01-2024",
                TerrainId = 1,
                Location = "Loc",
                LocationUrl = "Url"
            };

            var r = await c.Add(m);

            Assert.IsInstanceOf<RedirectToActionResult>(r);
        }

     
        [Test]
        public async Task Add_Post_InvalidModel_ReturnsView()
        {
            var db = GetDb();

            db.Terrains.Add(new Terrain { Id = 1, Name = "T" });
            db.SaveChanges();

            var c = GetController(db, "u1");
            c.ModelState.AddModelError("Name", "err");

            var m = new DestinationAddViewModel();

            var r = await c.Add(m);

            Assert.IsInstanceOf<ViewResult>(r);
        }

      
     
        [Test]
        public async Task Details_NotFound_ReturnsNotFound()
        {
            var db = GetDb();
            var c = GetController(db, "u");

            var r = await c.Details(999);

            Assert.IsInstanceOf<NotFoundResult>(r);
        }

       
    
      
        [Test]
        public async Task Edit_Get_NotFound()
        {
            var db = GetDb();
            var c = GetController(db, "u");

            var r = await c.Edit(123);

            Assert.IsInstanceOf<NotFoundResult>(r);
        }

       
     

       
        [Test]
        public async Task Edit_Post_InvalidModel_ReturnsView()
        {
            var db = GetDb();
            var c = GetController(db, "u");
            c.ModelState.AddModelError("x", "err");

            var m = new DestinationEditViewModel { Id = 1 };

            var r = await c.Edit(m);
            Assert.IsInstanceOf<ViewResult>(r);
        }

      
        [Test]
        public async Task Delete_Get_NotFound()
        {
            var db = GetDb();
            var c = GetController(db, "u");

            var r = await c.Delete(100);

            Assert.IsInstanceOf<BadRequestResult>(r);
        }

       
        private DestinationController GetController(ApplicationDbContext db, string userId, string? username = null)
        {
            var service = new DestinationService(db);

            var controller = new DestinationController(service);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
        new Claim(ClaimTypes.NameIdentifier, userId),
        new Claim(ClaimTypes.Name, username ?? userId)
    }, "TestAuth"));

            controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };

            return controller;
        }


    }

}



