// Escreva um programa onde calcule o percentual de representação que cada estado teve dentro do valor total da distribuidora
using System;
class Programa
{
    static void Main()
    {
        var faturamentoPorEstado = new Dictionary<string, double>
        {
            {"SP", 67836.43},
            {"RJ", 36678.66},
            {"MG", 29229.88},
            {"ES", 27165.48},
            {"Outros", 19849.53}
        };

        double totalMensal = 0;
        foreach (var valorPorEstado in faturamentoPorEstado.Values);
            totalMensal += valorPorEstado;

        Console.WriteLine("Percentual de representação por estado:");
        foreach (var estado in faturamentoPorEstado.Keys)
            Console.WriteLine($"{estado}: {(faturamentoPorEstado[estado] / totalMensal) * 100:F2}%");
    }
}