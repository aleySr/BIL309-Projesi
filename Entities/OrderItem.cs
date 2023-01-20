using MarketInfoSystem.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketInfoSystem.Entities
{
    public class OrderItem : BaseEntity
    {
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))] public Order Order { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))] public Product Product { get; set; }
    }
}
