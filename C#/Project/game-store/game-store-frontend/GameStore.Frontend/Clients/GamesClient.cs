using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient(HttpClient httpClient)
{
    // private readonly List<GameSummary> games = [
    // new(){
    // Id = 1,
    // Name = "Street Fig II",
    // Genre = "Fighting",
    // Price = 10.99M,
    // ReleaseDate = new DateOnly(2000,05,22)
    // },
    // new(){
    // Id = 2,
    // Name = "Street Fig I",
    // Genre = "Fighting",
    // Price = 14.99M,
    // ReleaseDate = new DateOnly(2002,05,22)
    // }];

    // private readonly Genre[] genres = new GenresClient(httpClient).GetGenres();

    public async Task<GameSummary[]> GetGamesAsync()
        => await httpClient.GetFromJsonAsync<GameSummary[]>("games") ?? [];

    public async Task AddGameAsync(GameDetails game)
        => await httpClient.PostAsJsonAsync("games", game);

    public async Task<GameDetails> GetGameAsync(int id)
        => await httpClient.GetFromJsonAsync<GameDetails>($"games/{id}") ??
           throw new Exception("Could not find game!");


    public async Task UpdateGameAsync(GameDetails updatedGame)
        => await httpClient.PutAsJsonAsync($"games/{updatedGame.Id}", updatedGame);

    public async Task DeleteGameAsync(int id)
        => await httpClient.DeleteAsync($"games/{id}");

    // private GameSummary GetGameSummaryById(int id)
    // {
    //     GameSummary? game = games.Find(game => game.Id == id);
    //     ArgumentNullException.ThrowIfNull(game);
    //     return game;
    // }

    // private Genre? GetGenreById(string? id)
    // {
    //     ArgumentException.ThrowIfNullOrWhiteSpace(id);
    //     return genres.FirstOrDefault(genre => genre.Id == int.Parse(id));
    // }
}