using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_5{

    //exercicio de estrutura de repetição for de soma 
class Program
{
    static void Main(string[] args)
    {

            int n, x, soma ;

            Console.WriteLine("Quantos numeros voce quer calcular? ");
             n =int.Parse(Console.ReadLine());
            x = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o numero: ");
                x = int.Parse(Console.ReadLine());
                soma = x + x;
                Console.WriteLine("A soma dos numeros é: " + soma);
            }

    }
}
}
