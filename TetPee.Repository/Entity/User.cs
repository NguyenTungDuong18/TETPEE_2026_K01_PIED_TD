using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class User: BaseEntity<Guid>, IAuditableEntity
{
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? ImageUrl { get; set; } = null;
    public string? PhoneNumber { get; set; } = null;
    public required string HashedPassword { get; set; }
    
    public string? Address { get; set; }
    public string Role { get; set; } = "User";// User, Seller, Admin
    public bool IsVerified { get; set; } = false;// khi user register, thì phải verify email hợp lệ
    public int VerifiedCode { get; set; }// Mã verify gửi về email
    public string? DateOfBirth { get; set; } = null;
    
    
    public Seller? Seller { get; set; }
    public Cart? Cart { get; set; } 
    public ICollection<Order> Orders { get; set; } = new List<Order>();// 1 user có 1 mảng order
    public DateTimeOffset CreateAt { get; set; }// dòng dữ liệu này được rạo ra khi nào
    public DateTimeOffset? UpdateAt { get; set; }// dòng dữ liệu này được cập nhật lần cuối khi nào
}