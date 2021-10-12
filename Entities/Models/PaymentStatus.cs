using System.ComponentModel.DataAnnotations;

namespace Aduaba.Entities.Models
{
    public class PaymentStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }
    }
}