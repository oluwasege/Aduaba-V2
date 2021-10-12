namespace Aduaba.Entities.Models
{
    public class OrderDetail
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string Username { get; set; }
        public long ProductId { get; set; }
        public int Quantity { get; set; }

        public decimal? UnitPrice { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}