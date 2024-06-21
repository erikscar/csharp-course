using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando de forma automática
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment //Intelisense auxilia depois do PONTO por causa dos ENUMS
            };
            Console.WriteLine(order);

            //Convertendo um enum para STRING
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);


            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}
