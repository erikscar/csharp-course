namespace RestricoesGenerics
{
    internal class CalculationService
    {
        //Podemos utilizar somente o método de forma genérica dessa forma, com sua parametrização
        public T Max<T>(List<T> list) where T : IComparable //Estamos dizendo, a lista pode ser qualquer tipo desde que o tipo possa ser comparável com outro
        //Podemos utilizar o where com diversos tipos não somente a interface, pode ser de classe, structs etc
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The List can't be Empty!");
            }

            T max = list[0];
            for(int i = 1; i < list.Count;i ++)
            {
                //Mesmo list[i] e max sejam do mesmo tipo "T" o compilador acusa erro, porque nada garante que 
                //esses 2 tipos genéricos aceitem essa comparação
                //Para resolver isso devemos adicionar o where no método
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
