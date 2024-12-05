using BookCatalogApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext (for SQL Server)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));  // Update with your connection string

// Add controllers
builder.Services.AddControllers();

// Add Swagger for API documentation
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Use Swagger only in Development environment
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();     // Enable Swagger
    app.UseSwaggerUI();   // Enable Swagger UI
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
