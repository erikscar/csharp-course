namespace FuncoesDeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strings São Imutáveis, porque é uma classe
            //Mesmo Fazendo uma atribuição seu valor não irá mudar e sim apontar para outro valor
            string original = "abcde FGHIJ ABC abc DEFG   ";

            Console.WriteLine("Original: -" + original + "-");

            //Deixar a String inteira com letras maiúsculas
            Console.WriteLine("ToUpper: -" + original.ToUpper() + "-");

            //Deixar a String inteira com letras minúsculas
            Console.WriteLine("ToLower: -" + original.ToLower() + "-");

            //Remover os espaços tanto no começo como no final da String
            Console.WriteLine("Trim: -" + original.Trim() + "-");   

            //Procurar o Indíce da Primeira Ocorrência de um determinado valor
            Console.WriteLine("IndexOf('bc'): -" + original.IndexOf("bc"));

            //Procurar o Indíce da Última Corrência de um determinado valor
            Console.WriteLine("LastIndexOf: -" + original.LastIndexOf("bc"));

            //Cortar um pedaço da String, indicando um índice para "SALVAR"
            Console.WriteLine("Substring(3): -" + original.Substring(3) + "-"); //Irá cortar e deixar apenas do índice 3 em diante
            //Cortando um pedaço da String començando do índice 3, apenas 5 caracteres
            Console.WriteLine("Subrstring(3, 5): -" + original.Substring(3, 5));

            //Substituir um valor de Caractere ou String por outro valor
            Console.WriteLine("Replace(char): -" + original.Replace('a', 'X')); //Valor Antigo Depois Valor Novo

            Console.WriteLine("Replace(string): -" + original.Replace("abc", "camelo")); //trocando todo abc por camelo

            //Testar se a String é nula ou não
            Console.WriteLine("String.IsNullOrEmpty: -" + String.IsNullOrEmpty(original));

            //Testar se uma String é nula ou se ela tem apenas espaços em branco
            Console.WriteLine("String.IsNullOrWhiteSpace: -" + String.IsNullOrWhiteSpace(original));
        }
    }
}
