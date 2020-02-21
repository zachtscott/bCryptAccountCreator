namespace UserLoginUserInterface
{
    partial class FrmCreateAccount
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbAccountCreationStatus = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(110, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(154, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(110, 176);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(154, 20);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(110, 130);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(154, 20);
            this.txtPassword2.TabIndex = 2;
            this.txtPassword2.TextChanged += new System.EventHandler(this.TxtPassword2_TextChanged);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(110, 83);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(154, 20);
            this.txtPassword1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Re-enter Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email Address:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(332, 41);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(135, 36);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(336, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 40);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit Form";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pbAccountCreationStatus
            // 
            this.pbAccountCreationStatus.Location = new System.Drawing.Point(4, 218);
            this.pbAccountCreationStatus.Name = "pbAccountCreationStatus";
            this.pbAccountCreationStatus.Size = new System.Drawing.Size(119, 20);
            this.pbAccountCreationStatus.TabIndex = 10;
            // 
            // FrmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 237);
            this.Controls.Add(this.pbAccountCreationStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtUserName);
            this.Name = "FrmCreateAccount";
            this.Text = "Account Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar pbAccountCreationStatus;
    }
}

