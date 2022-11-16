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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HospitalEntities hospitalEntities = new HospitalEntities();

        int trialRight = 3;

        public void keyPressEvent()
        {
            if (identificationNumber.Text == "" || password.Text == "")
            {
                MessageBox.Show("Do not leave the fields blank.");
            }
            else if (identificationNumber.Text.Length <= 11 && password.Text.Length <= 8)
            {
                bool isValid = hospitalEntities.Members.Any(info => info.Member_Password == password.Text && info.Member_Identity == identificationNumber.Text);
                var data_ = hospitalEntities.Members.AsNoTracking().FirstOrDefault(info => info.Member_Identity == identificationNumber.Text);

                if (isValid)
                {
                    MakeAnAppointment makeAnAppointment = new MakeAnAppointment();
                    this.Hide();
                    makeAnAppointment.getInfo(identificationNumber.Text);
                    trialRight = 0;
                    makeAnAppointment.ShowDialog();
                }
                else
                {
                    trialRight--;
                    if (trialRight == 0)
                    {
                        MessageBox.Show("Unauthorized Trial.");
                        identificationNumber.Enabled = false;
                        password.Enabled = false;
                        loginBtn.Enabled = false;
                        label3.Text = "";
                        identificationNumber.Text = "";
                        password.Text = "";
                        trialRight = 3;
                    }
                    else
                    {
                        label3.Text = "You Have " + trialRight.ToString() + " Rights Left";
                    }
                }
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            keyPressEvent();
        }
        private void signBtn_Click_1(object sender, EventArgs e)
        {
            identificationNumber.Enabled = true;
            password.Enabled = true;
            loginBtn.Enabled = true;
            trialRight = 3;
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
        }
        private void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            identificationNumber.Enabled = true;
            password.Enabled = true;
            loginBtn.Enabled = true;
            ResetPassword resetPassword_ = new ResetPassword();
            this.Hide();
            resetPassword_.ShowDialog();
        }
        private void authorizedLoginBtn_Click(object sender, EventArgs e)
        {
            trialRight = 3;
            this.Hide();
            AuthorizedLogin authorizedLogin = new AuthorizedLogin();
            authorizedLogin.ShowDialog();
        }
        private void identificationNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                password.PasswordChar = default(char);
            }
            else
            {
                password.PasswordChar = '*';
            }
        }
    }
}
