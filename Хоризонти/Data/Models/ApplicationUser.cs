using Microsoft.AspNetCore.Identity;
using Horizons.Data.Models;

public class ApplicationUser : IdentityUser
{
    public int Age { get; set; }

    public string? Bio { get; set; }

    public bool IsGuide { get; set; }

    public string? ProfileImageUrl { get; set; }   // 👈 добави това
}
