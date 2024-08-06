using gameStoreApi.Data;
using gameStoreApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapGamesEndponts();
app.MapGenresEndpoints();

await app.MigrateDbAsync();

app.Run();
