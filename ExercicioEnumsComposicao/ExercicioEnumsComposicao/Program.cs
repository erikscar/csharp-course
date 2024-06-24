using ExercicioEnumsComposicao.Entities;
using ExercicioEnumsComposicao.Entities.Enums;
using System.Globalization;

namespace ExercicioEnumsComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, date);
            Order order = new Order(orderStatus, client);

            Console.WriteLine("How Many Items to This Order: ");
            int counter = int.Parse(Console.ReadLine());

            for (int i = 1; i <= counter; i++)
            {
                Console.WriteLine($"Enter #{i} Item Data: ");
                Console.Write("Product Name: ");
                string pName = Console.ReadLine();

                Console.Write("Product Price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(pName, pPrice);

                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(pQuantity, pPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine(order);
        }
    }
}
