using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PuzzleShop.Core;
using PuzzleShop.Repos;
using PuzzleShopAPI;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "Version 1",
        Title = "Device API",
        Description = "API Project"
    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});

var connectionString = builder.Configuration.GetConnectionString("PuzzleShopConnection");
builder.Services.AddDbContext<PuzzleShopContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<BrandRepository>();

builder.Services.AddAutoMapper(typeof(AppAutoMapper).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
