
using TetPee.Repositoty.Abtraction;
namespace TetPee.Repository.Entity;

public class Category: BaseEntity<Guid>, IAuditableEntity
{
    public required string Name { get; set; }
    
    public Guid? ParentId { get; set; } 
    public Category? Parent { get; set; }
    // Nếu mà là null, thì nó là thằng cha cao nhất
    // Nếu mà có giá trị, thì nó là thằng con của ParentId
    
    public ICollection<Category> Children { get; set; } = new List<Category>();
    public ICollection<product_category> ProductCategories { get; set; } = new List<product_category>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}