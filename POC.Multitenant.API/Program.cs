using Microsoft.EntityFrameworkCore;
using POC.Multitenant.API.Extensions;
using POC.Multitenant.Data.Contexts;
using POC.Multitenant.Domain.Interfaces.Services;
using POC.Multitenant.Domain.Middleware;
using POC.Multitenant.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add IoC
builder.Services.AddCustomRepositories();
builder.Services.AddCustomServices();

// Current tenant service with scoped lifetime (created per each request)
builder.Services.AddScoped<ITenantService, TenantService>();

// Configuração do DbContext
builder.Services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<TenantResolver>();

app.MapControllers();

app.Run();
