using System.ComponentModel.DataAnnotations;

namespace Aduaba.Entities.Models
{
    public class OrderStatus
    {
        
        public long Id { get; set; }
        
        public string Status { get; set; }    
        public bool PaymentStatus { get; set; }   
        public bool HasBeenShipped { get; set; }
    }
}