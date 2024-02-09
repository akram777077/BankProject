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
    public partial class FormUserLogin : Form
    {
        private byte countErrorLogIn=3;
        public FormUserLogin()
        {
            InitializeComponent();
        }
        ~FormUserLogin()
        {
            this.Close();
        }
        bool start = true;
        private void checkTextBoxEmpty(object sender, CancelEventArgs e,int numberChar,string message)
        {
            if (start)
                return;
            if(((TextBox)sender).Text.Length<=numberChar)
            {
                e.Cancel = true;
                epRed.SetError((TextBox)sender, message);
            }
            else
            {
                e.Cancel = false;
                epRed.SetError((TextBox)sender, "");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            checkTextBoxEmpty(sender, e,8,"password is in [8,16]");
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            checkTextBoxEmpty(sender, e, 0, "Non empty");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isValidUser(string username,string password)
        {
            User current = Globale.listUsers.getUserUserName(username);
            if (current != null && current.Password == password)
            {
                Globale.currentUser = current;
                return true;
            }
            return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!isValidUser(tbUserName.Text, tbPassword.Text))
            {
                epRed.SetError(btnLogin, "your password or user name is false ( " + (countErrorLogIn - 1).ToString() + " chance)");
                countErrorLogIn--;
                if (countErrorLogIn == 0)
                    this.Close();
                return;
            }
            Form main = new userMainForm();
            this.Hide();
            main.ShowDialog();
            this.Show();
            FormUserLogin_Load(sender, e);
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {
            tbPassword.Clear();
            start = true;
            tbUserName.Clear();
            start = true;
            tbUserName.Focus();
            btnLogin.Enabled = false;
            tbUserName.Tag = "false";
            tbPassword.Tag = "false";
            epRed.SetError(btnLogin, "");
            countErrorLogIn = 3;

        }
        private void makeLoginPossible()
        {
            if (Convert.ToBoolean(tbUserName.Tag) && Convert.ToBoolean(tbPassword.Tag))
                btnLogin.Enabled = true;
        }
        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            tbUserName.Tag = "true";
            start = false;
            makeLoginPossible();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.Tag = "true";
            start = false;
            makeLoginPossible();
        }

    }
}
