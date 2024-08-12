namespace Generics2
{
    internal class PrintService<T>
    {
        //Utilizando Generics para Parametrizar os tipos que queremos de forma dinâmica ("T")
        //Agora passaremos o tipo na criação do objeto
        //Assim poderemos ter reúso, type safety e Perfomance (por não precisar de castings)
        private T[] _values = new T[10];
        private int _count = 0; 

        public void AddValue(T value)
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("Print Service is Full");
            }

            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            Console.Write(_values[_count - 1] + "]\n");
        }


    }
}
