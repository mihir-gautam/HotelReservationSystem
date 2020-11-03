using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservation;
using System.Linq;
using System;

namespace HotelReservation
{
    [TestClass]
    public class TestCases
    {
        /// <summary>
        /// This test case will check if my AddHotelToSystem method is working or not. Passing one hotel entry into the 
        /// new instance of hotelReservation will give count as 1.
        /// </summary>
        [TestMethod]
        public void Given_HotelNameAndRate_ShouldReturn_HotelAdded()
        {
            HotelReservation hotelReservation = new HotelReservation();
            string hotelName = "Lakewood";
            int weekdayRate = 110;
            int weekendRate = 90;
            int rating = 3;
            hotelReservation.AddHotelToSystem(hotelName, weekdayRate,weekendRate,rating);
            Assert.AreEqual(1, hotelReservation.availableHotels.Count);
        }
        /// <summary>
        /// Test case to check if the method is providing correct output.
        /// </summary>
        [TestMethod]
        public void Given_ValidDate_ShouldReturn_CheapestHotel()
        {
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotelToSystem("Lakewood", 110,90,3);
            hotelReservation.AddHotelToSystem("Bridgewood", 150,50,4);
            hotelReservation.AddHotelToSystem("Ridgewood", 220,150,5);
            Assert.AreEqual("Lakewood",hotelReservation.HotelList.First().HotelName);
        }
        /// <summary>
        /// Test case to give lowest cost when giving one weekday and one weekend day
        /// </summary>
        [TestMethod]
        public void Given_ValidDate_WithBothWeekendAndWeekdays_ShouldReturn_HotelWithLowestCost()
        {
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotelToSystem("Lakewood", 110, 90, 3);
            hotelReservation.AddHotelToSystem("Bridgewood", 150, 50, 4);
            hotelReservation.AddHotelToSystem("Ridgewood", 220, 150, 5);
            DateTime startDate = Convert.ToDateTime("11-09-2020");
            DateTime endDate = Convert.ToDateTime("12-09-2020");
            Assert.AreEqual("Lakewood", hotelReservation.HotelList.First().HotelName);
            Assert.AreEqual(200, hotelReservation.TotalCost(hotelReservation.HotelList.First(), startDate, endDate));
        }
    }
}
