using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class HotelReservation
    {
        /// <summary>
        /// Using dictionary as a system of hotel, which will have many hotel entries.
        /// </summary>
        public Dictionary<String, Hotel> availableHotels = new Dictionary<string, Hotel>();
        //Method to add hotels into the system is defined
        public void AddHotelToSystem(String hotelName, int regularRates)
        {
            Hotel hotel = new Hotel(hotelName, regularRates);
            availableHotels.Add(hotelName, hotel);
        }
    }
}
