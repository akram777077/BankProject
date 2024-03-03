using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    public partial class userMainForm : Form
    {
        public userMainForm()
        {
            InitializeComponent();
        }
        private bool keep = true;
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Globale.currentUser.UserName + " are you sure for logout ?", Globale.currentUser.UserName + " logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                return;
            this.Hide();
        }

        private void btnClientMang_Click(object sender, EventArgs e)
        {
            Form clientM = new clientMangmentForm();
            this.Hide();
            clientM.ShowDialog();
            this.Show();
        }

        private void btnUsersMangment_Click(object sender, EventArgs e)
        {
            Form userM = new userMangmentForm();
            this.Hide();
            userM.ShowDialog();
            this.Show();

        }

        private void btnLogLogin_Click(object sender, EventArgs e)
        {

        }

        private void userMainForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = lblUser.Text + Globale.currentUser.UserName;
        }
    }
}
