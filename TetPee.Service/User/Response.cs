namespace TetPee.Service.User;

public class Response
{
    //api định nghĩa controller
    //response thì để cho service
    //hàm này để trả ra cho frontend
    public class GetUserResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null;
        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;
        public string? ImageUrl { get; set; } = null;
        public string? PhoneNumber { get; set; } = null;
        public string? Address { get; set; }
        public string role { get; set; } = "User";
        public string? DateOfBirth { get; set; } = null;
    }
    
    public class GetALlUserResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null;
        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;
        public string? ImageUrl { get; set; } = null;
        public string role { get; set; } = "User";
    }
}