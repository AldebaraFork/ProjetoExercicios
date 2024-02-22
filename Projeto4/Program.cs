using System;
using System.Globalization;
namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            //essa variavel é pra encurtar o código do CultureInfo.InvariantCulture apenas para CI
            CultureInfo CI = CultureInfo.InvariantCulture;
            

            Console.Write("Digite sua idade ");
            int idade = int.Parse(Console.ReadLine());
            string nome;
            char sexo;
           while (idade < 18)
            {
                Console.Write("Voce é menor de idade, ");
               
                Console.WriteLine("Digite a idade novamente: ");
                idade = int.Parse(Console.ReadLine());

            }while (idade >= 18)
            {
                Console.WriteLine("Voce é maior de idade ");
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine(nome + " voce é maior de idade, parabens! ");
                Console.WriteLine("Digite seu sexo: ");
                sexo = char.Parse(Console.ReadLine());
                if (sexo == 'f' || sexo == 'F')
                {
                    Console.WriteLine("Voce é do sexo feminino ");
                }
                else if (sexo == 'm' || sexo == 'M')
                {
                    Console.WriteLine("Voce é do sexo masculino ");
                }
                else
                {
                    Console.WriteLine("Sexo invalido ");
                }
                break;
            }

             


        }
    }
}
