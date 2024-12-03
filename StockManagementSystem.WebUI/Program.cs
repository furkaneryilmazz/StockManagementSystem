using Microsoft.EntityFrameworkCore;
using Serilog;
using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Business.Concrete;
using StockManagementSystem.Data.Abstract;
using StockManagementSystem.Data.Context;
using StockManagementSystem.Data.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StockManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IStockTypeService, StockTypeManager>();
builder.Services.AddScoped<IStockTypeRepository, StockTypeRepository>();
builder.Services.AddScoped<IStockUnitService, StockUnitManager>();
builder.Services.AddScoped<IStockUnitRepository, StockUnitRepository>();
builder.Services.AddScoped<IStockService, StockManager>();
builder.Services.AddScoped<IStockQuantityUnitRepository, StockQuantityUnitRepository>();
builder.Services.AddScoped<IStockQuantityUnitService, StockQuantityUnitManager>();
builder.Services.AddScoped<IStockCurrencyUnitService, StockCurrencyUnitManager>();
builder.Services.AddScoped<IStockCurrencyUnitRepository, StockCurrencyUnitRepository>();
builder.Services.AddScoped<IStockClassService, IStockClassManager>();
builder.Services.AddScoped<IStockClassRepository, StockClassRepository>();


builder.Host.UseSerilog((ctx, lc) => lc
.WriteTo.Console().WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage(); 
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
