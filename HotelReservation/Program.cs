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

            Console.WriteLine("Enter the start date for your stay in dd-mm-yyyy format : ");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the end date for your stay in dd-mm-yyyy format : ");
            DateTime endDate = Convert.ToDateTime(Console.ReadLine());
            hotelReservation.FindCheapestHotel(startDate, endDate);
        }
    }
}
