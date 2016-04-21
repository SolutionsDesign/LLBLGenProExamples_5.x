namespace SD.LLBLGen.Pro.Examples.Auditing.GUI
{
    partial class Login
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
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUser1 = new System.Windows.Forms.Label();
			this.lblUser2 = new System.Windows.Forms.Label();
			this.lblUser3 = new System.Windows.Forms.Label();
			this.lblPwd3 = new System.Windows.Forms.Label();
			this.lblPwd2 = new System.Windows.Forms.Label();
			this.lblPwd1 = new System.Windows.Forms.Label();
			this.lblLoginValidation = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gpbLogin = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.gpbLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUserID
			// 
			this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserID.Location = new System.Drawing.Point(105, 20);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(170, 20);
			this.txtUserID.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(105, 47);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(170, 20);
			this.txtPassword.TabIndex = 1;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(105, 73);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(59, 26);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(37, 13);
			this.lblUser.TabIndex = 3;
			this.lblUser.Text = "User:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(35, 47);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(65, 13);
			this.lblPassword.TabIndex = 4;
			this.lblPassword.Text = "Password:";
			// 
			// lblUser1
			// 
			this.lblUser1.AutoSize = true;
			this.lblUser1.Location = new System.Drawing.Point(20, 23);
			this.lblUser1.Name = "lblUser1";
			this.lblUser1.Size = new System.Drawing.Size(64, 13);
			this.lblUser1.TabIndex = 6;
			this.lblUser1.Text = "User: jbaker";
			// 
			// lblUser2
			// 
			this.lblUser2.AutoSize = true;
			this.lblUser2.Location = new System.Drawing.Point(20, 43);
			this.lblUser2.Name = "lblUser2";
			this.lblUser2.Size = new System.Drawing.Size(66, 13);
			this.lblUser2.TabIndex = 7;
			this.lblUser2.Text = "User: efisher";
			// 
			// lblUser3
			// 
			this.lblUser3.AutoSize = true;
			this.lblUser3.Location = new System.Drawing.Point(20, 60);
			this.lblUser3.Name = "lblUser3";
			this.lblUser3.Size = new System.Drawing.Size(74, 13);
			this.lblUser3.TabIndex = 8;
			this.lblUser3.Text = "User: lcowboy";
			// 
			// lblPwd3
			// 
			this.lblPwd3.AutoSize = true;
			this.lblPwd3.Location = new System.Drawing.Point(106, 60);
			this.lblPwd3.Name = "lblPwd3";
			this.lblPwd3.Size = new System.Drawing.Size(73, 13);
			this.lblPwd3.TabIndex = 11;
			this.lblPwd3.Text = "Pwd: lcowboy";
			// 
			// lblPwd2
			// 
			this.lblPwd2.AutoSize = true;
			this.lblPwd2.Location = new System.Drawing.Point(106, 43);
			this.lblPwd2.Name = "lblPwd2";
			this.lblPwd2.Size = new System.Drawing.Size(65, 13);
			this.lblPwd2.TabIndex = 10;
			this.lblPwd2.Text = "Pwd: efisher";
			// 
			// lblPwd1
			// 
			this.lblPwd1.AutoSize = true;
			this.lblPwd1.Location = new System.Drawing.Point(106, 23);
			this.lblPwd1.Name = "lblPwd1";
			this.lblPwd1.Size = new System.Drawing.Size(63, 13);
			this.lblPwd1.TabIndex = 9;
			this.lblPwd1.Text = "Pwd: jbaker";
			// 
			// lblLoginValidation
			// 
			this.lblLoginValidation.AutoSize = true;
			this.lblLoginValidation.ForeColor = System.Drawing.Color.Red;
			this.lblLoginValidation.Location = new System.Drawing.Point(191, 76);
			this.lblLoginValidation.Name = "lblLoginValidation";
			this.lblLoginValidation.Size = new System.Drawing.Size(155, 13);
			this.lblLoginValidation.TabIndex = 12;
			this.lblLoginValidation.Text = "Incorrect login information";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblUser1);
			this.groupBox1.Controls.Add(this.lblUser2);
			this.groupBox1.Controls.Add(this.lblPwd3);
			this.groupBox1.Controls.Add(this.lblUser3);
			this.groupBox1.Controls.Add(this.lblPwd2);
			this.groupBox1.Controls.Add(this.lblPwd1);
			this.groupBox1.Location = new System.Drawing.Point(98, 171);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(204, 90);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// gpbLogin
			// 
			this.gpbLogin.Controls.Add(this.lblLoginValidation);
			this.gpbLogin.Controls.Add(this.lblPassword);
			this.gpbLogin.Controls.Add(this.lblUser);
			this.gpbLogin.Controls.Add(this.btnLogin);
			this.gpbLogin.Controls.Add(this.txtPassword);
			this.gpbLogin.Controls.Add(this.txtUserID);
			this.gpbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbLogin.Location = new System.Drawing.Point(27, 26);
			this.gpbLogin.Name = "gpbLogin";
			this.gpbLogin.Size = new System.Drawing.Size(364, 130);
			this.gpbLogin.TabIndex = 14;
			this.gpbLogin.TabStop = false;
			this.gpbLogin.Text = "Please login";
			// 
			// Login
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 277);
			this.Controls.Add(this.gpbLogin);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LLBLGenPro Auditing Example - Login";
			this.TopMost = true;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gpbLogin.ResumeLayout(false);
			this.gpbLogin.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label lblUser2;
        private System.Windows.Forms.Label lblUser3;
        private System.Windows.Forms.Label lblPwd3;
        private System.Windows.Forms.Label lblPwd2;
        private System.Windows.Forms.Label lblPwd1;
        private System.Windows.Forms.Label lblLoginValidation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbLogin;
    }
}

