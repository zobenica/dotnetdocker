using Microsoft.EntityFrameworkCore;
using myWebApp.Data;
using myWebApp.Startup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.RegisterApplicationServices(builder.Configuration);

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        // add 10 seconds delay to ensure the db server is up to accept connections
        // this won't be needed in real world application
        System.Threading.Thread.Sleep(10000);
        var context = services.GetRequiredService<SchoolContext>();
        var created = context.Database.EnsureCreated();

    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }
}


app.ConfigureMiddleware();
app.RegisterEndpoints();

app.MapRazorPages();

app.Run();


