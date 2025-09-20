using ApiVendas.Services.Abstractions;
using ApiVendas.Services.Dados;
using ApiVendas.Services.ImplaComDecorator;
using ApiVendas.Services.ImplaSemDecorator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Registrando o repositório
builder.Services.AddSingleton<ProdutoRepositorio>();

// 2. Serviço "Antes" (Legado)
builder.Services.AddScoped<CalculadoraPrecoProdutoLegado>();

// 3. Serviço "Depois" (com Decorators)
// A "mágica" acontece aqui! Registramos os decorators em cadeia.
// O contêiner de DI vai resolver isso para nós.
// A ordem de registro importa: o último registrado é o primeiro a ser executado (o mais externo).

// Passo base: a implementação principal
builder.Services.AddScoped<ICalculadoraPrecoProduto,CalculadoraPrecoProduto>();

// Decoramos a implementação base com o cálculo de imposto.
//builder.Services.AddScoped<ICalculadoraPrecoProduto>(provider =>
//    new ImpostoDecorator(
//        // Argumento 1: A calculadora base
//        provider.GetRequiredService<CalculadoraPrecoProduto>()
//    ));
builder.Services.Decorate<ICalculadoraPrecoProduto, ImpostoDecorator>();


// Decoramos o decorator de imposto com o de frete
//builder.Services.Decorate<ICalculadoraPrecoProduto, FreteDecorator>();
// Decoramos o decorator de frete com o de validação
//builder.Services.Decorate<ICalculadoraPrecoProduto, ValidacaoDecorator>();
//// Finalmente, decoramos tudo com o decorator de log (será o primeiro a executar)
builder.Services.Decorate<ICalculadoraPrecoProduto, LoggerDecorator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "Vendas API v1"));
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
