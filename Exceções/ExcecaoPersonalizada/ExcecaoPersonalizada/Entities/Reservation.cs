using System;
using ExcecaoPersonalizada.Entities.Exceptions;

namespace ExcecaoPersonalizada.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn) //É possível lançar exceções no Construtor!
            {
                throw new DomainException("CheckOut Date Must be After CheckIn Date!");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDate(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                throw new DomainException("Reservation Must be Future Dates!"); //Corta o método igual return!
            }
            if(checkOut <= checkIn)
            {
               throw new DomainException("CheckOut Date Must be After CheckIn Date!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Reservation: Room " + RoomNumber +
                ", CheckIn: " + CheckIn.ToString("dd/MM/yyyy") +
                ", CheckOut: " + CheckOut.ToString("dd/MM/yyyy") +
                ", " + Duration() + " Nights";                
        }
    }
}
