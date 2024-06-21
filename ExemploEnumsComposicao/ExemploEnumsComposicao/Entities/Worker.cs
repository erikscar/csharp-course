using ExemploEnumsComposicao.Entities.Enums;

namespace ExemploEnumsComposicao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //Composição de um Elemento
        public Department Department { get; set; }

        //Composição de Vários Elemento Utilizando uma Lista
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker() { }
        //Não Adicionar Listas no Construtor, não é usual fazer isso
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(var contract in Contracts )
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
