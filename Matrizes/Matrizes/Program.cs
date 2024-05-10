namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando uma Matriz com 2 Linhas e 3 Colunas
            double[,] mat = new double[2, 3];

            //Quantidade de Elementos que a Matriz possui no total
            Console.WriteLine(mat.Length);

            //Quantidade de Linhas de uma Determinada Matriz
            Console.WriteLine(mat.Rank);

            //A Quantidade de posições da Dimensão 0, no caso a Quantidade de Linhas
            Console.WriteLine(mat.GetLength(0));

            //A Quantidade de posições da Dimensão 1, no caso a Quantidade de Colunas
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
