using Microsoft.EntityFrameworkCore;
using TheFinalSolution.DataAccessLayer;
using TheFinalSolution.Repository;
using TheFinalSolution.Repository.Interfaces;

namespace TheFinalSolution;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();
        builder.Services.AddDbContext<RpgContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
        });
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(build =>
            {
                build.AllowAnyOrigin();
                build.AllowAnyHeader();
                build.AllowAnyMethod();
            });
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseCors();
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}