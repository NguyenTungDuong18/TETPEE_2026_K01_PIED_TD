namespace TetPee.Service.Seller;

public class Response
{//kế thừa user để nhận field của nó
    public class GetSellerResponse : User.Response.GetAllUsersResponse
    {
        public string? TaxCode { get; set; } = null;
        public string? CompanyName { get; set; } = null;
    }

    public class GetSellerByIdResponse : User.Response.GetUsersResponse
    {
        public string? CompanyName { get; set; } 
        public string? CompanuAddress { get; set; } 
        public string? TaxCode { get; set; } 
    }
}