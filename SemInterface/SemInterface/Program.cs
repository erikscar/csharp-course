using SemInterface.Entities;
using SemInterface.Services;
using System.Globalization;

namespace SemInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rental Data: ");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre Price per Hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre Price per Day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
