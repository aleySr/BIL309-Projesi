using MarketInfoSystem.Common;
using MarketInfoSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarketInfoSystem.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<IrsaliyeItem> IrsaliyeItems { get; set; }
        public DbSet<Irsaliye> Irsaliyeler { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BABICO-ULTRA\\SQLEXPRESS;Database=MarketDatabase1;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var modifiedEntites = ChangeTracker.Entries()
            .Where(x => x.State == EntityState.Modified || x.State == EntityState.Added).ToList();

            var date = DateTime.UtcNow;

            foreach (var item in modifiedEntites)
            {
                var entity = item.Entity as BaseEntity;

                if (item != null)
                    switch (item.State)
                    {
                        case EntityState.Added:
                            entity.CreatedDate = date;
                            break;
                        case EntityState.Modified:
                            entity.UpdatedDate = date;
                            break;
                    }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
