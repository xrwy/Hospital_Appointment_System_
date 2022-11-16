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
    public partial class AuthorizedLogin : Form
    {
        public AuthorizedLogin()
        {
            InitializeComponent();

        }

        HospitalEntities hospitalEntities = new HospitalEntities();
        int trialRight = 3;

        public void keyPressEvent()
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Do not leave the fields blank.");
            }
            else
            {
                bool isValid = hospitalEntities.Authorities.Any(authorized => authorized.Authorized_Password == password.Text && authorized.Authorized_Name == username.Text);
                if (isValid)
                {
                    AuthorizedPanel authorizedPanel = new AuthorizedPanel();
                    this.Hide();
                    authorizedPanel.ShowDialog();
                }
                else
                {
                    trialRight--;
                    if (trialRight == 0)
                    {
                        MessageBox.Show("Unauthorized Trial.");
                        username.Enabled = false;
                        password.Enabled = false;
                        loginBtn.Enabled = false;
                        label3.Text = "";
                        username.Text = "";
                        password.Text = "";
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
        private void username_KeyPress(object sender, KeyPressEventArgs e)
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
        private void returnToTheLoginScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginPage = new Form1();
            loginPage.Show();
        }
    }
}
