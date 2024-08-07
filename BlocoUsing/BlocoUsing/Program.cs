namespace BlocoUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\eriks\Desktop\CheckList C#.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open)) //Podemos usar o using para simplificar a sintaxe e fazer com que o arquivo seja automaticamente fechado
                {
                    using (StreamReader sr = new StreamReader(fs)) //Podemos utilizar mais de um bloco using encadeados!
                    {
                        while (!sr.EndOfStream) //Enquanto não for o final da Stream, salvar a string e imprimir na tela
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e) //Podemos utilizar o bloco try normalmente para capturar as exceções!
            {
                Console.WriteLine("An Error Ocurred: " + e.Message);
            }
        }
    }
}
