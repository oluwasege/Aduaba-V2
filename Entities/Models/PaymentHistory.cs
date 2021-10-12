using System;
using System.ComponentModel.DataAnnotations;

namespace Aduaba.Entities.Models
{
    public class PaymentHistory
    {
        [Key]
        public long Id { get; set; }
        public virtual Order Order { get; set; }
        public string OrderNumber { get; set; }

        public virtual PaymentStatus PaymentStatus { get; set; }


        public int PaymentStatusId { get; set; }

        [Required]
        public DateTime LastModified { get; set; }
    }
}