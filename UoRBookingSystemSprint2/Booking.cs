using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UoRBookingSystemSprint2
{  
    [Serializable]
    public abstract class Booking
    {
        //Attributes
        String bookingType;
        int id;
        String date;
        String startTime;
        int duration;
        String roomName;
        int capacity;
        String contactName;

        //Constructor with paramaters
        public Booking(int id, String bookingType, String date, String startTime, int duration, String roomName, int capacity, String contactName)
        {
            this.id = id;
            this.bookingType = bookingType;
            this.date = date;
            this.startTime = startTime;
            this.duration = duration;
            this.roomName = roomName;
            this.capacity = capacity;
            this.contactName = contactName;
        }

        //Constructor without paramaters 
        public Booking()
        {
            Id = 0;
            bookingType = "null";
            date = "null";
            startTime = "null";
            duration = 0;
            roomName = "null";
            capacity = 0;
            contactName = "null";
        }

        //Properties
        public int Id { get => id; set => id = value; }
        public string BookingType { get => bookingType; set => bookingType = value; }
        public string Date { get => date; set => date = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public int Duration { get => duration; set => duration = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        

        //ToString overide method
        public override string ToString() 
        {
            return $"\n Booking Type: {BookingType} \n Id: {Id} \n Date: {Date} \n Start Time: {StartTime} \n Duration: {Duration} Minutes \n Room Name: {RoomName} \n Capacity: {Capacity} \n Contact Name: {ContactName} ";
        }

        
    }

   

}
