using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class Hotel
    {
		public Hotel(String hotelName, int regularRate)
		{
			this.HotelName = hotelName;
			this.RegularRate = regularRate;
		}
		public string HotelName { get; set; }
		public int RegularRate { get; set; }
	}
}
