using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando uma Lista Vazia sem instanciar e passar valores a ela
            List<string> list1;

            //Criando uma Lista Vazia e instanciando ela , sem elementos e quantidade de posições
            List<string> list2 = new List<string>();

            //Criando uma Lista e já instanciando Elementos Dentro dela
            List<string> list3 = new List<string> { "Maria", "João", "Jumento" };

            //Adicionar Valores dentro de uma Lista (DEVEM SER DO MESMO TIPO ) 
            //SEMPRE NO FINAL
            //Para Adicionar um objeto seria = list2.Add( new Product(nome, preco) );
            list2.Add("Carneiro1");
            list2.Add("Documento");
            list2.Add("Dromedário");


            //Adicionar Valores dentro de uma Lista
            //Especificando a posição a ser inserida
            //Ele empurra as outras posições para baixo para inserir o valor
            list2.Insert(1, "Marco");
            foreach (string objs in list2)
            {
                Console.WriteLine(objs);
            }
            Console.WriteLine("Contagem dos Valores da Lista: " + list2.Count);
            Console.WriteLine("-----------------------------------------");

            //Esse método aceita uma função de callback (EXPRESSÃO LAMBDA )
            //para buscar algum item dentro da lista!
            //Podemos criar uma função ou passar uma função anônima dentro do Find

            string s1 = list2.Find(Teste); //Achar o Primeiro Valor Retornado
            string s2 = list2.FindLast(Teste); //Achar o Último Valor Retornado

            static bool Teste(string x)
            {
                return x[0] == 'D';
            }

            string s3 = list2.Find(x => x[0] == 'D');
            string s4 = list2.FindLast(x => x[0] == 'D');

            Console.WriteLine("Primeira Palavra com D no Começo: " + s3);
            Console.WriteLine("Última Palavra com D no Começo: " + s4);
            Console.WriteLine("-----------------------------------------");

            //Buscar o PRIMEIRO Número do Índice que satisfaça uma condição / predicado
            int p1 = list2.FindIndex(x => x[0] == 'D');
            Console.WriteLine("Primeira Posição da Palavra que Começa com 'D': " + p1);


            //Buscar o ÚLTIMO Número do Índice que satisfaça uma condição / predicado
            int p2 = list2.FindLastIndex(x => x[0] == 'D');
            Console.WriteLine("Última Posição da Palavra que Começa com 'D': " + p2);

            //Filtrar Vários Elementos de uma Lista de acordo com uma condição / predicado
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Filtrando uma Lista com outra Lista por Condição");
            List<string> filterList = list2.FindAll(x => x.Length == 9);

            foreach(string obj in filterList) { 
                Console.WriteLine(obj);
            }

            //Removendo um item da Lista passando o seu valor em string
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Removendo um Item de Acordo com uma String passada");
            list2.Remove("Documento");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            //Removendo todos os itens de acordo com uma função 
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Removendo Todos os Itens por uma Condição");
            list2.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Removendo um Item de Acordo com um Índice passado
            list2.RemoveAt(1); //Removendo na posição 1
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Removendo um Item por sua posição");
            foreach (string obj in list2)    
            {
                Console.WriteLine(obj);
            }

            list2.Add("Carlos");
            list2.Add("Bartolomeu");
            list2.Add("Joaozinhio");

            //Removendo Valores de Acordo com uma determinada faixa de posições
            //Espera um índice para iniciar e a quantidade de valores removidos
            list2.RemoveRange(1, 3);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Removendo Itens em uma Faixa de Posições");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
