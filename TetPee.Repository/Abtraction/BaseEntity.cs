namespace TetPee.Repository.Abtraction;

public abstract class BaseEntity<T>
{
    public T Id { get; set; }
    // Soft Delete: thay vì xóa dữ liệu database thì mình thay đổi trạng thái này
    // Giúp tránh xung đột khóa ngoại (Foreign Key Constraint)
    public bool IsDeleted { get; set; }
}