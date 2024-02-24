using System.Runtime.CompilerServices;

namespace Exercicio4_5
{

 
class Program

  {
    static void Main(string[] args)
    {
      Console.Write("Digite a quantidade de nome das pessoas até um maximo de 20: ");
      int QuantidadeNomes = int.Parse(Console.ReadLine());
      
        
            for(int i = 0; i < QuantidadeNomes; i++)
            {
              //codigo para fazer um vetor que armazena o nome das pessoas e printa elas depois
              Console.Write("Digite o nome da pessoa: ");
                string[] NomePessoa = new string[QuantidadeNomes];
                NomePessoa[i] = Console.ReadLine();

                 Console.WriteLine("Os nomes digitados foram: ");
                Console.WriteLine(NomePessoa[i]);

            }
           

      
    }


        

      
    }
}