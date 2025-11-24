using Horizons.Data;
using Horizons.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Horizons
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // -----------------------
            // DATABASE
            // -----------------------
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                                   ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            // -----------------------
            // SERVICES
            // -----------------------
            builder.Services.AddScoped<IDestinationService, DestinationService>();
            builder.Services.AddScoped<IReservationService, ReservationService>();

            // -----------------------
            // IDENTITY
            // -----------------------
            builder.Services
                .AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // -----------------------
            // ERROR HANDLING
            // -----------------------
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            // -----------------------
            // STATIC FILES (CRITICAL!)
            // -----------------------
            app.UseHttpsRedirection();

            // Това позволява зареждането на /images/... от wwwroot
            app.UseStaticFiles();

            // -----------------------
            // ROUTING + AUTH
            // -----------------------
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            // -----------------------
            // ROUTES
            // -----------------------
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}
