using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MS.PROM.BACKEND.MidasDTO;
using MS.PROM.BACKEND.Service;

var builder = WebApplication.CreateBuilder(args);




//
// void ConfigureServices(IServiceCollection services)
//{
//    services.AddLogging();
//}
// Your other configurations
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
 builder.Services.AddDbContextPool<MidasDataContext>(option => option.UseSqlServer(connectionString));
//when add new service regiter the service like userservice in below 
 builder.Services.AddScoped<UserService>();
 builder.Services.AddScoped<MatserDataService>();
// AddScoped - The AddScoped method registers the service with a scoped lifetime, the lifetime of a single request.

// Addsingleton  - The AddSingleton method creates a single instance of the service and uses it throughout the lifetime of the application.

// addsession - In this example, the AddSession method is used to configure the session settings, such as the name of the session cookie (".MyApplication.Session") and the expiration time (30 minutes).
// Then, the UseSession middleware is added to the application's pipeline, enabling the session services for the application.

// readonly - This means that the variable or object can be assigned a value at the class scope or in a constructor only.You cannot change the value or reassign a value to a readonly variable or object in any other method except the constructor 

//- Use `AddScoped` when you want to maintain state within the scope of an HTTP request or a defined context. -
//- Use `AddSingleton` when you want to share a single instance of a service throughout the entire application.
//}
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://promcoapiqas.midassit.com", "https://promcoapiqas.midassit.com")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || (app.Environment.IsProduction()))
{
    app.UseSwagger();
    app.UseSwaggerUI();




}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
//using MS.PROM.BACKEND;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        CreateHostBuilder(args).Build().Run();
//    }

//    public static IHostBuilder CreateHostBuilder(string[] args) =>
//        Host.CreateDefaultBuilder(args)
//            .ConfigureWebHostDefaults(webBuilder =>
//            {
//                webBuilder.UseStartup<Startup>();
//            });
//}