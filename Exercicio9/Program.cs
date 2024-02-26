namespace Exercicio9{

    //exercicio Matriz
class Program
{
    static void Main(string[] args)
    {
       
            //usando o for para preencher os dados da matriz
     double[,] A = new double [3,4];
      
     
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite o valor da linha " + (i + 1) + " e coluna " + (j + 1));
                    A[i, j] = double.Parse(Console.ReadLine());
                }
            }
        //usando o for para mostrar os dados da matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
     

    }
    }

}
