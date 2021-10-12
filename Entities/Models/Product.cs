using System;
using System.ComponentModel.DataAnnotations;

namespace Aduaba.Entities.Models
{
    public class Product
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string ImageUrl { get; set; }
        public virtual Category Category { get; set; } 
        public long CategoryId { get; set; }     
        public virtual Vendor Vendor { get; set; }    
        public bool IsInWishlist { get; set; } = false;
        public long VendorId { get; set; }
        public bool IsAvailable { get; set; }
    }
}
