// 1. Criar o construtor da aplicação
var builder = WebApplication.CreateBuilder(args);

// 2. ADICIONAR O SUPORTE PARA O SITE (Razor Pages)
builder.Services.AddRazorPages();

// 3. REGISTRAR O SEU SERVIÇO (CepService)
builder.Services.AddHttpClient<CepService>();

// 4. Construir a aplicação
var app = builder.Build();

// 5. Configurar
app.UseHttpsRedirection();
app.UseStaticFiles();

// 6. DIZER PARA O APP USAR AS PÁGINAS DO SITE
app.MapRazorPages();

// 7. Rodar a aplicação
app.Run();