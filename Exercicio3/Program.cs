//Exercicio da estrutura de condicional FOR

using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            for (int i = int.Parse(Console.ReadLine()); i <= 100; i++)
            {
                
                Console.WriteLine("O valor de i é: " +i);
            }
        }
    }
}

