using Microsoft.EntityFrameworkCore;
using Quartz;
using TetPee.Api.Extensions;
using TetPee.Middlewares;
using TetPee.Repository.Data;

using UserSrivice = TetPee.Service.User;
using CategorySrivice = TetPee.Service.Category;
using SellerSrivice = TetPee.Service.Seller;
using IdentitySrivice = TetPee.Service.Identity;
using JwtSrivice = TetPee.Service.JwtService;
using ProductSrivice = TetPee.Service.Product;
using MediaService = TetPee.Service.MediaService;
using CloudinaryService = TetPee.Service.CloudinaryService;
using MailService = TetPee.Service.MailService;
using CartService = TetPee.Service.Cart;
using OrderService = TetPee.Service.Order;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
        )
    );

builder.Services.AddJwtServices(builder.Configuration);
builder.Services.AddSwaggerServices();
 builder.Services.AddScoped<UserSrivice.IService, UserSrivice.Service>();
 builder.Services.AddScoped<CategorySrivice.IService, CategorySrivice.Service>();
 builder.Services.AddScoped<SellerSrivice.IService, SellerSrivice.Service>();
 builder.Services.AddScoped<JwtSrivice.IJwtService, JwtSrivice.JwtServices>();
builder.Services.AddScoped<IdentitySrivice.IService, IdentitySrivice.Service>();
builder.Services.AddScoped<ProductSrivice.IService, ProductSrivice.Service>();
builder.Services.AddScoped<MediaService.IService, CloudinaryService.Service>();
builder.Services.AddScoped<MailService.IService, MailService.Service>();
builder.Services.AddScoped<CartService.IService, CartService.Service>();
builder.Services.AddScoped<OrderService.IService, OrderService.Service>();

builder.Services.AddQuartz(options =>
{
    var jobKey = new JobKey(nameof(ProcessTransactionPendingJob));

    options
        .AddJob<ProcessTransactionPendingJob>(jobKey)
        .AddTrigger(trigger =>
            trigger
                .ForJob(jobKey)
                .WithSimpleSchedule(schedule => schedule
                    .WithIntervalInMinutes(2)
                    .RepeatForever()
                )
        );
});
builder.Services.AddQuartzHostedService(options =>
{
    options.WaitForJobsToComplete = true;
});

builder.Services.AddTransient<GlobalExceptionHandlerMiddleware>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();//Bạn có được vào hệ thống hay kh
app.UseAuthorization();//Bạn là ai trong hệ thống
//Nếu kh có Autho thì mấy cái policy phân quyền trong controller sẽ kh có tác dụng

app.MapControllers();

app.Run();