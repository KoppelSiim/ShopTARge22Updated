using ShopTARge22.Hubs; // Reference the Hubs folder
using ShopTARge22.Data;
using Microsoft.EntityFrameworkCore;
using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.ApplicationServices.Services;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR(); // Add SignalR service
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ISpaceshipsServices, SpaceshipsServices>();
builder.Services.AddScoped<IFileServices, FileServices>();
builder.Services.AddScoped<IRealestatesServices, RealestatesServices>();
builder.Services.AddScoped<IKindergartenServices, KirdergartenServices>();
builder.Services.AddScoped<ICocktailServices, CoctailServices>();
builder.Services.AddScoped<IEmailServices, EmailServices>();
builder.Services.AddDbContext<ShopTARge22Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

/*
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = false;
})
   // .AddEntityFrameworkStores<Providers.Database.EFProvider.DataContext>()
  //  .AddDefaultTokenProviders();
*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider
    (Path.Combine(builder.Environment.ContentRootPath, "multipleFileUpload")),
    RequestPath = "/multipleFileUpload"
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// Map the hub
app.MapHub<ChatHub>("/chatHub");
app.Run();
