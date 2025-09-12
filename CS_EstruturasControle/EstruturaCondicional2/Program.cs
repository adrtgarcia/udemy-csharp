Console.WriteLine("Estrutura SWITCH");

/*
 
sintaxe:
    switch (variável / expressão) 
    { 
        case valor1: 
            instruções
            break;
        case valor2:
            instruções
            break;
        ...
        default:
            instruções
            break;
    } 
 
 */

Console.WriteLine("\nValor da compra: R$ 500,00");
Console.WriteLine("Informe o número de parcelas (1-3): ");
int parcelas = Convert.ToInt32(Console.ReadLine());

switch(parcelas)
{
    case 1:
        Console.WriteLine("1x de R$ 500,00");
        break;
    case 2:
        Console.WriteLine("2x de R$ 250,00");
        break;
    case 3:
        Console.WriteLine("3x de R$ 167,00");
        break;
    default:
        Console.WriteLine("Número de parcelas inválido");
        break;
}

string mes = "setembro";
Console.WriteLine($"\nQuantos dias tem o mês de {mes}?");

switch(mes)
{
    case "janeiro":
    case "marco":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("28 a 29 dias");
        break;
    case "abril":
    case "junho":
    case "setembro":
    case "novembro":
        Console.WriteLine("30 dias");
        break;
    default:
        Console.WriteLine("Mês inválido");
        break;
}

string cargo = "programador", funcao = "junior";
Console.WriteLine($"\nCargo informado: {cargo}");

switch(cargo)
{
    case "gerente":
        Console.WriteLine("bem-vindo gerente");
        break;
    case "programador":
        Console.WriteLine("bem-vindo programador");
        switch(funcao) 
        {
            case "junior":
                Console.WriteLine("você é júnior");
                break;
            case "pleno":
                Console.WriteLine("você é pleno");
                break;
            case "sênior":
                Console.WriteLine("você é sênior");
                break;
            default:
                Console.WriteLine("não foi possível identificar a função");
                break;
        }
        break;
    default:
        Console.WriteLine("não foi possível identificar o cargo");
        break;
}