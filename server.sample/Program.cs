using Server.Sample.Data;
using Server.Sample.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var dbContext = services.GetRequiredService<AppDbContext>();
        SeedData.Initialize(dbContext);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred while initializing the database: " + ex.Message);
        throw;
    }
}

app.MapGrpcService<GreeterService>();
app.MapGrpcService<PersonService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
