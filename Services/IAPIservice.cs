using BlazorApp.Models;

namespace BlazorApp.Services
{
    public interface IAPIservice
    {
        Task<List<Emisor>> GetEmisor();
    }
}
