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
        
        public void AddHotelToSystem(String hotelName, int weekdayRate, int weekendRate)
        {
            Hotel hotel = new Hotel(hotelName, weekdayRate,weekendRate);
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
                    Console.WriteLine("Cheapest Hotel for your stay : " + HotelList.First().HotelName +
                        "Charges for the stay : " + HotelList.First().WeekdayRate * noOfDays);
                    return HotelList.First();
                }
                catch (FormatException)
                {
                    throw new HotelReservationCustomException(HotelReservationCustomException.ExceptionType.INVALID_DATE_FORMAT, "Date Format is Invalid");
                }
            }
        }
    }
}
