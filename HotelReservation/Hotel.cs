using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class Hotel
    {
		private string hotelName;
		private int regularRate;
		public Hotel(String hotelName, int regularRate)
		{
			this.hotelName = hotelName;
			this.regularRate = regularRate;
		}
		public string HotelName { get; set; }
		public int RegularRate { get; set; }
	}
}
