
using System;
using System.Diagnostics.CodeAnalysis;


//mais pratica da estrutura repetitiva for
namespace Exercicio4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros voce quer somar?");
            int N, soma ,x ;
            
            N = int.Parse(Console.ReadLine());

            soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite um numero ");
               x = int.Parse(Console.ReadLine());
                soma = soma + x;


             

            }
            Console.WriteLine("Soma = " +soma);
        }
    }
}