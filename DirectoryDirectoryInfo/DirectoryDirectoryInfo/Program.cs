namespace DirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\eriks\Desktop";

            try
            {
                //Função para guardar todos os diretórios que existem em um determinado caminho, é guardado em forma de IEnumerable que é uma lista genérica
                //Aceita como argumento o caminho, a mascára de pesquisa, no caso todos os arquivos . alguma coisa
                //E SearchOption que é TODOS OS DIRETÓRIOS EXISTENTES
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: \n\n");
                foreach(string folder in folders) 
                {
                    Console.WriteLine(folder);
                }

                //Da mesma forma podemos listar todos os arquivos
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: \n\n");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                //Para criar um diretório novo bastar fazer dessa forma
                Directory.CreateDirectory(path);
            }
            catch(IOException e)
            {
                Console.WriteLine("An Error Ocurred: " + e.Message);
            }

            //Poderiamos ter utilizado também o DirectoryInfo basta instanciar ele!
        }
    }
}
