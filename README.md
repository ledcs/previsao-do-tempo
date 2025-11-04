# ☀️ Previsão do Tempo por CEP (Projeto ASP.NET)

Este é um projeto web em ASP.NET Core com o objetivo de consultar a previsão do tempo para uma localidade brasileira a partir da inserção de um CEP.

## ✨ Funcionalidades

O fluxo da aplicação foi planejado da seguinte forma:

1.  O usuário insere um CEP em um formulário.
2.  A aplicação consome a API pública [ViaCEP](https://viacep.com.br/) para obter os dados de localidade (Cidade e Estado) referentes àquele CEP.
3.  **(Próximo Passo)** A aplicação usará o nome da cidade obtido para consultar uma API de previsão do tempo (como OpenWeatherMap, INMET, etc.).
4.  O resultado da previsão é exibido para o usuário.

**Status Atual:** A primeira etapa (Consulta de CEP via ViaCEP) está implementada e o formulário web está funcional.

## 🚀 Tecnologias Utilizadas

* **[C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)**
* **[ASP.NET Core Razor Pages](https://learn.microsoft.com/pt-br/aspnet/core/razor-pages)**: Framework web para construção da interface.
* **[HttpClient](https://learn.microsoft.com/pt-br/dotnet/api/system.net.http.httpclient)**: Para consumir a API externa do ViaCEP.
* **[GitHub Codespaces](https://github.com/features/codespaces)**: Ambiente de desenvolvimento na nuvem.

## 💻 Como Executar

Este projeto foi configurado para rodar facilmente no GitHub Codespaces.

1.  **Abra no Codespace:** Clique no botão `< > Code` -> "Codespaces" -> "Create codespace".
2.  **Aguarde a inicialização:** O ambiente será configurado automaticamente.
3.  **Rode o projeto:** Abra um novo terminal (`Ctrl + Shift + '` ou `Cmd + Shift + '`) e digite o comando:
    ```bash
    dotnet watch run
    ```
4.  **Acesse a aplicação:** O Codespace irá encaminhar a porta 5000 (ou similar) automaticamente. Clique na aba **"Portas" (Ports)** no painel inferior e abra a URL pública informada.