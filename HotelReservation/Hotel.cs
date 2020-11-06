using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class Hotel
    {
		public Hotel(String hotelName, int weekdayRate, int weekendRate,int rating, int rewardCustWeekdayRate, int rewardCustWeekendRate)
		{
			this.HotelName = hotelName;
			this.WeekdayRate = weekdayRate;
			this.WeekendRate = weekendRate;
			this.Rating = rating;
			this.RewardCustWeekdayRate = rewardCustWeekdayRate;
			this.RewardCustWeekendRate = rewardCustWeekendRate;
		}
		public string HotelName { get; set; }
		public int WeekdayRate { get; set; }
		public int WeekendRate { get; set; }
		public int Rating { get; set; }
		public int RewardCustWeekdayRate { get; set; }
		public int RewardCustWeekendRate { get; set; }
	}

}
