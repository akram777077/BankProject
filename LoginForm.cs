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
        public FormUserLogin()
        {
            InitializeComponent();
        }
        private void checkTextBoxEmpty(object sender, CancelEventArgs e,int numberChar,string message)
        {
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
    }
}
