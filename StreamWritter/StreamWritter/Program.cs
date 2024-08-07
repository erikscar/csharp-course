namespace StreamWritter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\eriks\Desktop\file1.txt";
            string targetPath = @"C:\Users\eriks\Desktop\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(path); //Criando um array com todas as linhas do arquivo

                using(StreamWriter sw = File.AppendText(targetPath)) //Instanciando o StreamWritter utilizando o bloco using
                                                                     //e a forma simplificado utilizando a classe File e 
                                                                     //AppendText para adicionar algo no final do arquivo no caso o TargetPath
                {
                    foreach(string line in lines) //Iterando sobre o array que contem todas as linhas do arquivo
                    {
                        sw.WriteLine(line.ToUpper()); //Escrevendo no targetPath todas as linhas EM LETRA MAIUSCULA o que havia no arquivo primeiramente lido
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An Error Ocurred: " + e.Message);
            }
        }
    }
}
