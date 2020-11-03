using System;

namespace HotelReservation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation Program ");
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotelToSystem("Lakewood", 110);
            hotelReservation.AddHotelToSystem("Bridgewood", 160);
            hotelReservation.AddHotelToSystem("Ridgewood", 220);
        }
    }
}
