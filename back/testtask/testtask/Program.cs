using Microsoft.EntityFrameworkCore;
using testtask.Data;
using testtask.Interfaces.HomeInterface;
using testtask.Interfaces.PersonInterface;
using testtask.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<HomeRepository>();
builder.Services.AddScoped<IHome, HomeRepository>();

builder.Services.AddScoped<PersonRepository>();
builder.Services.AddScoped<IPerson, PersonRepository>();

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

app.MapControllerRoute(
    name: "custom",
    pattern: "{controller=Person}/{action=Index}/{id?}");

app.Run();
