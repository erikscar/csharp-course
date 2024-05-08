namespace RefOut
{
    internal class Calculator
    {
        //Supondo que queremos alterar uma váriavel do programa principal através de uma classe
        //Passando essa váriavel como parâmetro, dessa forma não irá funcionar
        public static void Triple(int x)
        {
            x *= 3;
        }

        //Utilizando o Ref para receber uma variavel e efetivamente alterar ela
        public static void TripleRef(ref int x)
        {
            x *= 3;
        }

        //Utilizando o out para receber a variável e um parâmetro de saída COMO SE FOSSE UM RETURN DO MÉTODO
        public static void TripleOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
