namespace Hospital_Appointment_System
{
    partial class UpdateAppointment
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
            this.label9 = new System.Windows.Forms.Label();
            this.appointmentID = new System.Windows.Forms.TextBox();
            this.updateAppointmentBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.appointmentTimeComboBox = new System.Windows.Forms.ComboBox();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.physicianComboBox = new System.Windows.Forms.ComboBox();
            this.inspectionPlaceComboBox = new System.Windows.Forms.ComboBox();
            this.hospitalComboBox = new System.Windows.Forms.ComboBox();
            this.clinicComboBox = new System.Windows.Forms.ComboBox();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(44, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(425, 25);
            this.label9.TabIndex = 76;
            this.label9.Text = "Please Write Your Appointment Id For Update:";
            // 
            // appointmentID
            // 
            this.appointmentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appointmentID.Location = new System.Drawing.Point(475, 28);
            this.appointmentID.MaxLength = 10000;
            this.appointmentID.Name = "appointmentID";
            this.appointmentID.Size = new System.Drawing.Size(139, 33);
            this.appointmentID.TabIndex = 75;
            this.appointmentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.appointmentID_KeyPress);
            // 
            // updateAppointmentBtn
            // 
            this.updateAppointmentBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.updateAppointmentBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateAppointmentBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.updateAppointmentBtn.Location = new System.Drawing.Point(684, 249);
            this.updateAppointmentBtn.Name = "updateAppointmentBtn";
            this.updateAppointmentBtn.Size = new System.Drawing.Size(223, 47);
            this.updateAppointmentBtn.TabIndex = 74;
            this.updateAppointmentBtn.Text = "Update Appointment";
            this.updateAppointmentBtn.UseVisualStyleBackColor = false;
            this.updateAppointmentBtn.Click += new System.EventHandler(this.updateAppointmentBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.logOutBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logOutBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.logOutBtn.Location = new System.Drawing.Point(776, 40);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(108, 46);
            this.logOutBtn.TabIndex = 73;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // appointmentTimeComboBox
            // 
            this.appointmentTimeComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appointmentTimeComboBox.FormattingEnabled = true;
            this.appointmentTimeComboBox.Items.AddRange(new object[] {
            "13.30",
            "14.30",
            "15.30"});
            this.appointmentTimeComboBox.Location = new System.Drawing.Point(318, 417);
            this.appointmentTimeComboBox.Name = "appointmentTimeComboBox";
            this.appointmentTimeComboBox.Size = new System.Drawing.Size(303, 33);
            this.appointmentTimeComboBox.TabIndex = 72;
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(318, 372);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(303, 33);
            this.appointmentDateTimePicker.TabIndex = 71;
            // 
            // physicianComboBox
            // 
            this.physicianComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.physicianComboBox.FormattingEnabled = true;
            this.physicianComboBox.Items.AddRange(new object[] {
            "John Clarck",
            "Arthur Tom",
            "Jessica Sara"});
            this.physicianComboBox.Location = new System.Drawing.Point(318, 326);
            this.physicianComboBox.Name = "physicianComboBox";
            this.physicianComboBox.Size = new System.Drawing.Size(303, 33);
            this.physicianComboBox.TabIndex = 70;
            // 
            // inspectionPlaceComboBox
            // 
            this.inspectionPlaceComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inspectionPlaceComboBox.FormattingEnabled = true;
            this.inspectionPlaceComboBox.Items.AddRange(new object[] {
            "Grove Isle",
            "Beekman",
            "Tribeca "});
            this.inspectionPlaceComboBox.Location = new System.Drawing.Point(318, 278);
            this.inspectionPlaceComboBox.Name = "inspectionPlaceComboBox";
            this.inspectionPlaceComboBox.Size = new System.Drawing.Size(303, 33);
            this.inspectionPlaceComboBox.TabIndex = 69;
            // 
            // hospitalComboBox
            // 
            this.hospitalComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hospitalComboBox.FormattingEnabled = true;
            this.hospitalComboBox.Items.AddRange(new object[] {
            "Grove Isle Hospital",
            "Beekman Place Hospital",
            "Tribeca Hospital"});
            this.hospitalComboBox.Location = new System.Drawing.Point(318, 231);
            this.hospitalComboBox.Name = "hospitalComboBox";
            this.hospitalComboBox.Size = new System.Drawing.Size(303, 33);
            this.hospitalComboBox.TabIndex = 68;
            // 
            // clinicComboBox
            // 
            this.clinicComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clinicComboBox.FormattingEnabled = true;
            this.clinicComboBox.Items.AddRange(new object[] {
            "Cardiology",
            "Ear, Nose and Throat",
            "Internal medicine"});
            this.clinicComboBox.Location = new System.Drawing.Point(318, 184);
            this.clinicComboBox.Name = "clinicComboBox";
            this.clinicComboBox.Size = new System.Drawing.Size(303, 33);
            this.clinicComboBox.TabIndex = 67;
            // 
            // districtComboBox
            // 
            this.districtComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Items.AddRange(new object[] {
            "Grove Isle",
            "Beekman Place",
            "Tribeca"});
            this.districtComboBox.Location = new System.Drawing.Point(318, 138);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(303, 33);
            this.districtComboBox.TabIndex = 66;
            // 
            // cityComboBox
            // 
            this.cityComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Miami",
            "New York",
            "Virginia"});
            this.cityComboBox.Location = new System.Drawing.Point(318, 92);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(303, 33);
            this.cityComboBox.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(135, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 64;
            this.label8.Text = "Appointment Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(135, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Appointment Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(135, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Physician";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(135, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Inspection Place";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(135, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Hospital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(135, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "Clinic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(135, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "District";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(135, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "City";
            // 
            // UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 497);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.appointmentID);
            this.Controls.Add(this.updateAppointmentBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.appointmentTimeComboBox);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.physicianComboBox);
            this.Controls.Add(this.inspectionPlaceComboBox);
            this.Controls.Add(this.hospitalComboBox);
            this.Controls.Add(this.clinicComboBox);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateAppointment";
            this.Text = "UpdateAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox appointmentID;
        private System.Windows.Forms.Button updateAppointmentBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.ComboBox appointmentTimeComboBox;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.ComboBox physicianComboBox;
        private System.Windows.Forms.ComboBox inspectionPlaceComboBox;
        private System.Windows.Forms.ComboBox hospitalComboBox;
        private System.Windows.Forms.ComboBox clinicComboBox;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}