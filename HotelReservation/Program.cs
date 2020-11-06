using System;

namespace HotelReservation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation Program ");
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotelToSystem("Lakewood",110,90,3,80,80);
            hotelReservation.AddHotelToSystem("Bridgewood",150,50,4,110,50);
            hotelReservation.AddHotelToSystem("Ridgewood",220,150,5,100,40);
            try
            {
                Console.WriteLine("Enter the start date for your stay in dd-mm-yyyy format : ");
                DateTime startDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter the end date for your stay in dd-mm-yyyy format : ");
                DateTime endDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter the Customer type : \n 1. Regular Customer \n 2. Reward Customer");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        hotelReservation.FindCheapestHotel(startDate, endDate);
                        hotelReservation.FindBestRatedHotel(startDate, endDate);
                        break;
                    case 2:
                        hotelReservation.CheapestBestRatedHotelPriceForRewardCust(startDate, endDate);
                        break;
                    default:
                        throw new HotelReservationCustomException(HotelReservationCustomException.ExceptionType.INVALID_CHOICE, "Invalid choice");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
