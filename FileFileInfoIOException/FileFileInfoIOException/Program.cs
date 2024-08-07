namespace FileFileInfoIOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\eriks\Desktop\file1.txt";
            string targetPath = @"C:\Users\eriks\Desktop\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); //Instanciando um Objeto que estará associado a um ARQUIVO que está em um caminho
                fileInfo.CopyTo(targetPath); //Assim podemos fazer operações com ele! Aqui estamos copiando o arquivo de um lugar para outro

                string[] lines = File.ReadAllLines(sourcePath); //Utilizando a Classe estática, não precisamos instanciar! Assim leremos todas as linhas 
                //e armazenar em um vetor de string

                foreach( string line in lines ) //Iterando o vetor
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e) //Exceção que abrange os erros relacionados a arquivos!
            {
                Console.WriteLine("An Error Ocurred: " + e.Message);
            }
        }
    }
}
