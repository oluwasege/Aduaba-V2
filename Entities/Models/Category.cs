using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Entities.Models
{
    public class Category
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public long ProductId { get; set; }
        [Display(Name = "Product Description")]
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }



    }
}
