using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Seller: BaseEntity<Guid>, IAuditableEntity
{
    public required string TaxCode { get; set; }
    public required string CompanyName { get; set; }
    public required string CompanyAddress { get; set; }
    
    public Guid UserId { get; set; }//1 user có th là 1 seller
    public User User { get; set; }// để ORM biết có mối quan hệ với nhau, sau xuống DB

    public ICollection<Product> Products { get; set; } = new List<Product>();
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }
}