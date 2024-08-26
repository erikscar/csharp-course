namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Com a utlização dos extension methods, agora qualquer objeto do tipo DateTime possui essa função
            DateTime dt = new DateTime(2024, 8, 26, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            //Agora podemos cortar uma string com dado número
            string s1 = "Good Morning Dear Students";
            Console.WriteLine(s1.Cut(8));
        }
    }
}
