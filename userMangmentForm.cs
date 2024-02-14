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
            dtFindDateOfBirth.Value = DateTime.Now;
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
            DesableFindUser(false);
            progressTotalFind.Value = 0;
            rbtnIDSearch.Checked = true;
            txtSearchByUserName.Enabled = false;
            btnEditUser.Enabled = false;
            btnSaveUser.Enabled = false;
            
        }
        private void DesableFindUser(bool option)
        {
            txtFindAddress.Enabled = option;
            txtFindFirstName.Enabled = option;
            txtFindLastName.Enabled = option;
            txtFindEmail.Enabled = option;
            txtFindID.Enabled = option;
            txtFindUserName.Enabled = option;
            txtFindPassword.Enabled = option;
            txtFindPhone.Enabled = option;
            dtFindDateOfBirth.Enabled = option;
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
            bool test= ((TextBox)sender)==txtFindID && txtFindID.Text.Equals(TargetFound.Id);
            if (((TextBox)sender).Text.Length == 0)
            {
                ErrrEmpty.SetError(((TextBox)sender), "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else if(!valideID(((TextBox)sender).Text.ToString()))
            {
                ErrrEmpty.SetError(((TextBox)sender), "Enter Numeric Value");
                ((TextBox)sender).Tag = "false";
            }
            else if(((TextBox)sender).Text.Length!=8)
            {
                ErrrEmpty.SetError(((TextBox)sender), Value);
                ((TextBox)sender).Tag = "false";
            }
            else if(Globale.listUsers.getUserID(((TextBox)sender).Text.ToString()) != null && !test)
            {

                ErrrEmpty.SetError(((TextBox)sender), "This user is in the system try other id");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(((TextBox)sender), "");
                ((TextBox)sender).Tag = "true";
            }
            refrechProgress(sender, txtId);


        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            bool test = ((TextBox)sender) == txtFindUserName && txtFindUserName.Text.Equals(TargetFound.UserName);
            if (((TextBox)sender).Text.Length == 0)
            {
                ErrrEmpty.SetError(((TextBox)sender), "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else if (Globale.listUsers.getUserUserName(((TextBox)sender).Text.ToString()) != null && !test)
            {
                ErrrEmpty.SetError(((TextBox)sender), "This user is in the system try other user");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(((TextBox)sender), "");
                ((TextBox)sender).Tag = "true";
            }
            refrechProgress(sender, txtUserName);

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ErrrEmpty.SetError(((TextBox)sender), "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else if(((TextBox)sender).Text.Length > 16 || ((TextBox)sender).Text.Length <8)
            {
                ErrrEmpty.SetError(((TextBox)sender), "password in range [8,16]");
                ((TextBox)sender).Tag = "false";

            }
            else
            {
                ErrrEmpty.SetError(((TextBox)sender), "");
                ((TextBox)sender).Tag = "true";
            }
            refrechProgress(sender, txtPassword);

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ErrrEmpty.SetError(((TextBox)sender), "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(((TextBox)sender), "");
                ((TextBox)sender).Tag = "true";
            }
            refrechProgress(sender, txtEmail);

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ErrrEmpty.SetError(((TextBox)sender), "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(((TextBox)sender), "");
                ((TextBox)sender).Tag = "true";
            }
            refrechProgress(sender, txtAddress);

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
            if (((TextBox)sender).Text.Length == 0)
            {
                ErrrEmpty.SetError(((TextBox)sender), "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else if(!testPhone(((TextBox)sender).Text.ToString()))
            {
                ErrrEmpty.SetError(((TextBox)sender), "non char input..");
                ((TextBox)sender).Tag = "false";
            }
            else if(((TextBox)sender).Text.Length != 10)
            {
                ErrrEmpty.SetError(((TextBox)sender), Value1);
                ((TextBox)sender).Tag = "false";
            }
            else if(((TextBox)sender).Text[0] !='0' || (((TextBox)sender).Text[1] != '7' && ((TextBox)sender).Text[1] != '5' && ((TextBox)sender).Text[1] != '6'))
            {
                ErrrEmpty.SetError(((TextBox)sender), "phone is wrong");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(((TextBox)sender), "");
                ((TextBox)sender).Tag = "true";
            }
            refrechProgress(sender, txtPhone);

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ErrrEmpty.SetError(((TextBox)sender), "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(((TextBox)sender), "");
                ((TextBox)sender).Tag = "true";
            }
            refrechProgress(sender, txtFirstName);


        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ErrrEmpty.SetError(((TextBox)sender), "non Empty Value");
                ((TextBox)sender).Tag = "false";
            }
            else
            {
                ErrrEmpty.SetError(((TextBox)sender), "");
                ((TextBox)sender).Tag = "true";
            }
            refrechProgress(sender,txtLastName);
        }
        private void refrechProgress(object sender,TextBox target)
        {
            if (((TextBox)sender) == target)
                addProgress();
            else
                calcProgressTotalFind();
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
        private void  calcProgressTotalFind()
        {
            int t = 0;
            t += ProgressOfUnit(txtFindID, 10);
            t += ProgressOfUnit(txtFindUserName, 20);
            t += ProgressOfUnit(txtFindPassword, 20);
            t += ProgressOfUnit(txtFindPhone, 10);
            t += ProgressOfUnit(txtFindEmail, 10);
            t += ProgressOfUnit(txtFindAddress, 10);
            t += ProgressOfUnit(txtFindFirstName, 10);
            t += ProgressOfUnit(txtFindLastName, 10);
            progressTotalFind.Value= t;
            progressTotalFind.Text = t.ToString() + "%";
            btnSaveUser.Enabled = (progressTotalFind.Value == 100 && !btnSearchUser.Enabled);
            
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
            calcProgressTotalFind();
            progressTotalFind.Text = progressTotalFind.Value.ToString()+"%";
        }
        private void clearTexts()
        {
            txtFindAddress.Clear();
            txtFindFirstName.Clear();
            txtFindLastName.Clear();
            txtFindEmail.Clear();
            txtFindID.Clear();
            txtFindUserName.Clear();
            txtFindPassword.Clear();
            txtFindPhone.Clear();
            dtFindDateOfBirth.Value = DateTime.Now;
        }
        private User TargetFound;
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            User target = (rbtnIDSearch.Checked)?Globale.listUsers.getUserID(txtSearchById.Text):Globale.listUsers.getUserUserName(txtSearchByUserName.Text);
            if (target == null)
            {
                ErrrEmpty.SetError(btnSearchUser, "This user is not in the system");
                clearTexts();
                progressTotalFind.Text = "0%";
                progressTotalFind.Value = 0;
            }
            else
            {
                TargetFound = target;
                fillTheTextBoxWithUser(target);
                ErrrEmpty.SetError(btnSearchUser, "");
                btnEditUser.Enabled = true;

            }
        }
        private void NOEmptySomthing(TextBox test)
        {
            if (string.IsNullOrEmpty(test.Text))
                test.Tag = "false";
            else
                test.Tag = "true";
        }
        private void txtFindID_TextChanged(object sender, EventArgs e)
        {
            NOEmptySomthing((TextBox)sender);
        }

        private void txtFindUserName_TextChanged(object sender, EventArgs e)
        {

            NOEmptySomthing((TextBox)sender);
        }

        private void txtFindPassword_TextChanged(object sender, EventArgs e)
        {
            NOEmptySomthing((TextBox)sender);

        }

        private void txtFindEmail_TextChanged(object sender, EventArgs e)
        {
            NOEmptySomthing((TextBox)sender);

        }

        private void txtFindAddress_TextChanged(object sender, EventArgs e)
        {
            NOEmptySomthing((TextBox)sender);

        }

        private void txtFindPhone_TextChanged(object sender, EventArgs e)
        {
            NOEmptySomthing((TextBox)sender);

        }

        private void txtFindFirstName_TextChanged(object sender, EventArgs e)
        {
            NOEmptySomthing((TextBox)sender);

        }

        private void txtFindLastName_TextChanged(object sender, EventArgs e)
        {
            NOEmptySomthing((TextBox)sender);
            
        }

        private void rbtnIDSearch_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchById.Enabled = rbtnIDSearch.Checked;
            txtSearchByUserName.Clear();
        }

        private void rdbtnUserNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchByUserName.Enabled = rbtnUserNameSearch.Checked;
            txtSearchById.Clear();

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            DesableFindUser(true);
            btnEditUser.Enabled = false;
            btnSaveUser.Enabled = true;
            txtSearchById.Enabled = false;
            txtSearchByUserName.Enabled = false;
            btnSearchUser.Enabled = false;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure for Edit this user", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            btnEditUser.Enabled = true;
            btnSaveUser.Enabled = false;
            DesableFindUser(false);
            txtSearchById.Enabled = true;
            txtSearchByUserName.Enabled = true;
            btnSearchUser.Enabled = true;
        }
    }
}
