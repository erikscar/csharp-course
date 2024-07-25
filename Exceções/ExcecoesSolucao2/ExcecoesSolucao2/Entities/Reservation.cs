using System;

namespace ExcecoesSolucao2.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration ()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDate(DateTime checkIn, DateTime checkOut)
        {
            if(checkOut < checkIn)
            {
                return "Error in Reservation: CheckOut Date Must be After CheckInDate";
            }

            if (checkOut <= DateTime.Now || checkIn <= DateTime.Now)
            {
                return "Error in Reservation: Reservation Dates for Update Must be Future Dates!";
            }
                CheckIn = checkIn;
                CheckOut = checkOut;
            return null;
        }

        public override string ToString()
        {
            return "Reservation: Room Number: " + RoomNumber +
                ", CheckIn Date: " + CheckIn.ToString("dd/MM/yyyy") +
                ", CheckOut Date: " + CheckOut.ToString("dd/MM/yyyy") +
                ", " + Duration() + " Nights";

        }
    }
}
