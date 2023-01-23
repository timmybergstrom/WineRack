using WineRack.UI.Contracts;

namespace WineRack.UI.Services;

public class BaseServices : IBaseServices
{
    protected HttpClient client { get;set; }

    public BaseServices(HttpClient client)
    {
        this.client = client;
    }
}