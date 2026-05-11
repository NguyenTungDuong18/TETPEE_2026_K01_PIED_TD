namespace TetPee.Service.Seller;

public class Response
{
    public class GetSellerResponse: User.Response.GetALlUserResponse
    {
        public string? CompanyName { get; set; }
        public string? TaxCode { get; set; }
    }

    public class GetSellerByIdResponse : User.Response.GetUserResponse
    {
        public string? CompanyName { get; set; }
        public string? CompanyAdress { get; set; }
        public string? TaxCode { get; set; }
    }
}