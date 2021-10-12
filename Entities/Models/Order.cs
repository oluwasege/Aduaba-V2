using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aduaba.Entities.Models
{
    public class Order
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public long OrderStatusId { get; set; }
        public string PaymentType { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public string OrderReferenceNumber { get; set; }
        public string OrderType { get; set; }
        public List<CartItem> OrderItems { get; set; } = new List<CartItem>();
        public virtual ShippingAddress ShippingAddress { get; set; }
        public long ShippingAddressId { get; set; }
        public virtual BillingAddress BillingAddress { get; set; }
        public long BillingAddressId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public string ShoppingCartId { get; set; }
        public decimal OrderTotal { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}