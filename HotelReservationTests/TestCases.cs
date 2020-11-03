using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservation;

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
    }
}
