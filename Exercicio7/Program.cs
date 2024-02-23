using System;
using System.Diagnostics;
using System.Globalization;


//treinozinho com vetor
namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            CultureInfo CI = CultureInfo.InvariantCulture;

            //aplicando o culture info nos numeros para que o programa aceite numeros com ponto e nao com virgula



            //aqui voce digita o tamanho do vetor que sera utilizado
            Console.WriteLine("Quantos numeros serão digitados: ");
            int n = int.Parse(Console.ReadLine());
            double[] vetor = new double[n];


            //aqui voce digita os numeros que serao utilizados
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º numero: ");
                vetor[i] = double.Parse(Console.ReadLine(), CI);
            }

            //aqui voce mostra os numeros que foram digitados
            Console.WriteLine("Os numeros digitados foram: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }

    }

}