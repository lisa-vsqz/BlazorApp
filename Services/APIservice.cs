using BlazorApp.Models;

namespace BlazorApp.Services
{
    public class APIservice : IAPIservice
    {

        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "http://apiservicios.ecuasolmovsa.com:3009";
        

        public APIservice() {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }
        public async Task<List<Emisor>> GetEmisor()
        {
            List<Emisor> listaEmisor;
            listaEmisor = await _httpClient.GetFromJsonAsync<List<Emisor>>($"api/Varios/GetEmisor");
            Console.WriteLine(listaEmisor);
            if (listaEmisor == null)
            {
                return new List<Emisor>();
            }
            return listaEmisor;
        }

    }
}
