namespace RestricoesGenerics
{
    internal class CalculationService<T>
    {
        List<T> list = new List<T>();

        public T Max(List<T> items)
        {
            return list.Max();
        }
    }
}
