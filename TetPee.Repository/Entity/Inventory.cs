using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class Inventory: BaseEntity<Guid>, IAuditableEntity
{
    public int TotalSell { get; set; }
    public int TotalInStock { get; set; }
    
    public Guid ProGuidId { get; set; }
    public Product Product { get; set; }
    
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }
}