using ExercicioEnumsComposicao.Entities.Enums;
using System.Globalization;
using System.Text;

namespace ExercicioEnumsComposicao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Order() { }
        
        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;

            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Order Summary: ");
            stringBuilder.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine("Order Status: " + Status.ToString());
            stringBuilder.AppendLine("Client: " + Client);
            stringBuilder.AppendLine("Order Items: ");

            foreach(OrderItem item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            stringBuilder.Append("Total Price: $");
            stringBuilder.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return stringBuilder.ToString();
        }
    }
}
