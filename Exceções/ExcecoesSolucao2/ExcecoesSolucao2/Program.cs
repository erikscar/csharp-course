using ExcecoesSolucao2.Entities;
using System;

namespace ExcecoesSolucao2
{
    internal class Program
    {
        //Parcialmente Boa,
        //Método retornando STRING, não tem nada haver com a atulização de reserva, ELA TINHA QUE SER VOID
        //Assim todo método que haja uma exceção deve retornar uma STRING, isso é ruim
        //E se a operação retornasse outra string, iria gerar um conflito
        //ISSO É UM IMPROVISO
        //Construtores n podem serem tratados 
        //Encadeamento de IFS!
        ///Lógica de RESERVA ainda não esta totalmente na classe de REserva, o que esta errado!
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("CheckIn Date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("CheckOut Date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut < checkIn)
            {
                Console.WriteLine("Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);   
                Console.WriteLine(reservation.ToString());

                Console.WriteLine();
                Console.WriteLine("Enter Data to Update the Reservation: ");

                Console.Write("CheckIn Date: (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("CheckOut Date: (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDate(checkIn, checkOut);

                if(error != null)
                {
                    Console.WriteLine(error);
                }
                else
                {
                    reservation.UpdateDate(checkIn, checkOut);
                    Console.WriteLine(reservation);
                }
            }


        }
    }
}
