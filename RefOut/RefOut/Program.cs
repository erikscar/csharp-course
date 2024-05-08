namespace RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Passando uma variável para um método de uma classe para triplicar o valor porém não irá funcionar
            int a = 10;
            Calculator.Triple(a);

            Console.WriteLine(a);

            int b = 10;
            Calculator.TripleRef(ref b);
            //Temos que passar com o uso do "ref", para que assim sejá possível modificar a referência e alterar os valores
            //da variável através de um método da classe
            Console.WriteLine(b);

            //UTilizando o out para alocar o resultado do triplo da váriavel, é como se estivessemos obtendo 
            //o retorno do método da classe assim e armazenando no programa principal
            int c = 10;
            int triple;
            Calculator.TripleOut(c, out triple);
            Console.WriteLine(triple);

            //REF e OUT Não são recomendados e devem ser evitados, sua principal diferença é que o "ref" é necessário
            //que a variável seja iniciada já o "out" não é necessário 
        }
    }
}
