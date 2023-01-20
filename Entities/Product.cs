using MarketInfoSystem.Common;

namespace MarketInfoSystem.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
            IrsaliyeItems = new HashSet<IrsaliyeItem>();
        }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal Stock { get; set; }
        public string StockUnit { get; set; }
        public decimal SelllingUnitPrice { get; set; }
        public ICollection<IrsaliyeItem> IrsaliyeItems { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
