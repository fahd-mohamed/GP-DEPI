using Microsoft.EntityFrameworkCore;
using HealiX.Infrastructure.Data;

namespace HealiX.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // السطرين دول بتوع Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // السطر اللي هيعرف قاعدة البيانات
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // السطر اللي ضفناه بتاع الـ Dashboard
            builder.Services.AddScoped<HealiX.Application.Interfaces.IDashboardService, HealiX.Infrastructure.Services.DashboardService>();

            var app = builder.Build();

            // تشغيل واجهة Swagger
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}