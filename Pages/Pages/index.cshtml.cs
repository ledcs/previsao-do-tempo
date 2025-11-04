using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly CepService _cepService;
    public CepInfo DadosCep { get; set; }
    public string Cep { get; set; }

    public IndexModel(CepService cepService)
    {
        _cepService = cepService;
    }

    public async Task OnGet(string cep)
    {
        if (!string.IsNullOrEmpty(cep))
        {
            DadosCep = await _cepService.BuscarCepAsync(cep);
            Cep = cep;
        }
    }
}