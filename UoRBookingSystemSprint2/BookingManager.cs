using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UoRBookingSystemSprint2
{
    class BookingManager
    {
        List<Booking> allBookings;
        const String BOOKINGFILE = "allbookings.dat";
        public List<Booking> AllBookings { get => allBookings; set => allBookings = value; }

        public BookingManager()
        {
            AllBookings = new List<Booking>();
        }

        public void SaveList()
        {
            BinaryFormatter binaryFormat = new BinaryFormatter();

            FileStream outFile = new FileStream(BOOKINGFILE, FileMode.Create, FileAccess.Write);

            binaryFormat.Serialize(outFile, allBookings);

            outFile.Close();
        }

        public void LoadList()
        {
            BinaryFormatter bFormatter = new BinaryFormatter();

            FileStream inFile = new FileStream(BOOKINGFILE, FileMode.Open, FileAccess.Read);

            allBookings = (List<Booking>)bFormatter.Deserialize(inFile);

            inFile.Close();
        }
    }
}
