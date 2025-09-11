Console.WriteLine("Enum");

Console.WriteLine(DiasSemana.Sexta);
Console.WriteLine((int)DiasSemana.Sexta);

Console.WriteLine(DiasSemana.Sabado);
Console.WriteLine((int)DiasSemana.Sabado);

int indice = 3;
var nomeEnum = (Categorias)indice;
Console.WriteLine(indice + " - " + nomeEnum);

enum DiasSemana
{
    Segunda,    //0
    Terça,      //1
    Quarta,     //2
    Quinta,     //3 
    Sexta,      //4
    Sabado,     //5
    Domingo     //6
}

enum Categorias
{
    Moda,
    Automotivo,
    Artes,
    Bebidas,
    Livros,
    Brinquedos
}

enum CodigoErro
{
    Nenhum = 0,
    Desconhecido = 1,
    ConexaoFalhou = 100,
    DadosInvalidos = 200
}