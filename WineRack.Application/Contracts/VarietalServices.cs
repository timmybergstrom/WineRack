namespace WineRack.Application.Contracts;

public interface IVarietalService : IAsyncServices
{
    Task<Dictionary<int, string>> VarietalDictionary();
}