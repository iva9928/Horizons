using Horizons.Data;
using Horizons.Data.Models;
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

            // ? OPTIONAL (само ако имаш пакета):
            // Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
            // Ако го нямаш -> остави реда закоментиран, иначе ще е червено и няма да компилира.
            // builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // -----------------------
            // SERVICES
            // -----------------------
            builder.Services.AddScoped<IDestinationService, DestinationService>();
            builder.Services.AddScoped<IReservationService, ReservationService>();
            builder.Services.AddScoped<IAiService, AiService>();

            // -----------------------
            // IDENTITY (ApplicationUser + Roles)
            // -----------------------
            builder.Services
                .AddIdentity<ApplicationUser, IdentityRole>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;

                    options.Password.RequireDigit = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequiredLength = 6;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI();

            // ? Нужно за Identity UI (Register/Login)
            builder.Services.AddRazorPages();

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
            // MIDDLEWARE
            // -----------------------
            app.UseHttpsRedirection();
            app.UseStaticFiles();

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