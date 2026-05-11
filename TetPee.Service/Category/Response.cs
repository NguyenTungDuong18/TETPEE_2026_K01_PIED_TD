namespace TetPee.Service.Category;

public class Response
{
    public class GetCategoriesResponse
    {
        public Guid Id { get; set; }
        public String Name { get; set; }= null;
        public Guid? ParentId { get; set; }
        public Repository.Entity.Category? Parent { get; set; }
        public List<GetCategoriesResponse> Children { get; set; }
    }
    
   
}