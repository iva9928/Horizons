using Horizons.Data;
using Microsoft.EntityFrameworkCore;


namespace Tests
{
    public static class TestDatabaseHelper
    {
        public static ApplicationDbContext CreateDb()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            return new ApplicationDbContext(options);
        }
    }
}