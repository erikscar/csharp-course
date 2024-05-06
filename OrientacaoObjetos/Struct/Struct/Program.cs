namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uma váriavel declarada e tentar acessar, ocorre um erro
            Point p;
            //Não precisa fazer Point p = new Point( );
            //Porque é um tipo valor

            //Compilador não vai deixar dar o log irá pedir para ser inicializada!
            //Atribuindo os valores na Struct é possível imprimir.
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            //Isso também funciona porém deve ser inicilizado sempre
            p = new Point(); 
            Console.WriteLine(p);
        }
    }
}
