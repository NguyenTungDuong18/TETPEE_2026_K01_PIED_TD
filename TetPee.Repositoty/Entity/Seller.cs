using TetPee.Repository.Entity;
using TetPee.Repositoty.Abtraction;

namespace TetPee.Repositoty.Entity;

public class Seller:BaseEntity<Guid>, IAuditableEntity
{
   public string TaxCode { get; set; }
   public string CompanyName { get; set; }
   public string CompanyAddress { get; set; }
   
   public Guid UserId { get; set; }
   public User User { get; set; }
   
   public ICollection<Product> Products { get; set; } = new List<Product>();
    
    public DateTimeOffset CreatedAt { get; set; }//Dòng dữ liệu này đc tạo ra khi nào
    public DateTimeOffset? UpdatedAt { get; set; }//Dòng dữ liệu này đc cập nhật lần cuối khi nào
    
}