global using Takács_Krisztián_backend.Models.Dtos;
global using Takács_Krisztián_backend.Models;
global using Takács_Krisztián_backend.Repositories.Interfaces;
global using Takács_Krisztián_backend.Repositories.Services;
using System.Text.Json.Serialization;

namespace Takács_Krisztián_backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            builder.Services.AddScoped<OsztalynaploContext>();
            builder.Services.AddScoped<ITantargyInterface, TantargyService>();
            builder.Services.AddScoped<ITanarInterface, TanarService>();
            builder.Services.AddScoped<IJegyInterface, JegyService>();
            builder.Services.AddAuthorization(options =>
                {
                    options.AddPolicy("RequireAdminRole", policy =>
                        policy.RequireRole("Admin"));
                });

            builder.Services.AddCors(c => { c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.MapControllers();

            app.Run();
        }
    }
}