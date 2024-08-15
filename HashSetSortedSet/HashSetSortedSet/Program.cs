namespace HashSetSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //São conjuntos como os de mátemática, aceitando assim União, Intersecção e Diferença
            //HashSET
            Console.WriteLine("HASHSET: ");
            HashSet<string> set = new HashSet<string>();

            set.Add("Notebook");
            set.Add("Control");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));
            Console.WriteLine(set.Contains("Tablet"));
            Console.WriteLine();

            //Como essa coleção não possuí posições como um array, devemos utilizar sempre o Foreach
            foreach (string s in set)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            //SortedSet
            Console.WriteLine("SortedSet: ");

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //União
            //Inicializando o conjunto "c" com os valores do conjunto "a"
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            //Intersecção
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //Diferença
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

            //Método que pode receber qualquer tipo de coleção, porque esta utilizando a Interace IEnumerable
            void PrintCollection<T>(IEnumerable<T> collection)
            {
                foreach(T obj in collection)
                {
                    Console.Write(obj + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
