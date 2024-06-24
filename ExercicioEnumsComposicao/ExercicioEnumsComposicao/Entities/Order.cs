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
            stringBuilder.Append("Order Moment: ");
            stringBuilder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.Append("Order Status: ");
            stringBuilder.AppendLine(Status.ToString());
            stringBuilder.Append(Client.Name);
            stringBuilder.Append(' ');
            stringBuilder.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            stringBuilder.Append(" - ");
            stringBuilder.AppendLine(Client.Email);
            stringBuilder.AppendLine("Order Items: ");

            foreach(OrderItem item in Items)
            {
                stringBuilder.Append(item.Product.Name);
                stringBuilder.Append(", $");
                stringBuilder.Append(item.Price.ToString("F2", CultureInfo.InvariantCulture));
                stringBuilder.Append(", ");
                stringBuilder.Append("Quantity: ");
                stringBuilder.Append(item.Quantity);
                stringBuilder.Append(", ");
                stringBuilder.Append("Subtotal: $");
                stringBuilder.AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            stringBuilder.Append("Total Price: $");
            stringBuilder.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return stringBuilder.ToString();
        }
    }
}
