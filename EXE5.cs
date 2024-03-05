// Escreva um programa que inverta os caracteres de um string.

using System;
class Program
{
    static void Main()
    {
        string nome1, invertido;
        Console.Write("Digite seu nome: ");
        nome1 = Console.ReadLine();
        invertido = InverterString(nome1);
        Console.WriteLine($"Seu nome invertido é: {invertido}");
    }
    static string InverterString(string original)
    {
        int comprimento;
        char[] caracteres = original.ToCharArray();
        comprimento = caracteres.Length;
        for (int i = 0; i < comprimento / 2; i++)
        {
            char temp = caracteres[i];
            caracteres[i] = caracteres[comprimento - 1 - i];
            caracteres[comprimento - 1 - i] = temp;
        }
        return new string(caracteres);
    }
}
