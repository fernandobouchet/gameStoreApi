using gameStoreApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games =
[
    new(1, "Street Fighter II", "Figthing", 19.99M, new DateOnly(1992, 7, 15)),
    new(2, "Final Fantasy XIV", "RolePLaying", 59.99M, new DateOnly(2010, 9, 30)),
    new(3, "FIFA 23", "Sports", 69.99M, new DateOnly(2022, 9, 27))
];

app.MapGet("games", () => games);

app.MapGet("/", () => "Hello World!");

app.Run();
