using TetPee.Repository.Abtraction;

namespace TetPee.Repository.Entity;

public class CartDetail: BaseEntity<Guid>, IAuditableEntity
{
    public Guid CartId { get; set; }
    public Cart Cart { get; set; }
    
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }
}