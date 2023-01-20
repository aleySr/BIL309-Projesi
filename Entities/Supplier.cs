using MarketInfoSystem.Common;

namespace MarketInfoSystem.Entities
{
    public class Supplier : BaseEntity
    {
        public Supplier()
        {
            Irsaliyeler = new HashSet<Irsaliye>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Irsaliye> Irsaliyeler { get; set; }
    }
}
