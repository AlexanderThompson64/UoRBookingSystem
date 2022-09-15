
namespace UoRBookingSystemSprint2
{
    partial class AddBookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNewRoomBooking = new System.Windows.Forms.Label();
            this.lblPleaseCompleteAllFields = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblTeachingOrMeeting = new System.Windows.Forms.Label();
            this.rdoTeachingOption = new System.Windows.Forms.RadioButton();
            this.rdoMeetingOption = new System.Windows.Forms.RadioButton();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.txtModuleCode = new System.Windows.Forms.TextBox();
            this.lblItRequired = new System.Windows.Forms.Label();
            this.lblRefreshments = new System.Windows.Forms.Label();
            this.lblLecturerLoginId = new System.Windows.Forms.Label();
            this.txtLecturerLoginId = new System.Windows.Forms.TextBox();
            this.lblNoOfAttendees = new System.Windows.Forms.Label();
            this.txtNoOfAttendees = new System.Windows.Forms.TextBox();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.chkItRequired = new System.Windows.Forms.CheckBox();
            this.chkRefreshmentsRequired = new System.Windows.Forms.CheckBox();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNewRoomBooking
            // 
            this.lblNewRoomBooking.AutoSize = true;
            this.lblNewRoomBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewRoomBooking.Location = new System.Drawing.Point(8, 9);
            this.lblNewRoomBooking.Name = "lblNewRoomBooking";
            this.lblNewRoomBooking.Size = new System.Drawing.Size(0, 25);
            this.lblNewRoomBooking.TabIndex = 2;
            this.lblNewRoomBooking.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblPleaseCompleteAllFields
            // 
            this.lblPleaseCompleteAllFields.AutoSize = true;
            this.lblPleaseCompleteAllFields.Location = new System.Drawing.Point(8, 14);
            this.lblPleaseCompleteAllFields.Name = "lblPleaseCompleteAllFields";
            this.lblPleaseCompleteAllFields.Size = new System.Drawing.Size(188, 20);
            this.lblPleaseCompleteAllFields.TabIndex = 3;
            this.lblPleaseCompleteAllFields.Text = "Please complete all fields -";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(83, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(66, 73);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(27, 106);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(80, 20);
            this.lblStartTime.TabIndex = 8;
            this.lblStartTime.Text = "Start Time:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(113, 136);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(179, 27);
            this.txtDuration.TabIndex = 11;
            this.txtDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuration_KeyPress);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(37, 139);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(70, 20);
            this.lblDuration.TabIndex = 10;
            this.lblDuration.Text = "Duration:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(113, 169);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(179, 27);
            this.txtRoomName.TabIndex = 13;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(11, 172);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(96, 20);
            this.lblRoomName.TabIndex = 12;
            this.lblRoomName.Text = "Room Name:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(113, 202);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(179, 27);
            this.txtCapacity.TabIndex = 15;
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(38, 205);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(69, 20);
            this.lblCapacity.TabIndex = 14;
            this.lblCapacity.Text = "Capacity:";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(113, 235);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(179, 27);
            this.txtContactName.TabIndex = 17;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(0, 238);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(107, 20);
            this.lblContactName.TabIndex = 16;
            this.lblContactName.Text = "Contact Name:";
            // 
            // lblTeachingOrMeeting
            // 
            this.lblTeachingOrMeeting.AutoSize = true;
            this.lblTeachingOrMeeting.Location = new System.Drawing.Point(8, 315);
            this.lblTeachingOrMeeting.Name = "lblTeachingOrMeeting";
            this.lblTeachingOrMeeting.Size = new System.Drawing.Size(242, 20);
            this.lblTeachingOrMeeting.TabIndex = 18;
            this.lblTeachingOrMeeting.Text = "Please select the type of booking - ";
            // 
            // rdoTeachingOption
            // 
            this.rdoTeachingOption.AutoSize = true;
            this.rdoTeachingOption.Location = new System.Drawing.Point(257, 315);
            this.rdoTeachingOption.Name = "rdoTeachingOption";
            this.rdoTeachingOption.Size = new System.Drawing.Size(89, 24);
            this.rdoTeachingOption.TabIndex = 19;
            this.rdoTeachingOption.TabStop = true;
            this.rdoTeachingOption.Text = "Teaching";
            this.rdoTeachingOption.UseVisualStyleBackColor = true;
            this.rdoTeachingOption.CheckedChanged += new System.EventHandler(this.rdoTeachingOption_CheckedChanged);
            // 
            // rdoMeetingOption
            // 
            this.rdoMeetingOption.AutoSize = true;
            this.rdoMeetingOption.Location = new System.Drawing.Point(257, 345);
            this.rdoMeetingOption.Name = "rdoMeetingOption";
            this.rdoMeetingOption.Size = new System.Drawing.Size(85, 24);
            this.rdoMeetingOption.TabIndex = 20;
            this.rdoMeetingOption.TabStop = true;
            this.rdoMeetingOption.Text = "Meeting";
            this.rdoMeetingOption.UseVisualStyleBackColor = true;
            this.rdoMeetingOption.CheckedChanged += new System.EventHandler(this.rdoMeetingOption_CheckedChanged);
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Location = new System.Drawing.Point(376, 68);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(102, 20);
            this.lblModuleCode.TabIndex = 21;
            this.lblModuleCode.Text = "Module Code:";
            // 
            // txtModuleCode
            // 
            this.txtModuleCode.Location = new System.Drawing.Point(482, 68);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.Size = new System.Drawing.Size(125, 27);
            this.txtModuleCode.TabIndex = 22;
            // 
            // lblItRequired
            // 
            this.lblItRequired.AutoSize = true;
            this.lblItRequired.Location = new System.Drawing.Point(390, 106);
            this.lblItRequired.Name = "lblItRequired";
            this.lblItRequired.Size = new System.Drawing.Size(88, 20);
            this.lblItRequired.TabIndex = 23;
            this.lblItRequired.Text = "IT Required:";
            // 
            // lblRefreshments
            // 
            this.lblRefreshments.AutoSize = true;
            this.lblRefreshments.Location = new System.Drawing.Point(377, 70);
            this.lblRefreshments.Name = "lblRefreshments";
            this.lblRefreshments.Size = new System.Drawing.Size(101, 20);
            this.lblRefreshments.TabIndex = 27;
            this.lblRefreshments.Text = "Refreshments:";
            // 
            // lblLecturerLoginId
            // 
            this.lblLecturerLoginId.AutoSize = true;
            this.lblLecturerLoginId.Location = new System.Drawing.Point(353, 170);
            this.lblLecturerLoginId.Name = "lblLecturerLoginId";
            this.lblLecturerLoginId.Size = new System.Drawing.Size(125, 20);
            this.lblLecturerLoginId.TabIndex = 30;
            this.lblLecturerLoginId.Text = "Lecturer Login ID:";
            // 
            // txtLecturerLoginId
            // 
            this.txtLecturerLoginId.Location = new System.Drawing.Point(482, 166);
            this.txtLecturerLoginId.Name = "txtLecturerLoginId";
            this.txtLecturerLoginId.Size = new System.Drawing.Size(125, 27);
            this.txtLecturerLoginId.TabIndex = 31;
            // 
            // lblNoOfAttendees
            // 
            this.lblNoOfAttendees.AutoSize = true;
            this.lblNoOfAttendees.Location = new System.Drawing.Point(323, 106);
            this.lblNoOfAttendees.Name = "lblNoOfAttendees";
            this.lblNoOfAttendees.Size = new System.Drawing.Size(155, 20);
            this.lblNoOfAttendees.TabIndex = 32;
            this.lblNoOfAttendees.Text = "Number of Attendees:";
            this.lblNoOfAttendees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNoOfAttendees
            // 
            this.txtNoOfAttendees.Location = new System.Drawing.Point(482, 103);
            this.txtNoOfAttendees.Name = "txtNoOfAttendees";
            this.txtNoOfAttendees.Size = new System.Drawing.Size(125, 27);
            this.txtNoOfAttendees.TabIndex = 33;
            this.txtNoOfAttendees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfAttendees_KeyPress);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBooking.Location = new System.Drawing.Point(513, 315);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(94, 53);
            this.btnAddBooking.TabIndex = 34;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // chkItRequired
            // 
            this.chkItRequired.AutoSize = true;
            this.chkItRequired.Location = new System.Drawing.Point(482, 109);
            this.chkItRequired.Name = "chkItRequired";
            this.chkItRequired.Size = new System.Drawing.Size(18, 17);
            this.chkItRequired.TabIndex = 35;
            this.chkItRequired.UseVisualStyleBackColor = true;
            this.chkItRequired.CheckedChanged += new System.EventHandler(this.chkItRequired_CheckedChanged);
            // 
            // chkRefreshmentsRequired
            // 
            this.chkRefreshmentsRequired.AutoSize = true;
            this.chkRefreshmentsRequired.Location = new System.Drawing.Point(482, 73);
            this.chkRefreshmentsRequired.Name = "chkRefreshmentsRequired";
            this.chkRefreshmentsRequired.Size = new System.Drawing.Size(18, 17);
            this.chkRefreshmentsRequired.TabIndex = 36;
            this.chkRefreshmentsRequired.UseVisualStyleBackColor = true;
            this.chkRefreshmentsRequired.CheckedChanged += new System.EventHandler(this.chkRefreshmentsRequired_CheckedChanged);
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Location = new System.Drawing.Point(116, 40);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(0, 20);
            this.lblIdValue.TabIndex = 37;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(179, 27);
            this.txtId.TabIndex = 38;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(113, 70);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(179, 27);
            this.txtDate.TabIndex = 39;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(113, 103);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(179, 27);
            this.txtStartTime.TabIndex = 40;
            // 
            // AddBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.chkRefreshmentsRequired);
            this.Controls.Add(this.chkItRequired);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.rdoMeetingOption);
            this.Controls.Add(this.rdoTeachingOption);
            this.Controls.Add(this.lblTeachingOrMeeting);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPleaseCompleteAllFields);
            this.Controls.Add(this.lblNewRoomBooking);
            this.Controls.Add(this.lblRefreshments);
            this.Controls.Add(this.lblNoOfAttendees);
            this.Controls.Add(this.txtNoOfAttendees);
            this.Controls.Add(this.lblLecturerLoginId);
            this.Controls.Add(this.txtLecturerLoginId);
            this.Controls.Add(this.lblItRequired);
            this.Controls.Add(this.lblModuleCode);
            this.Controls.Add(this.txtModuleCode);
            this.Name = "AddBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Booking";
            this.Activated += new System.EventHandler(this.AddBookingForm_Activated);
            this.Load += new System.EventHandler(this.UoRAddBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewRoomBooking;
        private System.Windows.Forms.Label lblPleaseCompleteAllFields;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblTeachingOrMeeting;
        private System.Windows.Forms.RadioButton rdoTeachingOption;
        private System.Windows.Forms.RadioButton rdoMeetingOption;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.TextBox txtModuleCode;
        private System.Windows.Forms.Label lblItRequired;
        private System.Windows.Forms.Label lblRefreshments;
        private System.Windows.Forms.Label lblLecturerLoginId;
        private System.Windows.Forms.TextBox txtLecturerLoginId;
        private System.Windows.Forms.Label lblNoOfAttendees;
        private System.Windows.Forms.TextBox txtNoOfAttendees;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.CheckBox chkItRequired;
        private System.Windows.Forms.CheckBox chkRefreshmentsRequired;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtStartTime;
    }
}