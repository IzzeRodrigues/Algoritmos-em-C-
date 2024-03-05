// escreva um programa onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

using System;
class Programa {
    static void Main(){
        int numero;
        Console.WriteLine("Informe um número:");
        numero=int.Parse(Console.ReadLine());
        calculo(numero);
    }	
    static void calculo(int numero){
        int a=0,b=1;
        int fibonacci = b;
        while(fibonacci < numero)
        {
            fibonacci = a + b;
            a = b;
            b = fibonacci;
            
        } 
        if (fibonacci == numero){
            Console.WriteLine("Este número Existe na sequência de Fibonacci!");
        }else {
            Console.WriteLine("Este número não existe na sequência de Fibonacci");
        }
    }
}