using Microsoft.EntityFrameworkCore;
using UserManagementAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("UserDb"));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseMiddleware<UserManagementAPI.Middleware.LoggingMiddleware>();
app.UseMiddleware<UserManagementAPI.Middleware.ErrorHandlingMiddleware>();
app.UseMiddleware<UserManagementAPI.Middleware.AuthenticationMiddleware>();

app.Run();