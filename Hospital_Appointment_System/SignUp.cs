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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        HospitalEntities hospitalEntities = new HospitalEntities();

        string gender;
        public bool match1;
        public bool match2;

        private void keyPressEvent()
        {
            if (genderComboBox.SelectedItem is null || genderComboBox.SelectedItem.ToString() == "")
            {
                gender = "";
            }

            if (identificationNumber.Text == "" || name.Text == "" || lastname.Text == "" || password.Text == "" || againPassword.Text == "" || gender == "" || dateOfBirthDateTimePicker.Text is null)
            {
                MessageBox.Show("Do not leave the fields blank.");
            }
            else
            {
                bool isValid = hospitalEntities.Members.Any(member => member.Member_Identity == identificationNumber.Text);
                if (isValid)
                {
                    MessageBox.Show("There is a person belonging to this Identity.");
                }
                else
                {

                    if (match1 && match2)
                    {
                        try
                        {
                            string gender_ = genderComboBox.SelectedItem.ToString();
                            string dateOfBirth = dateOfBirthDateTimePicker.Text.ToString();

                            Member member = new Member
                            {
                                Member_Identity = identificationNumber.Text,
                                Member_Name = name.Text,
                                Member_Lastname = lastname.Text,
                                Member_Gender = gender_,
                                Member_Date_of_birth = dateOfBirth,
                                Member_Password = password.Text
                            };

                            hospitalEntities.Members.Add(member);
                            hospitalEntities.SaveChanges();

                            MessageBox.Show("You Have Successfully Registered");
                            Form1 form1 = new Form1();
                            this.Hide();
                            form1.Show();

                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Problem Occurred While Registering : " + error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Match the Passwords.");
                    }
                }
            }
        }
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            keyPressEvent();
        }
        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckbox.Checked == true)
            {
                password.PasswordChar = default(char);
            }
            else
            {
                password.PasswordChar = '*';
            }
        }
        private void againPassword_TextChanged(object sender, EventArgs e)
        {
            if (password.Text == againPassword.Text)
            {
                label8.Text = "Password Matched.";
                match1 = true;
                match2 = true;
            }
            else
            {
                label8.Text = "Password Not Matched.Enter the password correctly.";
                match1 = false;
                match2 = false;
            }
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                label8.Text = "";
            }
        }
        private void identificationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                keyPressEvent();
            }
        }
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                keyPressEvent();
            }
        }
        private void lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                keyPressEvent();
            }
        }
        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                keyPressEvent();
            }
        }
        private void againPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                keyPressEvent();
            }
        }
    }
}
