namespace Dictionary1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando e passando os tipos da chave e do valor
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "9 4008 0990";
            cookies["phone"] = "9 4008 4008"; //Vai sobrescrever porque não aceita repetições na mesma chave

            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if(cookies.ContainsKey("email")) //Se contém uma chave
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no Key");
            }

            //Tamanho do Dictionary
            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("All Cookies: ");
            //Percorrendo um dictionary, se quisermos podemos utilizar o var!
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
