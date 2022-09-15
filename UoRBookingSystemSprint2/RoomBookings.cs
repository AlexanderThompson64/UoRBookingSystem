using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UoRBookingSystemSprint2
{
    public partial class RoomBookings : Form
    {
        /// <summary>
        /// Instance of list manager of BookingManager class and addBooking form.  
        /// </summary>
        BookingManager allBookings;
        AddBookingForm addBooking;

        /// <summary>
        /// Sets up instance of custom exception if no index is selected.
        /// </summary>
        public class Custom_Exception_NoIndexSelected : Exception
        {
            // Message for the custom exception
            private static String msg = "Please select a booking to ammend";
            public Custom_Exception_NoIndexSelected()
                : base(msg)
            {
            }
        }
        /// <summary>
        /// Initializes the from and sets up the booking manager list in memory. 
        /// </summary>
        public RoomBookings()
        {   
            InitializeComponent();
            // Sets up the Booking Manager list class in memory.
            allBookings = new BookingManager();
        }

        /// <summary>
        /// Method to load combo box filter types depedning on what bookings are in the list.
        /// </summary>
        private void LoadComboBoxFilterType()
        {
            //Sets up a new list for bookingType in memory. 
            List<string> bookingType = new List<string>();

            //Itterates through booking types to allow user to filter out selected meeting types
         
                foreach (Booking thisBooking in allBookings.AllBookings)
                {
                    string s = thisBooking.GetType().Name;

                    string baseType = thisBooking.GetType().BaseType.Name;

                    if (!bookingType.Contains(baseType))
                    {
                        bookingType.Add(baseType);
                    }

                    if (!bookingType.Contains(s))
                    {
                        bookingType.Add(s);
                    }
                    
                }
                //Sets the filter bookings data type.
                cboFilterBookings.DataSource = bookingType;         
        }
        /// <summary>
        /// Filters the bookings depending on what type of booking is selected. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboFilterBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears the datasource and clears the list box
            lstBookings.DataSource = null;
            lstBookings.Items.Clear();
            //Itterates through the allbookings list. 
            foreach (var i in allBookings.AllBookings)
            {
                //if we get a type that is a subclass pass this to string.
                if (i.GetType().Name == cboFilterBookings.SelectedItem.ToString())
                {
                    //Add the type of booking to the list.
                    lstBookings.Items.Add(i);
                }
                //if we get a booking that is of the basetype then pull this to string. 
                else if (i.GetType().BaseType.Name == cboFilterBookings.SelectedItem.ToString())
                {
                    //Add the type of booking to the list.
                    lstBookings.Items.Add(i);
                }
            }
        }

        /// <summary>
        /// Method to update list. 
        /// </summary>
        private void UpdateList()
        {
            //clears the data 
            lstBookings.DataSource = null;
            //Sets the data source to the allbookings list set in memory.
            lstBookings.DataSource = allBookings.AllBookings;
            //Refreshs the list.
            lstBookings.Refresh();
        }
        /// <summary>
        /// Adds a new booking to the list. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewRoomBooking_Click(object sender, EventArgs e)
        {
            //Sets up new add booking form in memory.
            addBooking = new AddBookingForm();
            //If statement to check if dialog result is okay.
            if (addBooking.ShowDialog() == DialogResult.OK)
            {
                //Sets up a Booking object in memory
                Booking booking = addBooking.GetBooking();
                //Sets a boolean value to check if duplicate variable is true or false.
                //Itterates to look for a booking and if a booking with an ID is already present then sets the value to true. 
                bool duplicateCheck = false;
                foreach (Booking b in allBookings.AllBookings)
                {
                    int id = b.Id;
                    if (id == addBooking.GetBooking().Id)
                    {
                        duplicateCheck = true;
                    }
                }
                //Displays an error message if the value is true. 
                if (duplicateCheck == true)
                {
                    MessageBox.Show("ID Already present");
                }
                //Adds the booking to the list and then disposes the form when the process finishes. 
                else
                {
                    allBookings.AllBookings.Add(booking);
                    UpdateList();
                    LoadComboBoxFilterType();
                    addBooking.Dispose();
                }
            }
            //Displays a message to let the user know the booking did not go ahead and disposes with the form.
            else
            {
                MessageBox.Show("Adding booking canceled");
                addBooking.Dispose();
            }
        }

        private void UoRBookingSystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Deletes a booking from the list. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteRoomBooking_Click(object sender, EventArgs e)
        {
            try
            {
                //Deletes the booking that was selected by the user.
                //Disposes of the booking and then updates the list and combo types.
                allBookings.AllBookings.RemoveAt(lstBookings.SelectedIndex);
                addBooking.Dispose();
                UpdateList();
                LoadComboBoxFilterType();
            }
            catch
            {
                MessageBox.Show("Please select a booking to delete");
            }
            
        }
        /// <summary>
        /// Saves the list to a .dat file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveList_Click(object sender, EventArgs e)
        {
            allBookings.SaveList();
            UpdateList();
        }

        /// <summary>
        /// Loads the list from a .dat file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomBookings_Load(object sender, EventArgs e)
        {
            allBookings.LoadList();
            UpdateList();
            LoadComboBoxFilterType();
            
        }

        /// <summary>
        /// Updates the list and combo boxes on load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstLoadBooking_Click(object sender, EventArgs e)
        {
            allBookings.LoadList();
            UpdateList();
            LoadComboBoxFilterType();
        }

        /// <summary>
        /// Edits a selected booking and replaces that with a new booking.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditRoomBooking_Click(object sender, EventArgs e)
        {
            try
            {   
                addBooking = new AddBookingForm();
                allBookings.AllBookings.RemoveAt(lstBookings.SelectedIndex);
                MessageBox.Show("You will be issued with a new booking ID upon edit");
                if (addBooking.ShowDialog() == DialogResult.OK)
                {
                    Booking booking = addBooking.GetBooking();
                    allBookings.AllBookings.Add(booking);
                    UpdateList();
                    MessageBox.Show("Updated entry will now save");
                    allBookings.SaveList();
                }

                else
                {
                    MessageBox.Show("Editing Booking Canceled");
                }
                
                
            }
            catch
            {
                MessageBox.Show("Please select a booking to ammend");
            }
            
        }
        /// <summary>
        /// When the form activates update list and load filter types. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomBookings_Activated(object sender, EventArgs e)
        {
            UpdateList();
            LoadComboBoxFilterType();
        }

      
    }
    
}
