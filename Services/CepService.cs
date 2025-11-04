using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class CepService
{
    private readonly HttpClient _httpClient;

    public CepService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Método que consulta o CEP na API ViaCEP
    public async Task<CepInfo> BuscarCepAsync(string cep)
    {
        var url = $"https://viacep.com.br/ws/{cep}/json/";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<CepInfo>(json);
    }
}
