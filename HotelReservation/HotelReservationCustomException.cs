using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class HotelReservationCustomException : Exception
    {
        /// <summary>
        /// Type Of Exceptions
        /// </summary>
        public enum ExceptionType
        {
            INVALID_DATE,
            INVALID_DATE_FORMAT,
        }
        public ExceptionType type;

        /// <summary>
        /// Parameterised constructor of class
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public HotelReservationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
