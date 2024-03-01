
using SPL.Data;
using SPL.Services;
using SPL.Services.IServices;

namespace SPL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IGraphService, GraphService>();
            builder.Services.AddScoped<ServiceDBContext>();

            builder.Services.AddControllers();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyAllowSpecificOrigins",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:5173", // ÔÊÐíµÄÔ´
                                            "http://127.0.0.1.com")
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("MyAllowSpecificOrigins");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}