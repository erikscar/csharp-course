
using ExcecaoPersonalizada.Entities;
using ExcecaoPersonalizada.Entities.Exceptions;
using System;

namespace ExcecaoPersonalizada
{
    internal class Program
    {
        //Agora Exceções podem ocorrer nos Contrutores
        //Lógica de Reserva esta somente na Classe de Reserva
        //Código Linear sem IFS encadeados e podemos capturar outras exceções
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Romm Number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("CheckIn Date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("CheckOut Date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation.ToString());

                Console.WriteLine();
                Console.WriteLine("Enter Data to Update the Reservation: ");

                Console.Write("CheckIn Date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("CheckOut Date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDate(checkIn, checkOut);
                Console.WriteLine(reservation);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Reservation Erro: " + e.Message);
            }
            catch(FormatException e )
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
