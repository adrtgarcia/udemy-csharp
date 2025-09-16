using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios;

public class Planeta
{
    public string? Nome { get; set; }
    public double Diametro { get; set; }
    public double Massa { get; set; }

    public Planeta(string nome, double diametro, double massa)
    {
        Nome = nome;
        Diametro = diametro;
        Massa = massa;
    }

    public static List<Planeta> GetPlanetas()
    {
        List<Planeta> planetas = new()
        {
            new Planeta("Mercúrio", 4879, 3.301e23),
            new Planeta("Vênus", 12104, 4.867e24),
            new Planeta("Terra", 12756, 5.972e24),
            new Planeta("Marte", 6792, 6.39e23),
            new Planeta("Júpiter", 142984, 1.898e27),
            new Planeta("Saturno", 120536, 5.683e26),
            new Planeta("Urano", 51118, 8.681e25),
            new Planeta("Netuno", 49528, 1.024e26)
        };
        return planetas;
    }
    public static List<Planeta> Filtrar(List<Planeta> lista, Predicate<Planeta> filtro)
    {
        List<Planeta> resultado = new List<Planeta>();
        foreach (Planeta planeta in lista)
        {
            if (filtro(planeta))
            {
                resultado.Add(planeta);
            }
        }
        return resultado;
    }

}
