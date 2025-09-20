using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;

[Generator]
public class SaudacaoGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(ctx =>
        {
            var sourceCode = @"
namespace CodigoGerado {
    public static class Saudacao {
        public static void DigaOla() {
            System.Console.WriteLine(""Olá pessoal, aqui é o gerador de código a seu dispor !!!"");
        }
    }
}";
            ctx.AddSource("OlaGerado.g.cs", SourceText.From(sourceCode, Encoding.UTF8));
        });
    }
}
