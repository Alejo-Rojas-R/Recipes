using Microsoft.EntityFrameworkCore;
using Recipes.API.Data;
using Recipes.WEB.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("https://localhost:8000")
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyeccion de dependencias al SQL server
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer("name=DefaultConnection"));

builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:8000") });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors();
    app.UseRouting();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
