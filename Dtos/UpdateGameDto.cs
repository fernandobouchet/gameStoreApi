namespace gameStoreApi;

public record class UpdateGameDto(string Name, string Genre, decimal Price, DateOnly ReleaseDate);
