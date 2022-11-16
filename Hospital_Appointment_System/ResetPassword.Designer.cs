namespace Hospital_Appointment_System
{
    partial class ResetPassword
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
            this.showPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.newPasswordAgain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.identificationNumber = new System.Windows.Forms.TextBox();
            this.resetPasswordBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showPasswordCheckbox
            // 
            this.showPasswordCheckbox.AutoSize = true;
            this.showPasswordCheckbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showPasswordCheckbox.Location = new System.Drawing.Point(656, 160);
            this.showPasswordCheckbox.Name = "showPasswordCheckbox";
            this.showPasswordCheckbox.Size = new System.Drawing.Size(170, 29);
            this.showPasswordCheckbox.TabIndex = 41;
            this.showPasswordCheckbox.Text = "Show Password";
            this.showPasswordCheckbox.UseVisualStyleBackColor = true;
            this.showPasswordCheckbox.CheckedChanged += new System.EventHandler(this.showPasswordCheckbox_CheckedChanged);
            // 
            // newPasswordAgain
            // 
            this.newPasswordAgain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newPasswordAgain.Location = new System.Drawing.Point(354, 209);
            this.newPasswordAgain.MaxLength = 25;
            this.newPasswordAgain.Name = "newPasswordAgain";
            this.newPasswordAgain.PasswordChar = '*';
            this.newPasswordAgain.Size = new System.Drawing.Size(249, 33);
            this.newPasswordAgain.TabIndex = 40;
            this.newPasswordAgain.TextChanged += new System.EventHandler(this.newPasswordAgain_TextChanged);
            this.newPasswordAgain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newPasswordAgain_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(138, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "New Password Again";
            // 
            // newPassword
            // 
            this.newPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newPassword.Location = new System.Drawing.Point(354, 158);
            this.newPassword.MaxLength = 25;
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(249, 33);
            this.newPassword.TabIndex = 38;
            this.newPassword.TextChanged += new System.EventHandler(this.newPassword_TextChanged);
            this.newPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newPassword_KeyPress);
            // 
            // identificationNumber
            // 
            this.identificationNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.identificationNumber.Location = new System.Drawing.Point(354, 110);
            this.identificationNumber.MaxLength = 11;
            this.identificationNumber.Name = "identificationNumber";
            this.identificationNumber.Size = new System.Drawing.Size(249, 33);
            this.identificationNumber.TabIndex = 37;
            this.identificationNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.identificationNumber_KeyPress);
            // 
            // resetPasswordBtn
            // 
            this.resetPasswordBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.resetPasswordBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetPasswordBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.resetPasswordBtn.Location = new System.Drawing.Point(383, 259);
            this.resetPasswordBtn.Name = "resetPasswordBtn";
            this.resetPasswordBtn.Size = new System.Drawing.Size(190, 44);
            this.resetPasswordBtn.TabIndex = 36;
            this.resetPasswordBtn.Text = "Reset Password";
            this.resetPasswordBtn.UseVisualStyleBackColor = false;
            this.resetPasswordBtn.Click += new System.EventHandler(this.resetPasswordBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(138, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(138, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Identification Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(389, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 42;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 428);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showPasswordCheckbox);
            this.Controls.Add(this.newPasswordAgain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.identificationNumber);
            this.Controls.Add(this.resetPasswordBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox showPasswordCheckbox;
        private System.Windows.Forms.TextBox newPasswordAgain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox identificationNumber;
        private System.Windows.Forms.Button resetPasswordBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}