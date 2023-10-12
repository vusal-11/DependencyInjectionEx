using DependencyInjection.Data;
using DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>();
//Singleton,Transient,Scoped
//builder.Services.Add(new ServiceDescriptor(typeof(IProductRepository), typeof(InMemoryProductRepository), ServiceLifetime.Singleton));
//builder.Services.AddSingleton<IProductRepository>(new InMemoryProductRepository(true));

builder.Services.AddSingleton<IProductRepository>(_ => new InMemoryProductRepository(true));
builder.Services.AddSingleton<ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
