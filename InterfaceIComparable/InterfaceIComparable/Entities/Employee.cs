using System.Globalization;

namespace InterfaceIComparable.Entities
{
    internal class Employee : IComparable
    //Adicionando a Interface
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)  //se o objeto que veio como parametro for menor que o objeto atual. o método retorna um valor menor que 0
        {                                 //se os 2 objetos forem iguais retorna 0
            if (!(obj is Employee))          //se o objeto que veio como parametro for maior que o objeto atual. o método retorna um valor maior que 0
            {
                throw new ArgumentException("Compare Error: argument is not an Employee");
            }

            Employee other = obj as Employee; //Fazendo o downcasting do Objeto que veio para Employee

            //Comparando por ORdem Alfabética
            //E isso irá refletir no Método SORT da 
            return Name.CompareTo(other.Name);

            //Podemos Também comparar em Ordem crescente de salário
            //return Salary.CompareTo(other.Salary);
        }
    }
}
