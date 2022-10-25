var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hi testing the workflow from VS to Azure");

app.Run();
