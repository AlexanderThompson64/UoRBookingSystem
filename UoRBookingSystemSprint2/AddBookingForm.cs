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
    [Serializable]
    public partial class AddBookingForm : Form
    {
        /// <summary>
        /// Custom exception that catches an error if the user enters a duration longer than 180
        /// </summary>
        public class Custom_Exception_MaxBookingExceeded : Exception
        {
            private static String msg = "Booking duration cannot exceed 180 minutes!";
            public Custom_Exception_MaxBookingExceeded()
                : base(msg)
            {
            }
        }
        
        /// <summary>
        /// Intializes the form.
        /// </summary>
        Booking booking;
        public AddBookingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get booking returns an object to be added to the list manager class. 
        /// </summary>
        /// <returns>Booking object Teaching/Meeting depending what the user selects.</returns>
        public Booking GetBooking()
        {
            return booking;
        }
       
        /// <summary>
        /// Sets and creates the booking object.
        /// </summary>
        public void SetBooking()
        {
            if (rdoTeachingOption.Checked & !rdoMeetingOption.Checked)
            {
                if (chkItRequired.Checked)
                {
                    booking = new TeachingBooking(Convert.ToInt32(txtId.Text), "Teaching", txtDate.Text, txtStartTime.Text, Convert.ToInt32(txtDuration.Text), txtRoomName.Text, Convert.ToInt32(txtCapacity.Text),
                      txtContactName.Text, txtModuleCode.Text, "Yes", txtLecturerLoginId.Text);
                }

                else if (!chkItRequired.Checked)
                {
                    booking = new TeachingBooking(Convert.ToInt32(txtId.Text), "Teaching", txtDate.Text, txtStartTime.Text, Convert.ToInt32(txtDuration.Text), txtRoomName.Text, Convert.ToInt32(txtCapacity.Text),
                      txtContactName.Text, txtModuleCode.Text, "No", "N/A");
                }

                if (Convert.ToInt32(txtDuration.Text) > 180)
                {
                    throw new Custom_Exception_MaxBookingExceeded();
                }
                this.Close();
            }

            else if (rdoMeetingOption.Checked & !rdoTeachingOption.Checked)
            {
                if (chkRefreshmentsRequired.Checked)
                {
                    booking = new MeetingBooking(Convert.ToInt32(txtId.Text), "Meeting", txtDate.Text, txtStartTime.Text, Convert.ToInt32(txtDuration.Text), txtRoomName.Text, Convert.ToInt32(txtCapacity.Text),
                    txtContactName.Text, "Yes", Convert.ToInt32(txtNoOfAttendees.Text));
                }

                else if (!chkRefreshmentsRequired.Checked)
                {
                    booking = new MeetingBooking(Convert.ToInt32(txtId.Text), "Meeting", txtDate.Text, txtStartTime.Text, Convert.ToInt32(txtDuration.Text), txtRoomName.Text, Convert.ToInt32(txtCapacity.Text),
                    txtContactName.Text, "No", 0);
                }

                if (Convert.ToInt32(txtDuration.Text) > 180)
                {
                    throw new Custom_Exception_MaxBookingExceeded();
                }
                this.Close();
            }
        }

        /// <summary>
        /// Method to clear certain user input fields of the meeting option is checked. 
        /// </summary>
        /// <param name="pIsTeachingBooking"></param>
        void TeachingBookings(bool pIsTeachingBooking)
        {
            if (pIsTeachingBooking == false)
            {
                lblModuleCode.Hide();
                txtModuleCode.Hide();
                txtModuleCode.Clear();
                lblItRequired.Hide();
                lblLecturerLoginId.Hide();
                txtLecturerLoginId.Hide();
                txtLecturerLoginId.Clear();
                chkItRequired.Hide();
            }
            else
            {
                lblModuleCode.Show();
                txtModuleCode.Show();
                lblItRequired.Show();
                chkItRequired.Show();
            }

        }

        /// <summary>
        /// Method to clear certain user input fields of the Teaching option is checked. 
        /// </summary>
        /// <param name="pIsMeetingBooking"></param>
        void MeetingBookings(bool pIsMeetingBooking)
        {
            if (pIsMeetingBooking == false)
            {
                lblRefreshments.Hide();
                lblNoOfAttendees.Hide();
                txtNoOfAttendees.Hide();
                txtNoOfAttendees.Clear();
                chkRefreshmentsRequired.Hide();
            }
            else
            {
                lblRefreshments.Show();
                chkRefreshmentsRequired.Show();
            }
        }

        /// <summary>
        /// Hides or shows form entry data if the user selects IT requirement. 
        /// </summary>
        void ItRequired()
        {
            if (chkItRequired.Checked)
            {
                lblLecturerLoginId.Show();
                txtLecturerLoginId.Show();
            }
            else
            {
                lblLecturerLoginId.Hide();
                txtLecturerLoginId.Hide();
                txtLecturerLoginId.Clear();
            }
        }

        /// <summary>
        /// Hides or shows form entry data if the user selects IT requirement. 
        /// </summary>
        void RefreshmentsRequired()
        {
            if (chkRefreshmentsRequired.Checked)
            {
                lblNoOfAttendees.Show();
                txtNoOfAttendees.Show();
            }
            else
            {
                lblNoOfAttendees.Hide();
                txtNoOfAttendees.Hide();
                txtNoOfAttendees.Clear();
            }
        }

        private void UoRAddBookingForm_Load(object sender, EventArgs e)
        {
            
            TeachingBookings(false);
            MeetingBookings(false);
        }

        private void rdoTeachingOption_CheckedChanged(object sender, EventArgs e)
        {
            TeachingBookings(true);
            MeetingBookings(false);
        }

        private void rdoMeetingOption_CheckedChanged(object sender, EventArgs e)
        {
            MeetingBookings(true);
            TeachingBookings(false);
        }

        private void chkRefreshmentsRequired_CheckedChanged(object sender, EventArgs e)
        {
            RefreshmentsRequired();
        }

        private void chkItRequired_CheckedChanged(object sender, EventArgs e)
        {
            ItRequired();
        }
        public void btnAddBooking_Click(object sender, EventArgs e)
        {
            //Checks the text boxes to make sure they are not empty and if they are displays a prompt to the user to fill out all fields.
            if (!rdoMeetingOption.Checked & !rdoTeachingOption.Checked)
            {
                MessageBox.Show("Please select a booking type");
            }

            else if (txtId.Text == "" || txtDate.Text == "" || txtStartTime.Text == "" || txtDuration.Text == "" || txtRoomName.Text == "" || txtCapacity.Text == ""
                || txtContactName.Text == "")
            {
                MessageBox.Show("All Fields must be completed");
            }

            else if (rdoTeachingOption.Checked && txtModuleCode.Text == "")
            {
                MessageBox.Show("Please enter a module code");
            }

            else if (chkItRequired.Checked && txtLecturerLoginId.Text == "")
            {
                MessageBox.Show("Please enter lecturer ID");
            }

            else if (chkRefreshmentsRequired.Checked && txtNoOfAttendees.Text == "")
            {
                MessageBox.Show("Please enter number of attendees");
            }
            else
            {
                //If all form input is acceptable and the duration is not over 180 minutes set the booking object up to be passed into memory. 
                try
                {
                    SetBooking();
                    DialogResult = DialogResult.OK;
                }
                //Throw the custom exception for duration exceeding 1
                catch (Custom_Exception_MaxBookingExceeded ex)
                {
                    MessageBox.Show(ex.Message);
                    txtDuration.Text = "";
                }
            }

        }

        /// <summary>
        /// User validation that stops the user entering letters or characters into text boxes meant for numbers. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter numbers only!");
            }
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter numbers only!");
            }
        }

        private void AddBookingForm_Activated(object sender, EventArgs e)
        {

        }

        private void txtNoOfAttendees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter numbers only!");
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter numbers only!");
            }
        }
    }
}
