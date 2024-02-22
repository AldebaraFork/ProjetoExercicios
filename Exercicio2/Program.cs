//Codigo basico de um programa em C#

//Estrutura de repetição wh
using System;
using System.Runtime.Serialization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma;

            soma = 0;

            while (soma <= 10)
            {
               soma = soma + 1;
                Console.WriteLine("Digite o numero: ");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A soma dos numeros digitados é: " + soma);
        }
    }
}