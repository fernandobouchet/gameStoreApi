using gameStoreApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGamesEndponts();

app.Run();
