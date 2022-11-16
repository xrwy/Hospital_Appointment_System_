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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        HospitalEntities hospitalEntities = new HospitalEntities();
        bool match1;
        bool match2;

        public void keyPressEvent()
        {
            if (identificationNumber.Text == "" || newPassword.Text == "" || newPasswordAgain.Text == "")
            {
                MessageBox.Show("Do not leave the fields blank.");
            }
            else
            {
                bool isValid = hospitalEntities.Members.Any(member => member.Member_Identity == identificationNumber.Text);
                if (isValid)
                {
                    if (match1 && match2)
                    {
                        try
                        {
                            var data = hospitalEntities.Members.FirstOrDefault(member => member.Member_Identity == identificationNumber.Text);
                            string identity = identificationNumber.Text.ToString();
                            var toBeUpdated = hospitalEntities.Members.Find(data.Member_No);
                            toBeUpdated.Member_Password = newPassword.Text.ToString();

                            hospitalEntities.SaveChanges();

                            MessageBox.Show("Password Updated Successfully.");
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.Show();

                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("An Error Occurred While Updating Password : " + error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Match the Password.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct Identity.");
                    identificationNumber.Focus();
                }
            }
        }

        private void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            keyPressEvent();
        }
        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckbox.Checked == true)
            {
                newPassword.PasswordChar = default(char);
            }
            else
            {
                newPassword.PasswordChar = '*';
            }
        }
        private void newPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            if (newPassword.Text == newPasswordAgain.Text)
            {
                label4.Text = "Password Matched";
                match1 = true;
                match2 = true;
            }
            else
            {
                label4.Text = "Password Not Matched. Enter the password correctly.";
                match1 = false;
                match2 = false;
            }
        }
        private void newPassword_TextChanged(object sender, EventArgs e)
        {
            if (newPassword.Text == "")
            {
                label4.Text = "";
            }
        }
        private void identificationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                keyPressEvent();
            }
        }
        private void newPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                keyPressEvent();
            }
        }
        private void newPasswordAgain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                keyPressEvent();
            }
        }
    }
}
