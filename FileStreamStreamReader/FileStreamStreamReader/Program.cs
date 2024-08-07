namespace FileStreamStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\eriks\Desktop\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(sourcePath, FileMode.Open); //Instanciando um FileStream associado a um arquivo e abrindo ele
                /*sr = new StreamReader(fs);*/ //Instanciando um StreamReader que precisa de um Filestream
                //FileStream é uma Parte genérica e o StreamReader é um que será responsável pelas operações

                //porém não precisamos ficar instanciado os objetos podemos apenas utilizar dessa forma

                sr = File.OpenText(sourcePath); //Aqui os dois objetos já esta sendo instanciado automaticamente pela operação de abrir o arquivo

                while(!sr.EndOfStream) //Enquanto não chegar no final da STREAM leremos na tela
                {
                    string line = sr.ReadLine(); //LEndo uma linha do arquivo
                    Console.WriteLine(line);
                }
               
            }
            catch(IOException e)
            {
                Console.WriteLine("An Error Ocurred: " + e.Message);
            }
            finally //Após abrirmos o arquivo devemos necessariamente o fechar
            {
                if (fs != null)
                {
                    fs.Close();
                }

                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
