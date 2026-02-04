using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Entity;
using TetPee.Repositoty.Entity;

namespace TetPee.Repositoty;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}
    public DbSet<User> Users { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductStorage>  ProductStorages { get; set; }
    public DbSet<Storage> Storages { get; set; }
    public DbSet<Cart> Cart { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<product_category> product_category { get; set; }
    public DbSet<Category> Cates { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder){}
}
// la 1 class quan trong của entity framework đại diện cho DB