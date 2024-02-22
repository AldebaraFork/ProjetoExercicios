using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            string[] nomes = new string [10];
            int[] idade = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o nome da pessoa ");
                nomes[i] = Console.ReadLine();
            }




            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite a idade da pessoa ");
                idade[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
