// See https://aka.ms/new-console-template for more information
using GamesDomainLibrary.Data;
using GamesDomainLibrary.Models;

GameLibraryContext gameLibraryContext = new GameLibraryContext();

foreach (Game game in gameLibraryContext.Games)
{
    Console.WriteLine($"{game.Id}. \"{game.Name}\"; {game.StudioDeveloper}; {game.Style}; {game.ReleaseDate}");
}
