namespace Pathe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\eriks\Desktop\file1.txt";

            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); //Obtendo o caractere que separa as pastas baseado no Sistema Operacional
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); //Obtendo somente a pasta do arquivo
            Console.WriteLine("GetFileName: " + Path.GetFileName(path)); //Obtendo o nome do arquivo
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); //Obtendo o nome do arquivo sem extensões
            Console.WriteLine("GetExtension: " + Path.GetExtension(path)); //Obtendo somente a extensão do arquivo
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); //Obtendo o caminho completo do arquivo
            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); //Obtendo qual a pasta temporária do sistema, FUNÇÃO IMPORTANTE!!!
        }
    }
}
