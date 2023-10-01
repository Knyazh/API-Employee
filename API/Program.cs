using API.Contexts;
using API.Repositories.Employee;
using Employee.Application.Mapper;
using Employee.Application.Repositories.Employee;
using Microsoft.EntityFrameworkCore;

namespace API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddSwaggerGen();


        builder.Services.AddAutoMapper(typeof(EmployeeProfile).Assembly);

        builder.Services
               .AddDbContext<EmployeeDbContext>(o =>
               {
                   o.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
               });


        builder.Services.AddScoped<IEmployeeReadRepository, EmployeeReadRepository>();
        builder.Services.AddScoped<IEmployeeWriteRepository, EmployeeWriteRepository>();


        var app = builder.Build();

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