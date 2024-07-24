using System;
using System.IO;

namespace Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finally é um bloco de código que será executado no final de cada Try Catch
            //Independentemente se houver uma exceção ou não
            //Abaixo um Programa que procura por um arquivo escreve uma linha
            //Catch para caso não for encontrado o arquivo ou diretório
            //FInally para Fechar o arquivo se ele não estiver sido fechado
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
