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
    public partial class userMangmentForm : Form
    {
        private const string Value = "ID is in 8 degits";
        private const string Value1 = "phone in 10 degits";

        public userMangmentForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }
        User getUserWithInfromation()
        {
            User user = new User();
            user.Id = txtId.Text;
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.Email = txtEmail.Text;
            user.Phone = txtPhone.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            DateTime.TryParse(dtDateOfBirth.Text, out DateTime dtBirth);
            user.DateOfBirth = dtBirth;
            return user;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you for adding " + txtUserName.Text + " on the system ?", "validation", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            Globale.listUsers.addUser(getUserWithInfromation());
            userMangmentForm_Load(sender, e);


        }

        private void crProgress_Click(object sender, EventArgs e)
        {

        }

        private void txtId_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private int ProgressOfUnit(TextBox a,int value)
        {
            if (a.Tag.ToString() == "true")
                return value;
            return 0;
        }
        private int progressTotal()
        {
            int t = 0;
            t += ProgressOfUnit(txtId, 10);
            t += ProgressOfUnit(txtUserName, 20);
            t += ProgressOfUnit(txtPassword, 20);
            t += ProgressOfUnit(txtPhone, 10);
            t += ProgressOfUnit(txtEmail, 10);
            t += ProgressOfUnit(txtAddress, 10);
            t += ProgressOfUnit(txtFirstName, 10);
            t += ProgressOfUnit(txtLastName, 10) ;
            return t;
        }
        private void addProgress()
        {
            crProgress.Value =progressTotal();
            crProgress.Text = crProgress.Value.ToString() + "%";
            button1.Enabled = (crProgress.Value == 100)?true:false;
        }
        private void userMangmentForm_Load(object sender, EventArgs e)
        {

            crProgress.Value = 0;
            button1.Enabled = false;
            dtDateOfBirth.Value = DateTime.Now;
            txtId.Clear();
            ErrrEmpty.SetError(txtId, "");
            txtUserName.Clear();
            ErrrEmpty.SetError(txtUserName, "");
            txtPassword.Clear();
            ErrrEmpty.SetError(txtPassword, "");
            txtPhone.Clear();
            ErrrEmpty.SetError(txtPhone, "");
            txtEmail.Clear();
            ErrrEmpty.SetError(txtEmail, "");
            txtAddress.Clear();
            ErrrEmpty.SetError(txtAddress, "");
            txtFirstName.Clear();
            ErrrEmpty.SetError(txtFirstName, "");
            txtLastName.Clear();
            ErrrEmpty.SetError(txtLastName, "");
            DesableFindUser();
            
        }
        private void DesableFindUser()
        {
            txtFindAddress.Enabled = false;
            txtFindFirstName.Enabled = false;
            txtFindLastName.Enabled = false;
            txtFindEmail.Enabled = false;
            txtFindID.Enabled = false;
            txtFindUserName.Enabled = false;
            txtFindPassword.Enabled = false;
            txtFindPhone.Enabled = false;
            dtFindDateOfBirth.Enabled = false;
        }
        private bool valideID(string id)
        {
            UInt64 test = 0;
            try
            {
                test=Convert.ToUInt64(id);
                return true;
            }
            catch
            { 
                return false;
            }
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Length == 0)
            {
                ErrrEmpty.SetError(txtId, "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else if(!valideID(txtId.Text.ToString()))
            {
                ErrrEmpty.SetError(txtId, "Enter Numeric Value");
                ((TextBox)sender).Tag = "false";
            }
            else if(txtId.Text.Length!=8)
            {
                ErrrEmpty.SetError(txtId, Value);
                ((TextBox)sender).Tag = "false";
            }
            else if(Globale.listUsers.getUserID(txtId.Text.ToString()) != null)
            {
                ErrrEmpty.SetError(txtId, "This user is in the system try other id");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(txtId, "");
                ((TextBox)sender).Tag = "true";
            }
            addProgress();

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                ErrrEmpty.SetError(txtUserName, "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else if (Globale.listUsers.getUserUserName(txtUserName.Text.ToString()) != null)
            {
                ErrrEmpty.SetError(txtUserName, "This user is in the system try other id");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(txtUserName, "");
                ((TextBox)sender).Tag = "true";
            }
            addProgress();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                ErrrEmpty.SetError(txtPassword, "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else if(txtPassword.Text.Length > 16 || txtPassword.Text.Length <8)
            {
                ErrrEmpty.SetError(txtPassword, "password in range [8,16]");
                ((TextBox)sender).Tag = "false";

            }
            else
            {
                ErrrEmpty.SetError(txtPassword, "");
                ((TextBox)sender).Tag = "true";
            }
            addProgress();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length == 0)
            {
                ErrrEmpty.SetError(txtEmail, "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(txtEmail, "");
                ((TextBox)sender).Tag = "true";
            }
            addProgress();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length == 0)
            {
                ErrrEmpty.SetError(txtAddress, "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(txtAddress, "");
                ((TextBox)sender).Tag = "true";
            }
            addProgress();
        }
        private bool testPhone(string phone)
        {
            int number = 0;
            try
            {
                number = Convert.ToInt32(phone);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length == 0)
            {
                ErrrEmpty.SetError(txtPhone, "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else if(!testPhone(txtPhone.Text.ToString()))
            {
                ErrrEmpty.SetError(txtPhone, "non char input..");
                ((TextBox)sender).Tag = "false";
            }
            else if(txtPhone.Text.Length != 10)
            {
                ErrrEmpty.SetError(txtPhone, Value1);
                ((TextBox)sender).Tag = "false";
            }
            else if(txtPhone.Text[0] !='0' || (txtPhone.Text[1] != '7' && txtPhone.Text[1] != '5' && txtPhone.Text[1] != '6'))
            {
                ErrrEmpty.SetError(txtPhone, "phone is wrong");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(txtPhone, "");
                ((TextBox)sender).Tag = "true";
            }
            addProgress();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length == 0)
            {
                ErrrEmpty.SetError(txtFirstName, "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(txtFirstName, "");
                ((TextBox)sender).Tag = "true";
            }
            addProgress();

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length == 0)
            {
                ErrrEmpty.SetError(txtLastName, "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(txtLastName, "");
                ((TextBox)sender).Tag = "true";
            }
            addProgress();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        void fillTheTextBoxWithUser(User target)
        {
            txtFindAddress.Text = target.Address;
            txtFindFirstName.Text = target.FirstName;
            txtFindLastName.Text= target.LastName;
            txtFindEmail.Text = target.Email;
            txtFindID.Text = target.Id;
            txtFindUserName.Text = target.UserName;
            txtFindPassword.Text = target.Password;
            txtFindPhone.Text = target.Phone;
            dtFindDateOfBirth.Text = target.DateOfBirth.ToString();
            progressTotalFind.Text = "100%";
            progressTotalFind.Value = 100;
        }
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if(txtSearchById.Text.Length == 0 && txtSearchByUserName.Text.Length == 0)
            {
                return;
            }
            else
            {
                User target = Globale.listUsers.getUserID(txtSearchById.Text);
                fillTheTextBoxWithUser(target);
            }
        }
    }
}
