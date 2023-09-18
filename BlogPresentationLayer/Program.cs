using Blog.Infrastructure.Context;
using Blog.Infrastructure.Repositories;
using Blog_ApplicationLayer.Services.AppUserService;
using Domain.Entities.Concrete;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BlogContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));
builder.Services.AddIdentity<AppUser, AppRole>(x =>
{
    x.Password.RequiredLength = 6;
}).AddEntityFrameworkStores<BlogContext>();

//i? bitti?inden ramden silinsin
builder.Services.AddTransient<IAppUserService,AppUserService>();
builder.Services.AddTransient<IAppUserRepository,AppUserRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
