using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Horizons.Data.ValidationConstants;
using Horizons.Data.Models;

namespace Horizons.Data.Models
{
    public class Terrain
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; } = null!;

        public virtual ICollection<Destination> Destinations { get; set; } = new HashSet<Destination>();
    }
}
