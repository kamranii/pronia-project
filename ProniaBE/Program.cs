using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProniaBE.Data;
using ProniaBE.Services;
using ProniaBE.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<ApplicationDbContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));
builder.Services.AddScoped<ProductService, ProductService>();
builder.Services.AddScoped<ImageService, ImageService>();
builder.Services.AddScoped<CustomerService, CustomerService>();
builder.Services.AddScoped<BrandService, BrandService>();
builder.Services.AddScoped<PostService, PostService>();



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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

