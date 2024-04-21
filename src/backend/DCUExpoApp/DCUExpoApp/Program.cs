using DCUExpoApp.Models;
using DCUExpoApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Swagger API Service using controller
builder.Services.AddCors(
    options =>
    {
        options.AddPolicy(
            "AllowCors",
            builder =>
            {
                builder.AllowAnyOrigin().AllowAnyMethod();
            });
    });

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbContext,ExpoContext>(options =>
     options.UseSqlServer());
builder.Services.AddTransient<CrudService, CrudService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowCors");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
