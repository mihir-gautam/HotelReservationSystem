using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class Hotel
    {
		public Hotel(String hotelName, int weekdayRate, int weekendRate)
		{
			this.HotelName = hotelName;
			this.WeekdayRate = weekdayRate;
			this.WeekendRate = weekendRate;
		}
		public string HotelName { get; set; }
		public int WeekdayRate { get; set; }
		public int WeekendRate { get; set; }
	}
}
