using Jordbruksverket.Data;
using Microsoft.EntityFrameworkCore;

namespace Jordbruksverket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();
            builder.Services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultconnection")));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
                options.JsonSerializerOptions.WriteIndented = true; // Optional for readable formatting
            });
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost",
                    builder => builder.WithOrigins("http://localhost:3000")
                                      .AllowAnyMethod()
                                      .AllowAnyHeader());
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("AllowLocalhost");

            app.MapGet("/owners", async (AppDbContext context) =>
            {
                var owners = await context.Owners
                    .Include(o => o.Pets)
                    .ToListAsync();
                return Results.Ok(owners);
            });

            app.MapGet("/pets", async (AppDbContext context) =>
            {
                var pets = await context.Pets.ToListAsync();
                return Results.Ok(pets);
            });


            app.Run();
        }
    }
}