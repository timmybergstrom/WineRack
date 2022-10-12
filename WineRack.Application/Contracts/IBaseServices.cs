namespace WineRack.Application.Contracts;

public interface IBaseServices
{
    Task<bool> IsDbAvailable();
}