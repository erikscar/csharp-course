namespace ExercicioExemploMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] response = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(response[j]);
                }
            }

            Console.WriteLine("Main Diagonal");
            for(int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int counter = 0;

            //Forma Mais Simples de percorrer um matriz
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine("Negative Numbers: " + counter);
        }
    }
}
