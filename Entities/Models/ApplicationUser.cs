using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Aduaba.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ResetPasswordToken { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string AvatarUrl { get; set; }
        public virtual IEnumerable<BillingAddress> BillingAddresses { get; set; }
        public virtual IEnumerable<ShippingAddress> ShippingAddresses { get; set; }
        public long ShippingAddressId { get; set; }
        public virtual IEnumerable<Card> Cards { get; set; }
        public long ShoppingCartId { get; set; }
        public virtual List<ShoppingCart> ShoppingCart { get; set; }
        public virtual IEnumerable<WishList> Wishlist { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
        public virtual IEnumerable<PaymentHistory> PaymentHistories { get; set; }
    }
}