namespace TetPee.Service.Seller;

public class Request
{
    public class CreateSellerRequest:Identity.Request.CreateSellerRequest
    {
        
        public string taxCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
    }
}