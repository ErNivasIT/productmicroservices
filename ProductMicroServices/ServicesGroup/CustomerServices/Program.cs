using CustomerServices.Models;
using Microsoft.EntityFrameworkCore;
using ProductServices.Depedencies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.ManageDepedencies();
builder.Services.AddDbContext<CustomersDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("CustomersConn"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || 1==1)
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
