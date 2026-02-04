using TetPee.Repository.Entity;
using TetPee.Repositoty.Abtraction;

namespace TetPee.Repositoty.Entity;

public class User:BaseEntity<Guid>, IAuditableEntity
{
    //thg đầu tiên sau dấu: là kế thừa còn sau dấu phẩy là implement
    //tách nhỏ CreateAt với UpdateAt để trong interface để sau này cần thì ghép vào dùng không thì thôi
    // public Guid Id { get; set; }
    
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? ImageUrl { get; set; } = null;
    public string? PhoneNumber { get; set; }
    public required string HashedPassword { get; set; }
    public string? Address { get; set; }
    public string Role { get; set; } = "User";//User, Seller , Admin
    public bool IsVerified { get; set; } = false;//khi user register, thì phải verify  email hợp lệ
    public int VerifyCode { get; set; } //Mã verìy gửi về Email
    
    public Seller? Seller { get; set; }
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    
    public DateTimeOffset CreatedAt { get; set; }//Dòng dữ liệu này đc tạo ra khi nào
    public DateTimeOffset? UpdatedAt { get; set; }//Dòng dữ liệu này đc cập nhật lần cuối khi nào
    // public bool IsDeleted { get; set; } = false;//Để tránh xung đột với các mối quan hệ trong DB (xóa mềm)
}