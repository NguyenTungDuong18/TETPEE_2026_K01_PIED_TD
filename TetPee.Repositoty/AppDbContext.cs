using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Entity;
using TetPee.Repositoty.Entity;

namespace TetPee.Repositoty;

public class AppDbContext : DbContext
{
    public static Guid userId = Guid.NewGuid();
    public static Guid userId2 = Guid.NewGuid();
    public static Guid Cate1 = Guid.NewGuid();
    public static Guid Cate2 = Guid.NewGuid();

    public static Guid ProddrcId1 = Guid.NewGuid();
    public static Guid ProddrcId2 = Guid.NewGuid();
    public static Guid ProddrcId3 = Guid.NewGuid();
    public static Guid ProddrcId4 = Guid.NewGuid();

    public static Guid SellerId1 = Guid.NewGuid();
    
    public static Guid OrderId2 = Guid.NewGuid();
    public static Guid OrderId1 = Guid.NewGuid();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        //đây là clss đại diện cho db
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductStorage> ProductStorages { get; set; }
    public DbSet<Storage> Storages { get; set; }
    public DbSet<Cart> Cart { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<product_category> product_category { get; set; }
    public DbSet<Category> Cates { get; set; }
    
    public DbSet<Cart>  Carts { get; set; }
    public DbSet<CartDetail> CartDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //hàm này cho phép đặt confict rule cho mối quan hệ hoặc field
        modelBuilder.Entity<User>(builder =>
        {
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasIndex(u => u.Email)
                .IsUnique(); //indexing

            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            // LastName - required, max 100 characters
            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(100);

            // ImageUrl - nullable, max 500 characters (URL)
            builder.Property(u => u.ImageUrl)
                .HasMaxLength(500);

            // PhoneNumber - nullable, max 20 characters
            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20);

            // HashedPassword - required, max 500 characters
            builder.Property(u => u.HashedPassword)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(u => u.Role)
                .IsRequired()
                .HasMaxLength(20)
                .HasDefaultValue("User");

            // Relationship: User has one Seller (one-to-one)
            builder.HasOne(u => u.Seller)
                .WithOne(s => s.User)
                .HasForeignKey<Seller>(s => s.UserId)
                .OnDelete(DeleteBehavior
                    .Cascade); //dòng này co nghĩa là nếu xóa cái rễ của 1 mối quan hệ thì tất cả những thằng liên can cũng mất theo luôn
            builder.HasOne(u => u.Cart).WithOne(x => x.User).HasForeignKey<Cart>(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
            //DeleteBehavior.Restrict: khi mà 1 dự án có những task thì không thể xóa
            //==> nếu dự án không có task thì có thể xóa được
            //DeleteBehavior.Cascade: có thể xóa 1 dự án đang có task luôn (khi 1 user bị xóa thì các seller liên quan cũng se bị xóa theo)
            //DeleteBehavior.SetNull: khi 1 user bị xóa, thì trường UserId trong bảng Seller sẽ được đtặ thành NULL
            // DeleteBehavior.NoAction: Không thực hiện hành động gì đặc biệt khi User bị xóa. ( Gàn giống Restrict, xử lí ở DB)
            
            
            
            
            List<User> users = new List<User>()
            {
                new()
                {
                    Id = userId,
                    Email = "tan182205@gmail.com",
                    FirstName = "Tan",
                    LastName = "Tran",
                    HashedPassword = "hashed_password_1",
                },
                new()
                {
                    Id = userId2,
                    Email = "tan182206@gmail.com",
                    FirstName = "Tan",
                    LastName = "Tran",
                    HashedPassword = "hashed_password_1",
                }
            };

            for (int i = 0; i <= 1000; i++)
            {
                var newUser = new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "Duong" + i,
                    FirstName = "Duong" + i,
                    LastName = "Duong" + i,
                    HashedPassword = "hashed_password_" + i,
                };
                users.Add(newUser);
            }

            builder.HasData(users);
        });

        modelBuilder.Entity<Seller>(builder =>
        {
            builder.Property(s => s.TaxCode).IsRequired().HasMaxLength(50);

            builder.Property(s => s.CompanyName).IsRequired().HasMaxLength(200);

            builder.Property(s => s.CompanyAddress).IsRequired().HasMaxLength(500);

            var Seller = new List<Seller>()
            {
                new()
                {
                    Id = SellerId1,
                    TaxCode = "TAXCODE123",
                    CompanyName = "ABC Company",
                    CompanyAddress = "123 Main st , Cityville",
                    UserId = userId,
                }
            };
            builder.HasData(Seller);
        });
        modelBuilder.Entity<Category>(builder =>
        {
            builder.Property(c => c.Name)
                .IsRequired();

            var categories = new List<Category>()
            {
                new Category()
                {
                    Id = Cate1,
                    Name = "Áo"
                },

                new Category()
                {
                    Id = Cate2,
                    Name = "Áo"
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "áo thun",
                    ParentId = Cate1,
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "áo thun",
                    ParentId = Cate2,
                }
            };

            for (int i = 0; i <= 1000; i++)
            {
                var newCate = new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "STT" + i,
                    ParentId = Cate1,
                };
                categories.Add(newCate);
            }

            builder.HasData(categories);
        });
        modelBuilder.Entity<Product>(builder =>
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(p => p.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.UrlImage)
                .IsRequired()
                .HasMaxLength(500);

            var products = new List<Product>()
            {
                new Product()
                {
                    Id = ProddrcId1,
                    Name = "Áo Thun Nam",
                    Description =
                        "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.",
                    UrlImage = "https://example.com/images/ao_thun_nam.jpg",
                    Price = 199000m,
                    SellerId = SellerId1
                },
                new Product()
                {
                    Id = ProddrcId2,
                    Name = "Quần Jeans Nữ",
                    Description = "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.",
                    UrlImage = "https://example.com/images/quan_jeans_nu.jpg",
                    Price = 399000m,
                    SellerId = SellerId1
                },
                new Product()
                {
                    Id = ProddrcId3,
                    Name = "Áo Sơ Mi Nam",
                    Description = "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.",
                    UrlImage = "https://example.com/images/ao_so_mi_nam.jpg",
                    Price = 299000m,
                    SellerId = SellerId1
                },
                new Product()
                {
                    Id = ProddrcId4,
                    Name = "Chân Váy Nữ",
                    Description = "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.",
                    UrlImage = "https://example.com/images/chan_vay_nu.jpg",
                    Price = 249000m,
                    SellerId = SellerId1
                }
            };
            builder.HasData(products);
        });
        modelBuilder.Entity<Order>(builder =>
        {
            var orders = new List<Order>()
            {
                new Order()
                {
                    Id = OrderId1,
                    UserId = userId2,
                    Address = "Bien Hoa, Dong Nai",
                    TotalAmount = 10000m,
                    Status = "Completed",
                },
                new Order()
                {
                    Id = OrderId2,
                    UserId = userId2,
                    Address = "Bien Hoa, Dong Nai",
                    TotalAmount = 10000m,
                    Status = "Completed",
                }
            };
            builder.HasData(orders);
        });

        modelBuilder.Entity<OrderDetail>(builder =>
        {
            var orderDetails = new List<OrderDetail>()
            {
                new OrderDetail()
                {
                    Id = Guid.NewGuid(),
                    OrderId = OrderId1,
                    ProductId = ProddrcId1,
                    Quantity = 2,
                    UnitPrice = 200m,
                },
                new OrderDetail()
                {
                    Id = Guid.NewGuid(),
                    OrderId = OrderId1,
                    ProductId = ProddrcId2,
                    Quantity = 2,
                    UnitPrice = 200m,
                },
                new OrderDetail()
                {
                    Id = Guid.NewGuid(),
                    OrderId = OrderId2,
                    ProductId = ProddrcId3,
                    Quantity = 2,
                    UnitPrice = 200m,
                },
            };
            builder.HasData(orderDetails);
        });

        modelBuilder.Entity<Cart>(builder =>
                   {
                      builder.HasKey(c => c.Id);
                   });

        modelBuilder.Entity<CartDetail>(builder =>
        {
            builder.HasOne(u => u.Cart).WithMany(u => u.CartDetails).HasForeignKey(u => u.CartId).OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(x => x.Product).WithMany(x => x.CartDetails).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);
        });
    }
}
// la 1 class quan trong của entity framework đại diện cho DB