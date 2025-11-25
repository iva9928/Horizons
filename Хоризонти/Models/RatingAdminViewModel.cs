using Horizons.Models;

public class RatingAdminViewModel
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string DestinationName { get; set; } = string.Empty;
    public int Stars { get; set; }
    public string Comment { get; set; } = string.Empty;
    public string CreatedOn { get; set; } = string.Empty;
}
