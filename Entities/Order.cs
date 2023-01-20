using MarketInfoSystem.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketInfoSystem.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }
        public bool IsCash { get; set; }
        [NotMapped] public bool IsPayed => PaymentDate != null;
        public DateTime? PaymentDate { get; set; }
        public decimal TotalCost { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))] public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
