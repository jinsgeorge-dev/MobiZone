using Microsoft.EntityFrameworkCore;

namespace ProductCatalog.Domain.DataBase
{
    public class CatalogDBContext: DbContext
    {
        public DbSet<ProductCatalog.Domain.Products.Product> Products { get; set; }

        public DbSet<ProductCatalog.Domain.Products.Image> Images{ get; set;}
        public DbSet<ProductCatalog.Domain.Products.Specification> Specifications { get; set; }
        public DbSet<ProductCatalog.Domain.Customers.User> User { get; set; }
        public DbSet<ProductCatalog.Domain.Customers.UserDetails> UserDetails { get; set; }

        

        public DbSet<ProductCatalog.Domain.Role.Roles> Role { get; set; }

        public DbSet<ProductCatalog.Domain.Order.PaymentDetails> PaymentDetails { get; set; }

        public DbSet<ProductCatalog.Domain.Order.OrderDetails> OrderDetails { get; set; }

        public DbSet<ProductCatalog.Domain.Order.OrderStatus> OrderStatus { get; set; }

        public DbSet<ProductCatalog.Domain.Products.LookUp> LookUp { get; set; }

        public DbSet<ProductCatalog.Domain.Order.CatalogOrder> CatalogOrder { get; set; }

        public DbSet<ProductCatalog.Domain.Cart.CartItem> CartItem { get; set; }


        public CatalogDBContext(DbContextOptions<CatalogDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //method for seed data to database
            modelBuilder.Seed();
        }
    }
}
