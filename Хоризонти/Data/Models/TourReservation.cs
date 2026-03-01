using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizons.Data.Models
{
    public class TourReservation
    {
        [Key]
        public int Id { get; set; }

        // 🧭 Тур
        [Required]
        public int TourId { get; set; }

        [ForeignKey(nameof(TourId))]
        public Tour Tour { get; set; } = null!;

        // 👤 Потребител
        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        // 👥 Брой хора
        [Required]
        [Range(1, 20)]
        public int PeopleCount { get; set; }

        // 💰 Цена към момента на резервацията
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerPerson { get; set; }

        // 💵 Обща сума (НЕ се записва в базата)
        [NotMapped]
        public decimal TotalPrice => PricePerPerson * PeopleCount;

        // 📅 Дата на създаване
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        // 🟢 Статуси
        public bool IsApproved { get; set; } = false;
        public bool IsCancelled { get; set; } = false;
    }
}