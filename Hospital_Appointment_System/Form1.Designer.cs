namespace Hospital_Appointment_System
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.resetPasswordBtn = new System.Windows.Forms.Button();
            this.authorizedLoginBtn = new System.Windows.Forms.Button();
            this.signBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.identificationNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(574, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 19;
            // 
            // resetPasswordBtn
            // 
            this.resetPasswordBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.resetPasswordBtn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetPasswordBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.resetPasswordBtn.Location = new System.Drawing.Point(390, 318);
            this.resetPasswordBtn.Name = "resetPasswordBtn";
            this.resetPasswordBtn.Size = new System.Drawing.Size(194, 44);
            this.resetPasswordBtn.TabIndex = 18;
            this.resetPasswordBtn.Text = "I Forgot My Password";
            this.resetPasswordBtn.UseVisualStyleBackColor = false;
            this.resetPasswordBtn.Click += new System.EventHandler(this.resetPasswordBtn_Click);
            // 
            // authorizedLoginBtn
            // 
            this.authorizedLoginBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.authorizedLoginBtn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authorizedLoginBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.authorizedLoginBtn.Location = new System.Drawing.Point(697, 400);
            this.authorizedLoginBtn.Name = "authorizedLoginBtn";
            this.authorizedLoginBtn.Size = new System.Drawing.Size(176, 44);
            this.authorizedLoginBtn.TabIndex = 17;
            this.authorizedLoginBtn.Text = "Authorized Login";
            this.authorizedLoginBtn.UseVisualStyleBackColor = false;
            this.authorizedLoginBtn.Click += new System.EventHandler(this.authorizedLoginBtn_Click);
            // 
            // signBtn
            // 
            this.signBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.signBtn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.signBtn.Location = new System.Drawing.Point(433, 262);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(102, 40);
            this.signBtn.TabIndex = 16;
            this.signBtn.Text = "Sign Up";
            this.signBtn.UseVisualStyleBackColor = false;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click_1);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loginBtn.Location = new System.Drawing.Point(433, 216);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(102, 40);
            this.loginBtn.TabIndex = 15;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.Location = new System.Drawing.Point(367, 169);
            this.password.MaxLength = 30;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(244, 30);
            this.password.TabIndex = 14;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // identificationNumber
            // 
            this.identificationNumber.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.identificationNumber.Location = new System.Drawing.Point(367, 124);
            this.identificationNumber.MaxLength = 11;
            this.identificationNumber.Name = "identificationNumber";
            this.identificationNumber.Size = new System.Drawing.Size(244, 30);
            this.identificationNumber.TabIndex = 13;
            this.identificationNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.identificationNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(172, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Identification Number";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showPasswordCheckBox.Location = new System.Drawing.Point(661, 147);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(170, 29);
            this.showPasswordCheckBox.TabIndex = 20;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 490);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resetPasswordBtn);
            this.Controls.Add(this.authorizedLoginBtn);
            this.Controls.Add(this.signBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.identificationNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetPasswordBtn;
        private System.Windows.Forms.Button authorizedLoginBtn;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox identificationNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
    }
}

