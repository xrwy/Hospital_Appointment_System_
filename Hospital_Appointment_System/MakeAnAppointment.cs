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
    public partial class MakeAnAppointment : Form
    {
        public MakeAnAppointment()
        {
            InitializeComponent();
        }
        HospitalEntities hst = new HospitalEntities();

        public string identity;
        public int id_;
        public void getInfo(string identity_)
        {
            identity = identity_;
        }

        string city, district, clinic, hospital, inspection_Place, physician, appointmentDate, appointmentTime;

        private void appointmentDelete_Click(object sender, EventArgs e)
        {
            if (appointmentId.Text == "")
            {
                MessageBox.Show("Do not leave the fields blank.");
            }
            else
            {
                int meetingId1 = int.Parse(appointmentId.Text);
                bool trueOrFalse3 = hst.Meetings.Any(meeting => meeting.Meeting_ID == meetingId1);
                if (trueOrFalse3)
                {
                    try
                    {
                        int randevuId = int.Parse(appointmentId.Text);
                        var data = hst.Meetings.FirstOrDefault(meeting => meeting.Meeting_ID == randevuId);

                        var policlinicId = data.Policlinic_ID;
                        var doctorId = data.Doctor_ID;
                        var hourId = data.Hour_ID;
                        var dateId = data.Date_ID;
                        var patientId = data.Patient_ID;

                        var findMeeting = hst.Meetings.Find(randevuId);
                        hst.Meetings.Remove(findMeeting);
                        hst.SaveChanges();

                        var findPoliclinics = hst.Policlinics.Find(policlinicId);
                        hst.Policlinics.Remove(findPoliclinics);
                        hst.SaveChanges();

                        var findPatient = hst.Patients.Find(patientId);
                        hst.Patients.Remove(findPatient);
                        hst.SaveChanges();

                        var findDoctor = hst.Doctors.Find(doctorId);
                        hst.Doctors.Remove(findDoctor);
                        hst.SaveChanges();

                        var findHour = hst.Hours.Find(hourId);
                        hst.Hours.Remove(findHour);
                        hst.SaveChanges();

                        var findDate = hst.Dates.Find(dateId);
                        hst.Dates.Remove(findDate);

                        hst.SaveChanges();

                        MessageBox.Show("Appointment Successfully Deleted");
                        appointmentId.Text = "";

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error Occurred While Deleting Appointment: " + error);
                    }
                }
                else
                {
                    MessageBox.Show("No Such ID Found.");
                }
            }
        }

        private void myAppointments_Click(object sender, EventArgs e)
        {

        }

        private void clickToUpdateAppointmentBtn_Click(object sender, EventArgs e)
        {
            UpdateAppointment updateAppointment = new UpdateAppointment();
            updateAppointment.getInfox(identity, id_);
            updateAppointment.ShowDialog();
            this.Hide();
        }

        private void makeAnAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (cityComboBox.SelectedItem is null || districtComboBox.SelectedItem is null || clinicComboBox.SelectedItem is null || hospitalComboBox.SelectedItem is null || inspectionPlaceComboBox.SelectedItem is null || physicianComboBox.SelectedItem is null || appointmentDateTimePicker.Value.ToString() == "" || appointmentDate is null || appointmentTimeComboBox.SelectedItem is null)
            {
                city = "";
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
                district = districtComboBox.SelectedItem.ToString();
                clinic = clinicComboBox.SelectedItem.ToString();
                hospital = hospitalComboBox.SelectedItem.ToString();
                inspection_Place = inspectionPlaceComboBox.SelectedItem.ToString();
                physician = physicianComboBox.SelectedItem.ToString();
                appointmentDate = appointmentDateTimePicker.Text.ToString();
                appointmentTime = appointmentTimeComboBox.SelectedItem.ToString();
            }
            if (city == "" || district == "" || clinic == "" || hospital == "" || inspection_Place == "" || physician == "" || appointmentDate == "" || appointmentTime == "")
            {
                MessageBox.Show("Do not leave the fields blank.");
            }
            else
            {
                try
                {
                    var _data = hst.Members.FirstOrDefault(member => member.Member_Identity == identity);
                    Patient patient = new Patient
                    {
                        Patient_Identity = _data.Member_Identity,
                        Patient_Name = _data.Member_Name,
                        Patient_Lastname = _data.Member_Lastname,
                        Patient_Date_of_birth = _data.Member_Date_of_birth,
                        Patient_Gender = _data.Member_Gender
                    };
                    hst.Members.Select(member => member.Member_Identity == identity).Distinct();
                    hst.Patients.Add(patient);
                    hst.SaveChanges();


                    var splitPhysician = physician.Split();
                    string newName = "";
                    for (int i = 0; i <= splitPhysician.Length - 2; i++)
                    {
                        newName += splitPhysician[i].ToString() + " ";
                    }

                    Doctor doctor = new Doctor
                    {
                        Doctor_Name = newName,
                        Doctor_Lastname = splitPhysician[splitPhysician.Length - 1].ToString()
                    };

                    hst.Doctors.Add(doctor);
                    hst.SaveChanges();

                    int doctorID = hst.Doctors.Max(max => max.Doctor_ID);
                    Policlinic policlinic = new Policlinic
                    {
                        Policlinic_City = city,
                        Policlinic_District = district,
                        Policlinic_Hospital = hospital,
                        Policlinic_Name = clinic,
                        Policlinic_Place = inspection_Place,
                        Doctor_ID = doctorID

                    };
                    hst.Policlinics.Add(policlinic);
                    hst.SaveChanges();


                    Date date = new Date
                    {
                        Appointment_Date = appointmentDate
                    };

                    hst.Dates.Add(date);
                    hst.SaveChanges();

                    Hour hour = new Hour
                    {
                        Appointment_Time = appointmentTime
                    };

                    hst.Hours.Add(hour);
                    hst.SaveChanges();


                    int polId = hst.Policlinics.Max(_policlinic => _policlinic.Policlinic_ID);
                    int doctorId = hst.Doctors.Max(_doctor => _doctor.Doctor_ID);
                    int hourId = hst.Hours.Max(_hour => _hour.Hour_ID);
                    int dateId = hst.Dates.Max(_date => _date.Date_ID);
                    int parientId = hst.Patients.Max(_patient => _patient.Patient_ID);

                    Meeting meeting = new Meeting
                    {
                        Policlinic_ID = polId,
                        Patient_ID = parientId,
                        Doctor_ID = doctorId,
                        Hour_ID = hourId,
                        Date_ID = dateId
                    };

                    hst.Meetings.Add(meeting);
                    hst.SaveChanges();

                    int polIdd = hst.Meetings.Max(meeting_ => meeting_.Meeting_ID);

                    MessageBox.Show("Appointment Successfully Made");
                    id_ = polIdd;
                    MessageBox.Show("Your Appointment Id Please Do Not Lose:" + polIdd.ToString());
                    MessageBox.Show("Your Appointment Information" + "\n\nMeeting ID :" + id_ + "\nCity : " + city + "\nDistrict :" + district + "\nClinic :" + clinic + "\nHospital :" + hospital + "\n" +
                        "Inspection Place : " + inspection_Place + "\nPhysician :" + physician + "\nAppointment Time :" + appointmentTime + "\nAppointment Date :" + appointmentDate);

                    foreach (Control object_ in this.Controls)
                    {
                        if ((object_) is ComboBox)
                        {
                            object_.Text = "";
                        }
                    }
                    foreach (Control object_2 in this.Controls)
                    {
                        if ((object_2) is DateTimePicker)
                        {
                            object_2.Text = "";
                        }
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("An Error Occurred While Making an Appointment : " + error);
                }
            }
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(4000);
            MessageBox.Show("You Have Successfully Signed Out.");

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
