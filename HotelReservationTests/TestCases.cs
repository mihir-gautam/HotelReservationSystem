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
            int rate = 110;
            hotelReservation.AddHotelToSystem(hotelName, rate);
            Assert.AreEqual(1, hotelReservation.availableHotels.Count);
        }
        /// <summary>
        /// Test case to check if the method is providing correct output.
        /// </summary>
        [TestMethod]
        public void Given_ValidDate_ShouldReturn_CheapestHotel()
        {
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotelToSystem("Lakewood", 110);
            hotelReservation.AddHotelToSystem("Bridgewood", 150);
            hotelReservation.AddHotelToSystem("Ridgewood", 220);
            Assert.AreEqual("Lakewood",hotelReservation.HotelList.First().HotelName);
        }
        /// <summary>
        /// Test case to give custom exception when given invalid date
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
    }
}
