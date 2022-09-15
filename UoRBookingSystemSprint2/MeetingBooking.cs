using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UoRBookingSystemSprint2
{
    [Serializable]
    class MeetingBooking : Booking
    {
        //Attributes
        String refreshmentsRequired;
        int noOfAttendees;

        //Constructor with parameters
        public MeetingBooking(int id, String bookingType, String date, String startTime, int duration, String roomName, int capacity, String contactName, String refreshmentsRequired, int noOfAttendees)
            : base(id, bookingType, date, startTime, duration, roomName, capacity, contactName)
        {
            this.refreshmentsRequired = refreshmentsRequired;
            this.noOfAttendees = noOfAttendees;
        }

        //Constructor without parameters

        public MeetingBooking()
        {
            refreshmentsRequired = "Null";
            noOfAttendees = 0;
        }

        //Properties

        public string RefreshmentsRequired { get => refreshmentsRequired; set => refreshmentsRequired = value; }
        public int NoOfAttendees { get => noOfAttendees; set => noOfAttendees = value; }

        //ToString override
        public override string ToString()
        {
            return base.ToString() + (String.Format($"Refreshments: {RefreshmentsRequired} \n Number of attendees: {noOfAttendees}"));
        }
    }
}
