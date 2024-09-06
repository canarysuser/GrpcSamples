using Microsoft.EntityFrameworkCore;
using Serilog;
using StreamingGrpcServer.Services;
using Serilog.Extensions.Logging;

namespace StreamingGrpcServer
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Verbose()
                
                .CreateLogger();

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ProductsDbContext>(options =>
            {
                options.UseSqlServer("server=(local);database=northwind;integrated security=sspi;trustservercertificate=true");
            });
            // Add services to the container.
            
            builder.Services.AddGrpc();
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<ProductDataService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}