using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Data;
using TetPee.Service.MailService;

namespace TetPee.Service.Seller;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly MailService.IService _mailService;

    public Service(AppDbContext dbContext,  MailService.IService mailService)
    {
        _dbContext = dbContext;
        _mailService = mailService;
    }

    public async Task<Base.Response.PageResult<Response.GetSellerResponse>> GetSellers(string? searchTerm, int pageSize, int pageIndex)
    {
        var query = _dbContext.Sellers.Where(x => true);
        if (searchTerm != null)
        {
            query = query.Where(x =>
                x.User.FirstName.Contains(searchTerm) ||
                x.User.LastName.Contains(searchTerm) ||
                x.User.Email.Contains(searchTerm));
        }
        
        query = query.OrderBy(x => x.User.Email);
        query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        var selecctedQuery = query
            .Select(x => new Response.GetSellerResponse()
            {
                Id = x.User.Id,// chỗ này phải giống User.Id ở dưới
                Email = x.User.Email,
                FirstName = x.User.FirstName,
                LastName = x.User.LastName,
                ImageUrl = x.User.ImageUrl,
                role = x.User.Role,
                CompanyName = x.CompanyName,
                TaxCode = x.TaxCode
            });
        // var query = _dbContext.Users.Where(x => x.Role == "Seller");
        // // Tốc độ bị chậm đị vì có nhiều role
        //
        // if(searchTerm != null)
        // {
        //     query = query.Where(x => 
        //         x.FirstName.Contains(searchTerm) ||
        //         x.LastName.Contains(searchTerm) ||
        //         x.Email.Contains(searchTerm));
        // }
        //
        // query = query.OrderBy(x => x.Email);
        //
        // query = query
        //     .Skip((pageIndex - 1) * pageSize)
        //     .Take(pageSize);
        //
        // var selectedQuery = query
        //     .Select(x => new Response.GetSellersResponse()
        //     {
        //         Id = x.Id,
        //         Email = x.Email,
        //         FirstName = x.FirstName,
        //         LastName = x.LastName,
        //         ImageUrl = x.ImageUrl,
        //         Role = x.Role,
        //         CompanyName = x.Seller!.CompanyName,
        //         TaxCode = x.Seller.TaxCode
        //     });

        var listResult =  await selecctedQuery.ToListAsync();
        var totalItems = listResult.Count;

        var result = new Base.Response.PageResult<Response.GetSellerResponse>()
        {
            Items = listResult,
            PageIndex = pageIndex,
            PageSize = pageSize,
            Totalitems = totalItems,
        };
        return result;
    }

    public async Task<Response.GetSellerByIdResponse?> GetSellerById(Guid id)
    {
        var query = _dbContext.Sellers.Where(x => x.User.Id == id);// User.Id phải giống User.Id ở trên
        
        query = query.OrderBy(x => x.User.Email);
       
        var selecctedQuery = query
            .Select(x => new Response.GetSellerByIdResponse()
            {
                Id = x.Id,
                Email = x.User.Email,
                FirstName = x.User.FirstName,
                LastName = x.User.LastName,
                ImageUrl = x.User.ImageUrl,
                role = x.User.Role,
                CompanyName = x.CompanyName,
                TaxCode = x.TaxCode,
                PhoneNumber = x.User.PhoneNumber,
                Address = x.User.Address,
                CompanyAdress = x.CompanyName,
                DateOfBirth = x.User.DateOfBirth
            });
        var result = await selecctedQuery.FirstOrDefaultAsync();
        return result;
    }

    public async Task<string> CreateSeller(Request.CreateSellerRequest request)
    {
        var existingUser = _dbContext.Users.FirstOrDefault(x => x.Email == request.Email);
        
        if(existingUser != null)
        {
            throw new Exception("Email already exists");
        }
        
        var user = new Repository.Entity.User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password,
            Role = "Seller"
        };

        _dbContext.Add(user);

        var result = await _dbContext.SaveChangesAsync();
        
        if (result > 0)
        {
            var seller = new Repository.Entity.Seller()
            {
                CompanyAddress = request.CompanyAddress,
                CompanyName = request.CompanyName,
                TaxCode = request.TaxCode,
                UserId = user.Id,
            };
            
            _dbContext.Add(seller);
            
            var sellerResult = await _dbContext.SaveChangesAsync();

            await _mailService.SendMail(new MailContent()
{
    To = request.Email,
    Subject = "Welcome to TetPee",
    Body = $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='UTF-8'>
</head>
<body style='margin:0; padding:0; font-family: Arial, sans-serif; background-color:#f4f6f8;'>
    <table width='100%' cellpadding='0' cellspacing='0'>
        <tr>
            <td align='center'>
                <table width='600' cellpadding='0' cellspacing='0' style='background:#ffffff; border-radius:10px; overflow:hidden; box-shadow:0 4px 10px rgba(0,0,0,0.1);'>
                    
                    <!-- Header -->
                    <tr>
                        <td style='background: linear-gradient(90deg, #ff7e5f, #feb47b); padding:20px; text-align:center; color:white;'>
                            <h1 style='margin:0;'>Welcome to TetPee 🎉</h1>
                        </td>
                    </tr>

                    <!-- Body -->
                    <tr>
                        <td style='padding:30px; color:#333; line-height:1.6;'>
                            <h2 style='margin-top:0;'>Dear {request.FirstName} {request.LastName},</h2>

                            <p>
                                Thank you for registering as a <b>seller</b> on <b>TetPee</b>.
                                We are excited to have you on board and look forward to a successful partnership.
                            </p>

                            <p>
                                With TetPee, you can easily manage your products, reach more customers,
                                and grow your business efficiently.
                            </p>

                            <!-- Button -->
                            <div style='text-align:center; margin:30px 0;'>
                                <a href='#' 
                                   style='background:#ff7e5f; color:white; padding:12px 25px; text-decoration:none; border-radius:25px; display:inline-block; font-weight:bold;'>
                                    Start Selling Now
                                </a>
                            </div>

                            <p>
                                If you have any questions, feel free to contact our support team anytime.
                            </p>

                            <p>
                                Best regards,<br/>
                                <b>The TetPee Team</b>
                            </p>
                        </td>
                    </tr>

                    <!-- Footer -->
                    <tr>
                        <td style='background:#f4f6f8; padding:15px; text-align:center; font-size:12px; color:#888;'>
                            © 2026 TetPee. All rights reserved.
                        </td>
                    </tr>

                </table>
            </td>
        </tr>
    </table>
</body>
</html>"
});

            if (sellerResult > 0) return "Add Seller successfully";
            
            return "Add Seller fail";
        }
        
        return "Add Seller fail";
    }
}