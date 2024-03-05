/* Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal. */

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main()
    {
        string json = System.IO.File.ReadAllText("./dados.json");
        
        List<Dados> dadosList = JsonConvert.DeserializeObject<List<Dados>>(json);

        double media = 0, soma = 0;
 
        foreach (var dados in dadosList)
        {
            soma += dados.Valor;
        }   media = soma/dadosList.Count;
            int diasAcima = 0; 
            double maior=double.MaxValue, menor=double.MinValue;
            // Console.WriteLine(media);
            foreach (var dados in dadosList){
                if(dados.Valor >= media){
                    diasAcima++; 
                }
                if(dados.Valor>media){
                    maior=dados.Valor;
                }
                if(dados.Valor<media){
                    menor=dados.Valor;
                }
                
            } Console.WriteLine("O faturamento diário de {0} dias, foi superior a média mensal.", diasAcima);
                Console.WriteLine("O menor valor de faturamento ocorrido em um dia do mês foi:{0}",menor);
                Console.WriteLine("O maior valor de faturamento ocorrido em um dia do mês foi:{0}",maior);
    }
    public class Dados{
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}