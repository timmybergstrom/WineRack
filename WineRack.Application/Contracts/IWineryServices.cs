namespace WineRack.Application.Contracts;

public interface IWineryServices : IAsyncServices
{
    Task<Winery> GetWineryFull(int wineryId);
    Task<List<WineryCountry>> GetWineryList();
}