using ExcecoesSolucao1.Entities;
using System;

namespace ExcecoesSolucao1
{
    internal class Program
    {
        //Solução para o tratamento de Erros RUIM
        //A Lógica de Reserva de uma Quarto está no sistema principal e não delegada a classe de reserva
        //Além do encadeamento de vários IFS o que torna o código complicado de rápido entendimento!
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("CheckIn Date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("CheckOut Date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <=  checkIn)
            {
                Console.WriteLine("Error in Reservation: CheckOut Date Must be After CheckIn Date! ");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation.ToString());

                Console.WriteLine();
                Console.WriteLine("Enter the Data to Update the Reservation");

                Console.Write("CheckIn Date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("CheckOut Date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                if(checkOut <= checkIn)
                {
                    Console.WriteLine("Error in Reservation: CheckOut Date Must be After CheckIn Date");
                }
                else if(checkOut < DateTime.Now || checkIn < DateTime.Now)
                {
                    Console.WriteLine("Error in Reservation: Reservation Dates for Update Must be Future Dates");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine(reservation.ToString());
                }
            }
        }
    }
}
