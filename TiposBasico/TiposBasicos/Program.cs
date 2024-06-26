﻿namespace TiposBasicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool teste = false;
            char genero = 'F';
            char letra = '\u0041'; //Letras em Formato Unicode
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //Utilizar o L no final para indicar que é um Long
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            Object obj1 = "Alex Brown"; //Object aceita qualquer tipo de dado
            Object obj2 = 4.5f;

            Console.WriteLine(teste);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine("--------------");
            //Overflow: Ao passar o valor máximo de um tipo, ele será alterado para seu extremo oposto
            //Nesse caso irá ser mostrado -127
            sbyte overflow = 127;
            overflow++;
            Console.WriteLine(overflow);
            Console.WriteLine(long.MaxValue);
        }
    }
}
