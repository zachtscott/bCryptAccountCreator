using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginUserInterface
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmCreateAccount createAccount = new FrmCreateAccount();
        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();

        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            createAccount.Show();

        }


    }
}
