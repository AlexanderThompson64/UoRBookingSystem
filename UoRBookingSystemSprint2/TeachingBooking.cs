using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UoRBookingSystemSprint2
{
    [Serializable]
    class TeachingBooking : Booking
    {
        //Attributes 

        string moduleCode;
        string loginID;
        string itRequired;
        

        //Constructor with parameters
        public TeachingBooking(int id, String bookingType, String date, String startTime, int duration, String roomName, int capacity, String contactName, String moduleCode, String itRequired, String loginID)
            : base(id, bookingType, date, startTime, duration, roomName, capacity, contactName)
        {
            this.moduleCode = moduleCode;
            this.itRequired = itRequired;
            this.loginID = loginID;
        }

        //Constructor without parameters
        public TeachingBooking()
        {
            moduleCode = "N/A";
            itRequired = "No";
            loginID = "N/A";
        }

        //Properties

        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string LoginID { get => loginID; set => loginID = value; }
        public string ItRequired { get => itRequired; set => itRequired = value; }

        public override string ToString()
        {

            return base.ToString() + (String.Format($"\n Module Code: {ModuleCode} \n IT Required: {ItRequired} \n Login ID: {LoginID}"));
        }

    }
}
