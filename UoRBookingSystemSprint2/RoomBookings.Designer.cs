
namespace UoRBookingSystemSprint2
{
    partial class RoomBookings
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
            this.lblRoomBookings = new System.Windows.Forms.Label();
            this.btnNewRoomBooking = new System.Windows.Forms.Button();
            this.btnDeleteRoomBooking = new System.Windows.Forms.Button();
            this.lstBookings = new System.Windows.Forms.ListBox();
            this.cboFilterBookings = new System.Windows.Forms.ComboBox();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.lstLoadBooking = new System.Windows.Forms.Button();
            this.btnEditRoomBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRoomBookings
            // 
            this.lblRoomBookings.AutoSize = true;
            this.lblRoomBookings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomBookings.Location = new System.Drawing.Point(13, 13);
            this.lblRoomBookings.Name = "lblRoomBookings";
            this.lblRoomBookings.Size = new System.Drawing.Size(143, 25);
            this.lblRoomBookings.TabIndex = 1;
            this.lblRoomBookings.Text = "Room Bookings";
            // 
            // btnNewRoomBooking
            // 
            this.btnNewRoomBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewRoomBooking.Location = new System.Drawing.Point(1558, 133);
            this.btnNewRoomBooking.Name = "btnNewRoomBooking";
            this.btnNewRoomBooking.Size = new System.Drawing.Size(161, 49);
            this.btnNewRoomBooking.TabIndex = 2;
            this.btnNewRoomBooking.Text = "New Room Booking";
            this.btnNewRoomBooking.UseVisualStyleBackColor = true;
            this.btnNewRoomBooking.Click += new System.EventHandler(this.btnNewRoomBooking_Click);
            // 
            // btnDeleteRoomBooking
            // 
            this.btnDeleteRoomBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRoomBooking.Location = new System.Drawing.Point(1558, 243);
            this.btnDeleteRoomBooking.Name = "btnDeleteRoomBooking";
            this.btnDeleteRoomBooking.Size = new System.Drawing.Size(161, 49);
            this.btnDeleteRoomBooking.TabIndex = 3;
            this.btnDeleteRoomBooking.Text = "Delete Room Booking";
            this.btnDeleteRoomBooking.UseVisualStyleBackColor = true;
            this.btnDeleteRoomBooking.Click += new System.EventHandler(this.btnDeleteRoomBooking_Click);
            // 
            // lstBookings
            // 
            this.lstBookings.FormattingEnabled = true;
            this.lstBookings.HorizontalScrollbar = true;
            this.lstBookings.ItemHeight = 20;
            this.lstBookings.Location = new System.Drawing.Point(13, 51);
            this.lstBookings.Name = "lstBookings";
            this.lstBookings.Size = new System.Drawing.Size(1539, 384);
            this.lstBookings.TabIndex = 7;
            // 
            // cboFilterBookings
            // 
            this.cboFilterBookings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterBookings.FormattingEnabled = true;
            this.cboFilterBookings.Location = new System.Drawing.Point(1558, 78);
            this.cboFilterBookings.Name = "cboFilterBookings";
            this.cboFilterBookings.Size = new System.Drawing.Size(161, 28);
            this.cboFilterBookings.TabIndex = 8;
            this.cboFilterBookings.SelectedIndexChanged += new System.EventHandler(this.cboFilterBookings_SelectedIndexChanged);
            // 
            // btnSaveList
            // 
            this.btnSaveList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveList.Location = new System.Drawing.Point(1558, 298);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(161, 49);
            this.btnSaveList.TabIndex = 9;
            this.btnSaveList.Text = "Save Booking List";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // lstLoadBooking
            // 
            this.lstLoadBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstLoadBooking.Location = new System.Drawing.Point(1558, 353);
            this.lstLoadBooking.Name = "lstLoadBooking";
            this.lstLoadBooking.Size = new System.Drawing.Size(161, 49);
            this.lstLoadBooking.TabIndex = 10;
            this.lstLoadBooking.Text = "Load Booking List";
            this.lstLoadBooking.UseVisualStyleBackColor = true;
            this.lstLoadBooking.Click += new System.EventHandler(this.lstLoadBooking_Click);
            // 
            // btnEditRoomBooking
            // 
            this.btnEditRoomBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditRoomBooking.Location = new System.Drawing.Point(1558, 188);
            this.btnEditRoomBooking.Name = "btnEditRoomBooking";
            this.btnEditRoomBooking.Size = new System.Drawing.Size(161, 49);
            this.btnEditRoomBooking.TabIndex = 11;
            this.btnEditRoomBooking.Text = "Edit Room Booking";
            this.btnEditRoomBooking.UseVisualStyleBackColor = true;
            this.btnEditRoomBooking.Click += new System.EventHandler(this.btnEditRoomBooking_Click);
            // 
            // RoomBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1994, 649);
            this.Controls.Add(this.btnEditRoomBooking);
            this.Controls.Add(this.lstLoadBooking);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.cboFilterBookings);
            this.Controls.Add(this.lstBookings);
            this.Controls.Add(this.btnDeleteRoomBooking);
            this.Controls.Add(this.btnNewRoomBooking);
            this.Controls.Add(this.lblRoomBookings);
            this.Name = "RoomBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UoR Booking Portal";
            this.Activated += new System.EventHandler(this.RoomBookings_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UoRBookingSystemForm_FormClosing);
            this.Load += new System.EventHandler(this.RoomBookings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRoomBookings;
        private System.Windows.Forms.Button btnNewRoomBooking;
        private System.Windows.Forms.Button btnDeleteRoomBooking;
        private System.Windows.Forms.ListBox lstBookings;
        private System.Windows.Forms.ComboBox cboFilterBookings;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.Button lstLoadBooking;
        private System.Windows.Forms.Button btnEditRoomBooking;
    }
}