using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservation;

namespace HotelReservation
{
    [TestClass]
    public class TestCases
    {
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
