using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevOne;
using PInvoke;
using BusinessClassLibrary;

namespace UserLoginUserInterface
{
    public partial class FrmCreateAccount : Form
    {
        public FrmCreateAccount()
        {
            InitializeComponent();
        }
       CreateAccount createAccount = new CreateAccount();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
           
        }
        public bool userClickedOkOnAccCreatedMessageBox;

        private void TxtPassword2_TextChanged(object sender, EventArgs e)
        {
            SamePassword();
        }

        public bool SamePassword()
        {
            if (txtPassword2.Text != txtPassword1.Text)
            {
                txtPassword2.BackColor = Color.Red;
                return false;
            }
            else if (txtPassword2.Text == txtPassword1.Text)
            {
                txtPassword2.BackColor = Color.Green;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text;
                string password = txtPassword2.Text;
                string emailAddress = txtEmailAddress.Text;

                if (SamePassword())
                {
                    createAccount.CreateAcct(username, password, emailAddress);
                }
                if (createAccount.wasAccountCreated == true)
                {
                    pbAccountCreationStatus.Value = 100;
                    DialogResult accountCreatedMessageBoxResult = MessageBox.Show("Your Account Has Been Created.", "Account Successfully Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (accountCreatedMessageBoxResult == DialogResult.OK)
                    {
                        pbAccountCreationStatus.Value = 0;
                    }
                }
                ResetAccountCreationFormVariables();
            }
            catch(Exception except)
            {
                MessageBox.Show(except.Message, except.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResetAccountCreationFormVariables()
        {
            createAccount.wasAccountCreated = false;
        }
        
    }
}
