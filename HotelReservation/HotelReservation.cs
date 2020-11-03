using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class HotelReservation
    {
        public Dictionary<String, Hotel> availableHotels = new Dictionary<string, Hotel>();
        public void AddHotelToSystem(String hotelName, int regularRates)
        {
            Hotel hotel = new Hotel(hotelName, regularRates);
            availableHotels.Add(hotelName, hotel);
        }
    }
}
