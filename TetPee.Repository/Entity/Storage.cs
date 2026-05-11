using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Storage: BaseEntity<Guid>, IAuditableEntity
{
    public decimal Price { get; set; }
    public required string Type { get; set; }
    
    public ICollection<ProductStorage> ProductStorages { get; set; } = new List<ProductStorage>();    
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }
}