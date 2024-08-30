## Estrutura Base para API REST com C# e ASP.Net

Este projeto fornece uma estrutura base para a criação de uma API REST utilizando Asp.Net Core 8. Ele inclui uma rota POST de exemplo que demonstra como configurar um endpoint simples recebendo um serviço por injeção de dependência.

## Configurando e Executando a API REST

Este guia resumido explica como configurar seu ambiente e executar a API REST de exemplo usando diretamente a IDE do Visual Studio.

### Pré-requisitos

* IDE Visual Studio [https://visualstudio.microsoft.com/pt-br/downloads/](https://visualstudio.microsoft.com/pt-br/downloads/)
* .NET 8 SDK

### Passo 1: Preparando o Código Fonte

1. **Copiar o Código:** Copie todos os arquivos de código fornecidos para um diretório em sua máquina.

### Passo 2: Executando o projeto

1. **Abrindo o projeto:**
    * Ao abrir o Visual Studio selecione a opção para abrir um projeto ou solução e abra o arquivo `Estrutura_Base.sln`.

2. **Construindo o Projeto:**
    * Utilize o menu de *Build* do Visual Studio (Build > Build Solution).

3. **Executando a Aplicação em modo de *Debug*:**
    * Selecione na interface a configuração *Debug* e qual perfil utilizar (`http` ou `IIS Express`)
    * Utilize o menu de *Debug* (Debug > Start Debugging) ou pressione `F5`.

4. **Parando a Aplicação:**
      * Clique no botão "Stop Debugging" na interface do Visual Studio, através do menu de *Debug* (Debug > Stop Debugging) ou pressione `Shift + F5`.

### Acessando a Aplicação

Na inicialização da aplicação o Visual Studio está configurado no arquivo `launchSettings.json` para que o navegador seja aberto na rota do swagger:

`https://localhost:44315/swagger/index.html` ou `http://localhost:5276/swagger/index.html`.

A interface do Swagger permite visualizar e interagir com os endpoints da sua API REST.
"# Imposto-de-renda" 
