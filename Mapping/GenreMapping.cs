using gameStoreApi.Dtos;
using gameStoreApi.Entities;

namespace gameStoreApi.Mapping;

public static class GenreMapping
{
    public static GenreDto ToDto(this Genre genre)
    {
        return new GenreDto(genre.Id, genre.Name);
    }
}
