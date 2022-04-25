using AssignmentC4.DbContext;
using AssignmentC4.Maping;
using AssignmentC4.Repositories.Implement;
using AssignmentC4.Repositories.Interface;
using AssignmentC4.Service.Implement;
using AssignmentC4.Service.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

var MyAllowSpecificOrigins = "_MyAllowSubdomainPolicy";
var myAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultContection"));
});
builder.Services.AddScoped(typeof(GenericInterface<>), typeof(GenericRepository<>));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration));
builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration));
builder.Services.AddScoped<IProductService, ProductsService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICartService, CartService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins, builder =>
    {
        builder.WithOrigins(@"http://localhost:3000")
            .AllowAnyMethod().WithMethods("GET","PUT","UPDATE")
            .AllowAnyHeader();
        ////Bật yêu cầu đa nguồn (CORS) trong ASP.NET Core
    });

});

builder.Services.AddControllers();
builder.Services.AddRazorPages();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors(myAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();
