using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservation
{
    public class HotelReservation
    {
        /// <summary>
        /// Using dictionary as a system of hotel, which will have many hotel entries.
        /// </summary>
        public Dictionary<String, Hotel> availableHotels = new Dictionary<string, Hotel>();
        public List<Hotel> HotelList = new List<Hotel>();
        /// <summary>
        /// Method to add new hotel into the hotel reservation system
        /// </summary>
        /// <param name="hotelName"></param>
        /// <param name="weekdayRate"></param>
        
        public void AddHotelToSystem(String hotelName, int weekdayRate, int weekendRate, int rating, int rewardCustWeekdayRate, int rewardCustWeekendRate)
        {
            Hotel hotel = new Hotel(hotelName, weekdayRate,weekendRate,rating,rewardCustWeekdayRate,rewardCustWeekendRate);
            availableHotels.Add(hotelName, hotel);
            HotelList.Add(hotel);
        }
        /// <summary>
        /// Method to find cheapest hotel for a given date range.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
       
		public Hotel FindCheapestHotel(DateTime startDate, DateTime endDate) 
		{
            if (startDate >= endDate)
            {
                Console.WriteLine("End date must be after start date");
                return null;
            }
            else
            {
                try
                {
                    TimeSpan difference = endDate - startDate;
                    int noOfDays = difference.Days;
                    HotelList.Sort((hotel1, hotel2) => hotel1.WeekdayRate.CompareTo(hotel2.WeekdayRate));
                    Hotel cheapestHotel = HotelList.First();
                    Console.WriteLine("Cheapest Hotel for your stay : " + HotelList.First().HotelName +
                        " Charges for the stay : " + TotalCost(FindCheapestBestRatedHotel(startDate,endDate),startDate,endDate));
                    return HotelList.First();
                }
                catch (FormatException)
                {
                    throw new HotelReservationCustomException(HotelReservationCustomException.ExceptionType.INVALID_DATE_FORMAT, "Date Format is Invalid");
                }
            }
        }
        /// <summary>
        /// Method to calculate cost for different rates on different days
        /// </summary>
        /// <param name="hotel"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public int TotalCost(Hotel hotel,DateTime startDate, DateTime endDate)
        {
            int cost = 0;
            int weekdayRate = hotel.WeekdayRate;
            int weekendRate = hotel.WeekendRate;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                    cost += weekendRate;
                else
                    cost += weekdayRate;
            }
            return cost;
        }
        /// <summary>
        /// method to find a list of cheapest hotels for given dates
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public List<Hotel> CheapestHotels(DateTime startDate, DateTime endDate)
        {
            HotelList.Sort((hotel1, hotel2) => (TotalCost(hotel1,startDate,endDate)).CompareTo(TotalCost(hotel1, startDate, endDate)));
            List<Hotel> cheapestHotels = new List<Hotel>();
            if ((HotelList[0] == HotelList[1]) && (HotelList[0]== HotelList.Last()))
            {
                cheapestHotels.Add(HotelList[0]);
                cheapestHotels.Add(HotelList[1]);
                cheapestHotels.Add(HotelList[2]);
            }
            if(HotelList[0] == HotelList[1])
            {
                cheapestHotels.Add(HotelList[0]);
                cheapestHotels.Add(HotelList[1]);
            }
            else
            {
                cheapestHotels.Add(HotelList[0]);
            }
            return cheapestHotels;
        }
        /// <summary>
        /// Method to find cheapest hotel having best rating on given dates
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public Hotel FindCheapestBestRatedHotel(DateTime startDate,DateTime endDate)
        {
            List<Hotel> cheapestHotels = CheapestHotels(startDate,endDate);
            cheapestHotels.Sort((hotel1, hotel2) => hotel1.Rating.CompareTo(hotel2.Rating));
            return cheapestHotels.Last();
        }
        /// <summary>
        /// Ability to view the best rated hotel on given dates.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public Hotel FindBestRatedHotel(DateTime startDate, DateTime endDate)
        {
            HotelList.Sort((hotel1,hotel2)=> hotel1.Rating.CompareTo(hotel2.Rating));
            Hotel bestRatedHotel = HotelList.Last();
            Console.WriteLine("Best Rated hotel: " + bestRatedHotel.HotelName + " Total Cost : "+ TotalCost(bestRatedHotel,startDate,endDate));
            return bestRatedHotel;
        }
    }
}
