using Microsoft.AspNetCore.Authentication.Cookies;
using RentalCar.DAL;

using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

{
    string connection = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(connection));
}
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                    options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });

builder.Services.AddAuthorization();
builder.Services.AddMvc(opt => opt.EnableEndpointRouting = false);
var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();


app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}");

app.Run();
