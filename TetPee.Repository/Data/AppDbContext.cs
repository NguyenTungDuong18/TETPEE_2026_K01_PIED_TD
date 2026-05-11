using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TetPee.Repository.Entity;

namespace TetPee.Repository.Data;

public class AppDbContext : DbContext
{
    public static Guid UserId1 = Guid.NewGuid();
    public static Guid UserId2 = Guid.NewGuid();
    
    public static Guid SellerId1 = Guid.NewGuid();
    
    public static Guid CategoryParent1 = Guid.NewGuid();
    public static Guid CategoryParent2 = Guid.NewGuid();
    
    
    public static Guid ProductId1 = Guid.NewGuid();
    public static Guid ProductId2 = Guid.NewGuid();
    public static Guid ProductId3 = Guid.NewGuid();
    public static Guid ProductId4 = Guid.NewGuid();
    
    public static Guid OrderId1 = Guid.NewGuid();
    public static Guid OrderId2 = Guid.NewGuid();
    
    
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Khai báo các bảng sẽ được tạo trong Database
    public DbSet<User> Users { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductStorage> ProductStorages { get; set; }
    public DbSet<Storage> Storages { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CartDetail> CartDetails { get; set; }
    
    //Hàm này cho phép làm nhiều thứ vs những table dưới DB
    //vd 1/setup những cá role cho những cái field: email, firstname, lastname...
    // 2/ setup những cái role chho những mối quan hệ 1-N, N-N
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //=========================== User Configration =====================
        modelBuilder.Entity<User>(builder =>
        {
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.ImageUrl)
                .HasMaxLength(500);

            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(u => u.HashedPassword)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(u => u.Role)
                .IsRequired()
                .HasMaxLength(20)
                .HasDefaultValue("User");

            //Relationshio: User has on Seller (one-to-one)
            builder.HasOne(u => u.Seller)
                .WithOne(s => s.User)
                .HasForeignKey<Seller>(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            
                builder.HasOne(u => u.Cart)
                    .WithOne(s => s.User)
                    .HasForeignKey<Cart>(s => s.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            //DeleleBehavior.Cascode: khi một User bị xóa, thì Seller liên quan cũng sẽ bị xóa theo
            //DeleteBehavior.Retrict: Ngăn chặn việc xóa một User nếu có Seller liên quan tồn tại
            //(tham chiếu tới PK tồn tại)
            // 1 Project còn Task thì không xóa được
            //DeleteBehavior.NoAction: Không thực hiện hành động gì đặc biệt khi User bị xóa. (Gần giống Restrict, xử lí ở DB)
            //DeleteBehavior.SetNull: Khi một User bị xóa, thì môi trường UserId trong bảng Seller sẽ được đặt thành null
            //(Áp dụng khi trường FK cho phép null)

            List<User> users = new List<User>()
            {
                new User()
                {
                    Id = UserId1,
                    Email = "tuanle17062k5@gmail.com",
                    FirstName = "Tuan",
                    LastName = "Le",
                    HashedPassword = "hashed_password_1",
                },
                
                new User()
                {
                    Id = UserId2,
                    Email = "tuanle17062k6@gmail.com",
                    FirstName = "Tuan",
                    LastName = "Le",
                    HashedPassword = "hashed_password_1",
                }
            };

            for (int i = 0; i < 1000; i++)
            {
                var newUser = new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "tuan" + i + "@gmail.com",
                    FirstName = "Tuan",
                    LastName = "Le",
                    HashedPassword = "hashed_password_1" + i,
                };
                users.Add(newUser);
            }
            builder.HasData(users);
        });

        modelBuilder.Entity<Seller>(builder =>
        {
            builder.Property(s=>s.TaxCode)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(s=> s.CompanyName)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(s=> s.CompanyAddress)
                .IsRequired()
                .HasMaxLength(500);
            var seller = new List<Seller>()
            {
                new()
                {
                    Id = SellerId1,
                    TaxCode = "TAXCODE123",
                    CompanyName = "ABC Company",
                    CompanyAddress = "123 Main St, Cityville",
                    UserId = UserId1
                }
            };
            builder.HasData(seller);
        });

        modelBuilder.Entity<Category>(builder =>
        {
            var categories = new List<Category>()
            {
                new()
                {
                    Id = CategoryParent1,
                    Name = "Áo"
                },
                new()
                {
                    Id = CategoryParent2,
                    Name = "Quần"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Áo thể thao",
                    ParentId = CategoryParent1
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Áo ba lỗ",
                    ParentId = CategoryParent1,
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Quần Jean",
                    ParentId = CategoryParent2,
                }
            };
            builder.HasData(categories);
        });
        modelBuilder.Entity<Product>(builder =>
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(p => p.UrlImage)
                .HasMaxLength(500);

            builder.Property(p => p.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
            var products = new List<Product>()
            {
                new Product()
                {
                    Id = ProductId1,
                    Name = "Áo Thun Nam",
                    Description =
                        "Áo thun nam chất liệu cotton cấp cao, thoáng mát, phù hợp cho mọi hoạt động hằng ngày.",
                    UrlImage = "https://example.com/images/ao_thun_nam.jpg",
                    Price = 199000m,
                    SellerId = SellerId1
                },
                new Product()
                {
                    Id = ProductId2,
                    Name = "Quần Jeans Nữ",
                    Description =
                        "Quần jeans nữa dáng ôm, tôn dáng, chất liệu denim co dãn, phù hợp cho mọi dịp.",
                    UrlImage = "https://example.com/images/quan_jeans_nu.jpg",
                    Price = 399000m,
                    SellerId = SellerId1
                },

                new Product()
                {
                    Id = ProductId3,
                    Name = "Áo Sơ Mi Nam",
                    Description =
                        "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.",
                    UrlImage = "https://example.com/images/ao_so_mi_nam.jpg",
                    Price = 299000m,
                    SellerId = SellerId1
                },
                new Product()
                {
                    Id = ProductId4,
                    Name = "Chân Váy Nữ",
                    Description =
                        "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.",
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
                    UserId = UserId2,
                    Address = "Bien Hoa, Dong Nai",
                    TotalAmount = 100000m,
                    Status = "Completed"
                },
                new Order()
                {
                    Id = OrderId2,
                    UserId = UserId2,
                    Address = "Bien Hoa, Dong Nai",
                    TotalAmount = 100000m,
                    Status = "Completed"
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
                    ProductId = ProductId1,
                    Quantity = 2,
                    UnitPrice = 199000m
                },
                new OrderDetail()
                {
                    Id = Guid.NewGuid(),
                    OrderId = OrderId1,
                    ProductId = ProductId2,
                    Quantity = 2,
                    UnitPrice = 399000m
                },
                new OrderDetail()
                {
                    Id = Guid.NewGuid(),
                    OrderId = OrderId2,
                    ProductId = ProductId3,
                    Quantity = 2,
                    UnitPrice = 299000m
                }
            };
            builder.HasData(orderDetails);
        });
        modelBuilder.Entity<Product>()
            .HasOne(p=>p.Inventory)
            .WithOne(i=>i.Product)
            .HasForeignKey<Inventory>(i => i.ProGuidId);
        
        modelBuilder.Entity<Cart>(builder =>
        {
            builder.HasKey(c => c.Id); // Định nghĩa UserId là Primary Key
        });
    }
}