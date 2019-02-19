using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaBerthClassLibrary
{
    public class Booking
    {
        private Boat boat;
        private DateTime startDate, endDate;
        private int bookingID;
        public Boat Boat
        {
            get
            {
                return boat;
            }

            set
            {
                boat = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public int BookingID
        {
            get
            {
                return bookingID;
            }

            set
            {
                bookingID = value;
            }
        }

        public decimal getBerthPrice(Boat boat,Booking booking)
        {
            //10 pounds per meter per month
            throw new NotImplementedException();
        }
    }
}
