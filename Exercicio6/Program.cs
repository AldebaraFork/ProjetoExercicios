namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            int C, L ;

            //atribui as linhas da matriz
            Console.WriteLine("Quantas linhas tem a matriz?");
            L = int.Parse(Console.ReadLine());

            //atribui as colunas da matriz
            Console.WriteLine("Quantas colunas tem a matriz?");
            C = int.Parse(Console.ReadLine());

            //cria a matriz

            //matriz com duas dimensoes
            int[,] matrizTeste = new int[L, C];

            //percorre todas as linhas da matriz
            for (int i = 0; i < L ; i++)
            {
                for(int j = 0; j < C; j++)
                {
                    Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                    //le o elemento da linha i e coluna j
                    matrizTeste[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Matriz Digitada: ");

            for(int i = 0; i < L; i++)
            {
                for(int j = 0; j < C; j++)
                {
                    Console.Write(matrizTeste[i, j] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}

