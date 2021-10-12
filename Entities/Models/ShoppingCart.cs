using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Entities.Models
{
    public class ShoppingCart
    {
        [Key]
        public long ShoppingCartId { get; set; }
        public virtual List<CartItem> ShoppingCartItems { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public decimal TotalPrice { get; set; }
        public int NumberOfItems { get; set; }
    }
}
