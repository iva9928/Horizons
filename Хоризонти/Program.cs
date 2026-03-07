using Horizons.Data;
using Horizons.Data.Models;
using Horizons.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddSession();

builder.Services.AddScoped<IDestinationService, DestinationService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<IAiService, AiService>();

var app = builder.Build();


// ================= CREATE ROLES + ASSIGN =================

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

    // ---------- CREATE ROLES ----------

    if (!await roleManager.RoleExistsAsync("Admin"))
        await roleManager.CreateAsync(new IdentityRole("Admin"));

    if (!await roleManager.RoleExistsAsync("Guide"))
        await roleManager.CreateAsync(new IdentityRole("Guide"));

    if (!await roleManager.RoleExistsAsync("User"))
        await roleManager.CreateAsync(new IdentityRole("User"));


    // ---------- ADMIN ROLE ----------

    var adminEmail = "admin@horizons.com";

    var admin = await userManager.FindByEmailAsync(adminEmail);

    if (admin != null)
    {
        if (!await userManager.IsInRoleAsync(admin, "Admin"))
        {
            await userManager.AddToRoleAsync(admin, "Admin");
        }
    }


    // ---------- GUIDE ROLES ----------

    var guideEmails = new[]
    {
        "ivan.petrov@horizons.com",
        "maria.stoyanova@horizons.com",
        "georgi.dimitrov@horizons.com",
        "elena.ivanova@horizons.com",
        "nikolay.kolev@horizons.com"
    };

    foreach (var email in guideEmails)
    {
        var guide = await userManager.FindByEmailAsync(email);

        if (guide != null)
        {
            if (!await userManager.IsInRoleAsync(guide, "Guide"))
            {
                await userManager.AddToRoleAsync(guide, "Guide");
            }
        }
    }
}


// ================= PIPELINE =================

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();