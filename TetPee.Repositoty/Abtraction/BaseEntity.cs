namespace TetPee.Repositoty.Abtraction;

public abstract class BaseEntity <TKey>
{
    public TKey Id { get; set; }//truyền vào kiểu dữ liệu ở TKey
    
    public bool IsDeleted { get; set; }
}