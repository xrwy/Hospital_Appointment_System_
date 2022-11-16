using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Appointment_System
{
    public partial class UpdateAppointment : Form
    {
        public UpdateAppointment()
        {
            InitializeComponent();
        }

        HospitalEntities hst = new HospitalEntities();

        public string identity;
        public int id2;
        string city, district, clinic, hospital, inspection_Place, physician, appointmentDate, appointmentTime;

        public void getInfox(string identity_, int id_)
        {
            identity = identity_;
            id2 = id_;
        }
        public void keyPressEvent()
        {
            if (appointmentID.Text == "" || cityComboBox.SelectedItem is null || districtComboBox.SelectedItem is null || clinicComboBox.SelectedItem is null || hospitalComboBox.SelectedItem is null || inspectionPlaceComboBox.SelectedItem is null || physicianComboBox.SelectedItem is null || physicianComboBox.SelectedItem is null || appointmentDateTimePicker.Value.ToString() == "")
            {
                district = "";
                clinic = "";
                hospital = "";
                inspection_Place = "";
                physician = "";
                appointmentDate = "";
                appointmentTime = "";
            }
            else
            {
                city = cityComboBox.SelectedItem.ToString();
                district = cityComboBox.SelectedItem.ToString();
                clinic = clinicComboBox.SelectedItem.ToString();
                hospital = hospitalComboBox.SelectedItem.ToString();
                inspection_Place = inspectionPlaceComboBox.SelectedItem.ToString();
                physician = physicianComboBox.SelectedItem.ToString();
                appointmentDate = appointmentDateTimePicker.Text.ToString();
                appointmentTime = appointmentTimeComboBox.SelectedItem.ToString();
            }

            var trueOrFalse5 = hst.Patients.Any(patient => patient.Patient_Identity == identity);

            var data1 = hst.Patients.FirstOrDefault(patient => patient.Patient_Identity == identity);
            if(appointmentID.Text == "")
            {
                MessageBox.Show("Do not leave the fields blank. FILL !!!");
            }else
            {
                var idValue = int.Parse(appointmentID.Text);
                var data = hst.Meetings.FirstOrDefault(meeting => meeting.Meeting_ID == idValue);

                if (city == "" || district == "" || clinic == "" || hospital == "" || inspection_Place == "" || physician == "" || appointmentDate == "" || appointmentTime == "")
                {
                    MessageBox.Show("Do not leave the fields blank. FILL !!!");
                }
                else if (trueOrFalse5)
                {
                    try
                    {
                        var polyclinicToBeUpdated = hst.Policlinics.Find(data.Policlinic_ID);

                        polyclinicToBeUpdated.Policlinic_City = city;
                        polyclinicToBeUpdated.Policlinic_District = district;
                        polyclinicToBeUpdated.Policlinic_Name = clinic;
                        polyclinicToBeUpdated.Policlinic_Hospital = hospital;
                        polyclinicToBeUpdated.Policlinic_Place = inspection_Place;



                        var splitPhysician = physician.Split();
                        string newName = "";
                        for (int i = 0; i <= splitPhysician.Length - 2; i++)
                        {
                            newName += splitPhysician[i].ToString() + " ";
                        }

                        var doctorToUpdate = hst.Doctors.Find(data.Doctor_ID);
                        doctorToUpdate.Doctor_Name = newName;
                        doctorToUpdate.Doctor_Lastname = splitPhysician[splitPhysician.Length - 1].ToString();

                        var timeToUpdate = hst.Hours.Find(data.Hour_ID);
                        timeToUpdate.Appointment_Time = appointmentTime;

                        var dateToUpdate = hst.Dates.Find(data.Date_ID);
                        dateToUpdate.Appointment_Date = appointmentDate;

                        hst.SaveChanges();

                        MessageBox.Show("Successfully Updated.");

                        cityComboBox.Text = "";
                        districtComboBox.Text = "";
                        clinicComboBox.Text = "";
                        hospitalComboBox.Text = "";
                        inspectionPlaceComboBox.Text = "";
                        physicianComboBox.Text = "";
                        appointmentTimeComboBox.Text = "";
                        appointmentDateTimePicker.Text = "";
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error Occurred While Updating: " + error);
                    }
                }
            }
        }
        private void appointmentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                keyPressEvent();
            }
        }
        private void updateAppointmentBtn_Click(object sender, EventArgs e)
        {
            keyPressEvent();
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
