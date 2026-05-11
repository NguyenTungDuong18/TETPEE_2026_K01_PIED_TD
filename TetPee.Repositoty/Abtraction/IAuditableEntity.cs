namespace TetPee.Repositoty.Abtraction;

public interface IAuditableEntity
{
    public DateTimeOffset CreatedAt { get; set; }//Dòng dữ liệu này đc tạo ra khi nào
    public DateTimeOffset? UpdatedAt { get; set; }//Dòng dữ liệu này đc cập nhật lần cuối khi nào
}