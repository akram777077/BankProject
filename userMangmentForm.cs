﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            user.Address = txtAddress.Text;
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
            ctxmnShowUsers.Enabled = false;
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
            romveErorAll();
            DesableFindUser(false);
            progressTotalFind.Value = 0;
            rbtnIDSearch.Checked = true;
            txtSearchByUserName.Enabled = false;
            btnEditUser.Enabled = false;
            btnSaveUser.Enabled = false;
            btnDelete.Enabled = false;
            btnAply.Enabled = true;
            cbFilter.Text = "All";
            
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
            else if(Globale.listUsers.getUserID(((TextBox)sender).Text.ToString()) != -1 && !test)
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
            else if (Globale.listUsers.getUserUserName(((TextBox)sender).Text.ToString()) != -1 && !test)
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
        private int indexTargetFound;
        private void removeError(TextBox  sender)
        {
            ErrrEmpty.SetError(sender, "");
        }
        private void romveErorAll()
        {
            removeError(txtFindID);
            removeError(txtFindUserName);
            removeError(txtFindPassword);
            removeError(txtFindPhone);
            removeError(txtFindEmail);
            removeError(txtFindAddress);
            removeError(txtFindFirstName);
            removeError(txtFindLastName);
        }
        User target;
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            
            int index=(rbtnIDSearch.Checked)?Globale.listUsers.getUserID(txtSearchById.Text):Globale.listUsers.getUserUserName(txtSearchByUserName.Text);
            target = Globale.listUsers.getUserByIndex(index);
            if (target == null)
            {
                ErrrEmpty.SetError(btnSearchUser, "This user is not in the system");
                clearTexts();
                progressTotalFind.Text = "0%";
                progressTotalFind.Value = 0;
                btnDelete.Enabled = false;
                btnEditUser.Enabled= false;
                romveErorAll();
            }
            else
            {
                TargetFound = target;
                indexTargetFound = index;
                fillTheTextBoxWithUser(target);
                ErrrEmpty.SetError(btnSearchUser, "");
                btnEditUser.Enabled = true;
                btnDelete.Enabled = true;

            }
            ErrrEmpty.SetError(btnDelete, "");
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
            btnDelete.Enabled = false;
        }
        private void editUser()
        {
            DateTime.TryParse(dtFindDateOfBirth.Value.ToShortDateString(), out DateTime date);
            User temp = new User(txtFindID.Text, txtFindFirstName.Text, txtFindLastName.Text, txtFindUserName.Text, txtFindPassword.Text, txtFindEmail.Text, txtFindPhone.Text, txtFindAddress.Text, date);
            Globale.listUsers.changeUser(indexTargetFound, temp);
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
            btnDelete.Enabled = true;
            editUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure for delete "+txtFindUserName.Text,"Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.Cancel)
                return;
            if(Convert.ToInt16(target.Id)==0)
            {
                ErrrEmpty.SetError(btnDelete, "this is Admin Account you can't delete it");
                return;
            }
            if(target.Id == Globale.currentUser.Id)
            {
                ErrrEmpty.SetError(btnDelete, "this is current user you can't delete it");
                return;
            }
            Globale.listUsers.deleteUserID(target);
            clearTexts();
            userMangmentForm_Load(sender,e);
            MessageBox.Show("The user " + target.UserName + " is delete from the system", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text != "All")
            {
                txtFilter.Enabled = true;
                if(txtFilter.Text.ToString()=="")
                    btnAply.Enabled = false;
                return;
            }
            txtFilter.Enabled = false;
            btnAply.Enabled = true;
        }
        private void addUserToList(User user)
        {
            ListViewItem item = new ListViewItem(user.Id);
            item.SubItems.Add(user.UserName);
            item.SubItems.Add(user.FirstName);
            item.SubItems.Add(user.LastName);
            item.SubItems.Add(user.Phone);
            item.SubItems.Add(user.Email);
            item.SubItems.Add(user.DateOfBirth.ToShortDateString());
            LvUsers.Items.Add(item);
        }
        private void fillListUsers()
        {
            for(int i=0;i<Globale.listUsers.getSize();i++)
                addUserToList(Globale.listUsers.getUserByIndex(i));
        }
        private void fillListUsersFilter(string filter,string target)
        {
            string comp = "";
            for (int i = 0; i < Globale.listUsers.getSize(); i++)
            {
                User temp = Globale.listUsers.getUserByIndex(i);
                switch(filter)
                {
                    case "Email":
                        comp = temp.Email;
                        break;
                    case "Phone":
                        comp = temp.Phone;
                        break;
                    case "First Name":
                        comp = temp.FirstName;
                        break;
                    case "Last Name":
                        comp = temp.LastName;
                        break;
                    case "Address":
                        comp = temp.Address;
                        break;
                    case "Birth Date":
                        comp = temp.DateOfBirth.ToShortDateString();
                        break;
                    case "User Name":
                        comp = temp.UserName;
                        break;
                    case "ID":
                        comp = temp.Id;
                        break;
                }
                if(comp==target)
                    addUserToList(Globale.listUsers.getUserByIndex(i));
            }
        }
        private void btnAply_Click(object sender, EventArgs e)
        {
            LvUsers.Items.Clear();
            if(cbFilter.Text.ToString()=="All")
            {
                fillListUsers();
                return;
            }
            fillListUsersFilter(cbFilter.Text.ToString(), txtFilter.Text.ToString());
            if (LvUsers.Items.Count == 0)
                MessageBox.Show($"{txtFilter.Text} is Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            btnAply.Enabled = !string.IsNullOrEmpty(txtFilter.Text);
                
        }

        private void LvUsers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            if (LvUsers.SelectedItems.Count > 0)
            {
                bool testCurrentUser = LvUsers.SelectedItems[0].SubItems[0].Text == Globale.currentUser.Id;
                bool testAdmin = LvUsers.SelectedItems[0].SubItems[0].Text == "Admin";
                ctxmnShowUsers.Enabled = true;
                ctxmnShowUsers.Items[1].Enabled = true;
                if (testCurrentUser || testAdmin)
                    ctxmnShowUsers.Items[1].Enabled = false;
            }
            else
                ctxmnShowUsers.Enabled = false;
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int userIndex = Globale.listUsers.getUserID(LvUsers.SelectedItems[0].SubItems[0].Text);
            User user = Globale.listUsers.getUserByIndex(userIndex);
            if (MessageBox.Show("Are you sure for Delete " +user.UserName +"?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;
            Globale.listUsers.deleteUserID(user);
            MessageBox.Show($"The user {user.UserName} is Deleting from the system","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnAply_Click(sender, e);
        }

        private void ctxmnShowUsers_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
