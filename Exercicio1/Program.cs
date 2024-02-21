//codigo basico de um programa em c#

using System;
using System.Diagnostics;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int y = int.Parse(Console.ReadLine());
            int soma = x + y;
            
        }
    }
}
