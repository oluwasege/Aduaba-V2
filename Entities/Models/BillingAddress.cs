﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aduaba.Models
{
    public class BillingAddress
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string ZipCode { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public string AplicationUserId { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}