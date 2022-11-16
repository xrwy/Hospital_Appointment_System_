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
    public partial class AuthorizedPanel : Form
    {
        public AuthorizedPanel()
        {
            InitializeComponent();
        }

        HospitalEntities hst = new HospitalEntities();

        public bool not;
        public string identityValue_;

        public string getIdentityNumber(string identityValue)
        {
            identityValue_ = identityValue;
            not = hst.Members.Any(member => member.Member_Identity == identityValue);
            return identityValue_;
        }

        //Member member = new Member();

        private void AuthorizedPanel_Load(object sender, EventArgs e)
        {
            dataGridViewRefresh();
            dataGridView2.DataSource = hst.Members.ToList();

            dataGridView6.DataSource = hst.Patients.ToList();
            dataGridView7.DataSource = hst.Doctors.ToList();
            dataGridView8.DataSource = hst.Hours.ToList();
            dataGridView9.DataSource = hst.Policlinics.ToList();
            dataGridView10.DataSource = hst.Dates.ToList();
            dataGridView11.DataSource = hst.Members.ToList();
        }

        public void dataGridViewRefresh()
        {
            var query = from meeting_ in hst.Meetings
                        join policlinic_ in hst.Policlinics on meeting_.Policlinic_ID equals policlinic_.Policlinic_ID
                        join doctor_ in hst.Doctors on meeting_.Doctor_ID equals doctor_.Doctor_ID
                        join patient_ in hst.Patients on meeting_.Patient_ID equals patient_.Patient_ID
                        join hour_ in hst.Hours on meeting_.Hour_ID equals hour_.Hour_ID
                        join date_ in hst.Dates on meeting_.Date_ID equals date_.Date_ID

                        select new
                        {
                            meeting_.Meeting_ID,
                            patient_.Patient_ID,
                            policlinic_.Policlinic_City,
                            policlinic_.Policlinic_District,
                            policlinic_.Policlinic_Name,
                            policlinic_.Policlinic_Hospital,
                            policlinic_.Policlinic_Place,
                            doctor_.Doctor_Name,
                            date_.Appointment_Date,
                            hour_.Appointment_Time
                        };

            dataGridView1.DataSource = query.ToList();
            dataGridView3.DataSource = query.ToList();

        }

        public void addAppointment ()
        {

            string _identity, city, district, clinic, hospital, inspection_Place, physician, appointmentDate, appointmentTime;

            if (identificationNumber.Text == "" || cityComboBox.SelectedItem is null || districtComboBox.SelectedItem is null || clinicComboBox.SelectedItem is null || hospitalComboBox.SelectedItem is null || inspectionPlaceComboBox.SelectedItem is null || physicianComboBox.SelectedItem is null || appointmentDateTimePicker.Value.ToString() == "" || appointmentDateTimePicker.Text.ToString() is null || appointmentTimeComboBox.SelectedItem is null)
            {
                _identity = "";
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
                _identity = identificationNumber.Text.ToString();
                city = cityComboBox.SelectedItem.ToString();
                district = districtComboBox.SelectedItem.ToString();
                clinic = clinicComboBox.SelectedItem.ToString();
                hospital = hospitalComboBox.SelectedItem.ToString();
                inspection_Place = inspectionPlaceComboBox.SelectedItem.ToString();
                physician = physicianComboBox.SelectedItem.ToString();
                appointmentDate = appointmentDateTimePicker.Text.ToString();
                appointmentTime = appointmentTimeComboBox.SelectedItem.ToString();
            }
            if (_identity == "" || city == "" || district == "" || clinic == "" || hospital == "" || inspection_Place == "" || physician == "" || appointmentDate == "" || appointmentTime == "")
            {
                MessageBox.Show("Do not leave the fields blank.");
            }
            else
            {
                string name = getIdentityNumber(identificationNumber.Text);
                if (not)
                {
                    try
                    {
                        var res = hst.Members.FirstOrDefault(member => member.Member_Identity == identityValue_);
                        Patient patient = new Patient
                        {
                            Patient_Identity = res.Member_Identity,
                            Patient_Name = res.Member_Name,
                            Patient_Lastname = res.Member_Lastname,
                            Patient_Date_of_birth = res.Member_Date_of_birth,
                            Patient_Gender = res.Member_Gender
                        };
                        hst.Patients.Add(patient);
                        hst.SaveChanges();

                        var splitPhysician = physician.Split();
                        string newName = "";
                        for(int i = 0; i <= splitPhysician.Length - 2; i++)
                        {
                            newName += splitPhysician[i].ToString() + " ";
                        }

                        Doctor doctor = new Doctor
                        {
                            Doctor_Name = newName,
                            Doctor_Lastname = splitPhysician[splitPhysician.Length - 1].ToString(),
                        };

                        hst.Doctors.Add(doctor);
                        hst.SaveChanges();

                        int doctorId1 = hst.Doctors.Max(doctor_ => doctor_.Doctor_ID);

                        Policlinic policlinic = new Policlinic
                        {
                            Policlinic_City = city,
                            Policlinic_District = district,
                            Policlinic_Hospital = hospital,
                            Policlinic_Name = clinic,
                            Policlinic_Place = inspection_Place,
                            Doctor_ID = doctorId1

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


                        int polId = hst.Policlinics.Max(policlinic_ => policlinic_.Policlinic_ID);
                        int doctorId = hst.Doctors.Max(doctor_ => doctor_.Doctor_ID);
                        int hourId = hst.Hours.Max(hour_ => hour_.Hour_ID);
                        int dateId = hst.Dates.Max(date_ => date_.Date_ID);
                        int patientId = hst.Patients.Max(patient_ => patient_.Patient_ID);

                        Meeting meeting = new Meeting
                        {
                            Policlinic_ID = polId,
                            Patient_ID = patientId,
                            Doctor_ID = doctorId,
                            Hour_ID = hourId,
                            Date_ID = dateId
                        };

                        hst.Meetings.Add(meeting);
                        hst.SaveChanges();

                        MessageBox.Show("Added Successfully.");

                        identificationNumber.Text = "";
                        cityComboBox.Text = "";
                        districtComboBox.Text = "";
                        clinicComboBox.Text = "";
                        hospitalComboBox.Text = "";
                        inspectionPlaceComboBox.Text = "";
                        physicianComboBox.Text = "";
                        appointmentTimeComboBox.Text = "";
                        appointmentDateTimePicker.Text = "";

                        dataGridViewRefresh();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error : " + error);
                    }
                }
                else
                {
                    MessageBox.Show("There is no such identity in the system.");
                }
            }
        }
        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {
            addAppointment();
        }

        private void identificationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addAppointment();
            }
        }

        string city, district, clinic, hospital, inspection_Place, physician, appointmentDate, appointmentTime;

        public void appointmentUpdate()
        {
            if (meetingId.Text == "")
            {
                MessageBox.Show("Type the appointment ID information.");
            }
            else
            {
                if (cityComboBox_.SelectedItem is null || districtComboBox2.SelectedItem is null || clinicComboBox2.SelectedItem is null || hospitalComboBox2.SelectedItem is null || inspectionPlaceComboBox2.SelectedItem is null || physicianComboBox2.SelectedItem is null || appointmentTime2.SelectedItem is null || appointmentDate2.Value.ToString() == "")
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
                    city = cityComboBox_.SelectedItem.ToString();
                    district = districtComboBox2.SelectedItem.ToString();
                    clinic = clinicComboBox2.SelectedItem.ToString();
                    hospital = hospitalComboBox2.SelectedItem.ToString();
                    inspection_Place = inspectionPlaceComboBox2.SelectedItem.ToString();
                    physician = physicianComboBox2.SelectedItem.ToString();
                    appointmentDate = appointmentDate2.Text.ToString();
                    appointmentTime = appointmentTime2.SelectedItem.ToString();
                }

                int meetingId = int.Parse(this.meetingId.Text);
                var data = hst.Meetings.FirstOrDefault(meeting => meeting.Meeting_ID == meetingId);
                var trueOrFalse5 = hst.Meetings.Any(meeting => meeting.Meeting_ID == meetingId);

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
                        this.meetingId.Text = "";
                        districtComboBox2.Text = "";
                        clinicComboBox2.Text = "";
                        hospitalComboBox2.Text = "";
                        inspectionPlaceComboBox2.Text = "";
                        physicianComboBox2.Text = "";
                        appointmentDate2.Text = "";
                        appointmentTime2.Text = "";

                        dataGridViewRefresh();

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error Occurred While Updating: " + error);
                    }
                }
                else
                {
                    MessageBox.Show("There is no such ID in the system.");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            appointmentUpdate();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                appointmentUpdate();
            }
        }

        public void memberDelete()
        {
            if (memberNumber.Text == "")
            {
                MessageBox.Show("Do not leave the field blank.");
            }
            else
            {
                int id__ = int.Parse(memberNumber.Text);
                var trueOrFalse4 = hst.Members.Any(member => member.Member_No == id__);
                if (trueOrFalse4)
                {
                    try
                    {
                        int id = int.Parse(memberNumber.Text);
                        var findMember = hst.Members.Find(id);

                        hst.Members.Remove(findMember);
                        hst.SaveChanges();

                        MessageBox.Show("Member Successfully Deleted.");
                        memberNumber.Text = "";

                        dataGridView2.DataSource = hst.Members.ToList();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error Occurred While Deleting Member. : " + error);
                    }
                }
                else
                {
                    MessageBox.Show("There Is No Such Number.");
                }
            }
        }

        private void memberDeleteBtn_Click(object sender, EventArgs e)
        {
            memberDelete();
        }
        private void memberNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                memberDelete();
            }
        }

        public void appointmentDelete()
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

                        dataGridViewRefresh();

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

        private void appointmentDeleteBtn_Click(object sender, EventArgs e)
        {
            appointmentDelete();
        }
        private void appointmentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                appointmentDelete();
            }
        }

        private void lisDoctorChartBtn_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = hst.Doctors.ToList();
        }

        private void listOutpatientTable_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = hst.Policlinics.ToList();
        }

        private void listAppointmentTable_Click(object sender, EventArgs e)
        {
            var query = from meeting_ in hst.Meetings
                        join policlinic_ in hst.Policlinics on meeting_.Policlinic_ID equals policlinic_.Policlinic_ID
                        join doctor_ in hst.Doctors on meeting_.Doctor_ID equals doctor_.Doctor_ID
                        join patient_ in hst.Patients on meeting_.Patient_ID equals patient_.Patient_ID
                        join hour_ in hst.Hours on meeting_.Hour_ID equals hour_.Hour_ID
                        join date_ in hst.Dates on meeting_.Date_ID equals date_.Date_ID

                        select new
                        {
                            meeting_.Meeting_ID,
                            patient_.Patient_ID,
                            policlinic_.Policlinic_City,
                            policlinic_.Policlinic_District,
                            policlinic_.Policlinic_Name,
                            policlinic_.Policlinic_Hospital,
                            policlinic_.Policlinic_Place,
                            doctor_.Doctor_Name,
                            date_.Appointment_Date,
                            hour_.Appointment_Time
                        };

            dataGridView4.DataSource = query.ToList();
        }

        private void listPatientChart_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = hst.Patients.ToList();
        }

        private void listDateTable_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = hst.Dates.ToList();
        }

        private void listHoursChart_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = hst.Hours.ToList();
        }

        private void listMembersTable_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = hst.Members.ToList();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            meetingId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            memberNumber.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            appointmentId.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView11_Click(object sender, EventArgs e)
        {
            searchWord.Text = dataGridView11.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView7_Click(object sender, EventArgs e)
        {
            searchWord.Text = dataGridView7.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView10_Click(object sender, EventArgs e)
        {
            searchWord.Text = dataGridView10.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView9_Click(object sender, EventArgs e)
        {
            searchWord.Text = dataGridView9.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView8_Click(object sender, EventArgs e)
        {
            searchWord.Text = dataGridView8.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView6_Click(object sender, EventArgs e)
        {
            searchWord.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void searchMember_Click(object sender, EventArgs e)
        {
            if (searchWord.Text == "")
            {
                MessageBox.Show("Do not leave the field blank.");
            }
            else
            {
                dataGridView5.DataSource = hst.Members.Where(member => member.Member_Name == searchWord.Text).ToList();
                searchWord.Text = "";
            }
        }
        private void searchDoctor_Click(object sender, EventArgs e)
        {
            if (searchWord.Text == "")
            {
                MessageBox.Show("Do not leave the field blank.");
            }
            else
            {
                dataGridView5.DataSource = hst.Doctors.Where(doctor => doctor.Doctor_Name == searchWord.Text).ToList();
                searchWord.Text = "";
            }
        }
        private void searchPoliclinic_Click(object sender, EventArgs e)
        {
            if (searchWord.Text == "")
            {
                MessageBox.Show("Do not leave the field blank.");
            }
            else
            {
                dataGridView5.DataSource = hst.Policlinics.Where(policlinic => policlinic.Policlinic_Name == searchWord.Text).ToList();
                searchWord.Text = "";
            }
        }

        private void searchDate_Click(object sender, EventArgs e)
        {
            if (searchWord.Text == "")
            {
                MessageBox.Show("Do not leave the field blank.");
            }
            else
            {
                dataGridView5.DataSource = hst.Dates.Where(date => date.Appointment_Date == searchWord.Text).ToList();
                searchWord.Text = "";
            }
        }

        private void searchHour_Click(object sender, EventArgs e)
        {
            if (searchWord.Text == "")
            {
                MessageBox.Show("Do not leave the field blank.");
            }
            else
            {
                dataGridView5.DataSource = hst.Hours.Where(hour => hour.Appointment_Time == searchWord.Text).ToList();
                searchWord.Text = "";
            }
        }

        private void searchPatient_Click(object sender, EventArgs e)
        {
            if (searchWord.Text == "")
            {
                MessageBox.Show("Do not leave the field blank.");
            }
            else
            {
                dataGridView5.DataSource = hst.Patients.Where(patient => patient.Patient_Name == searchWord.Text).ToList();
                searchWord.Text = "";
            }
        }

    }
}
