using System;

namespace HotelReservation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation Program ");
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotelToSystem("Lakewood",110,90,3);
            hotelReservation.AddHotelToSystem("Bridgewood",150,50,4);
            hotelReservation.AddHotelToSystem("Ridgewood",220,150,5);

            Console.WriteLine("Enter the start date for your stay in dd-mm-yyyy format : ");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the end date for your stay in dd-mm-yyyy format : ");
            DateTime endDate = Convert.ToDateTime(Console.ReadLine());
            hotelReservation.FindCheapestHotel(startDate, endDate);
            hotelReservation.FindBestRatedHotel(startDate, endDate); 
        }
    }
}
