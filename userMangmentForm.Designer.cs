namespace BankProject
{
    partial class userMangmentForm
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.crProgress = new CircularProgressBar.CircularProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFist = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnUserNameSearch = new System.Windows.Forms.RadioButton();
            this.rbtnIDSearch = new System.Windows.Forms.RadioButton();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.txtSearchByUserName = new System.Windows.Forms.TextBox();
            this.gbInfromation = new System.Windows.Forms.GroupBox();
            this.txtFindEmail = new System.Windows.Forms.TextBox();
            this.txtFindPhone = new System.Windows.Forms.TextBox();
            this.txtFindID = new System.Windows.Forms.TextBox();
            this.progressTotalFind = new CircularProgressBar.CircularProgressBar();
            this.dtFindDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtFindAddress = new System.Windows.Forms.TextBox();
            this.txtFindFirstName = new System.Windows.Forms.TextBox();
            this.txtFindLastName = new System.Windows.Forms.TextBox();
            this.txtFindUserName = new System.Windows.Forms.TextBox();
            this.txtFindPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ErrrEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.x.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbInfromation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrrEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(739, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // x
            // 
            this.x.AccessibleName = "";
            this.x.Controls.Add(this.tabPage1);
            this.x.Controls.Add(this.tabPage2);
            this.x.Controls.Add(this.tabPage3);
            this.x.Location = new System.Drawing.Point(12, 49);
            this.x.Name = "x";
            this.x.SelectedIndex = 0;
            this.x.Size = new System.Drawing.Size(776, 389);
            this.x.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.crProgress);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dtDateOfBirth);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.txtUserName);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblFist);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add User";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(422, 49);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "false";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(422, 173);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Tag = "false";
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(207, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            this.txtId.Tag = "false";
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // crProgress
            // 
            this.crProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.crProgress.AnimationSpeed = 500;
            this.crProgress.BackColor = System.Drawing.Color.Transparent;
            this.crProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crProgress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.crProgress.InnerMargin = 2;
            this.crProgress.InnerWidth = -1;
            this.crProgress.Location = new System.Drawing.Point(-4, 6);
            this.crProgress.MarqueeAnimationSpeed = 2000;
            this.crProgress.Name = "crProgress";
            this.crProgress.OuterColor = System.Drawing.Color.DimGray;
            this.crProgress.OuterMargin = 3;
            this.crProgress.OuterWidth = -8;
            this.crProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.crProgress.ProgressWidth = 5;
            this.crProgress.SecondaryFont = new System.Drawing.Font("Impact", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crProgress.Size = new System.Drawing.Size(100, 93);
            this.crProgress.StartAngle = 270;
            this.crProgress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crProgress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.crProgress.SubscriptText = ".23";
            this.crProgress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.crProgress.SuperscriptMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.crProgress.SuperscriptText = "°C";
            this.crProgress.TabIndex = 21;
            this.crProgress.Text = "0%";
            this.crProgress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.crProgress.Value = 68;
            this.crProgress.Click += new System.EventHandler(this.crProgress_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(669, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfBirth.Location = new System.Drawing.Point(644, 174);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dtDateOfBirth.TabIndex = 8;
            this.dtDateOfBirth.Value = new System.DateTime(2024, 2, 10, 10, 2, 15, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(422, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Tag = "false";
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(644, 49);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.Tag = "false";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(644, 105);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.Tag = "false";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(207, 113);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Tag = "false";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(207, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "false";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(542, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date Of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(334, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(334, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(334, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(106, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(106, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(106, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(543, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // lblFist
            // 
            this.lblFist.AutoSize = true;
            this.lblFist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFist.Location = new System.Drawing.Point(542, 53);
            this.lblFist.Name = "lblFist";
            this.lblFist.Size = new System.Drawing.Size(82, 16);
            this.lblFist.TabIndex = 0;
            this.lblFist.Text = "First Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnSaveUser);
            this.tabPage2.Controls.Add(this.btnEditUser);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.gbInfromation);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "find user";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveUser.Location = new System.Drawing.Point(683, 331);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUser.TabIndex = 13;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditUser.Location = new System.Drawing.Point(575, 331);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 12;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnUserNameSearch);
            this.groupBox2.Controls.Add(this.rbtnIDSearch);
            this.groupBox2.Controls.Add(this.btnSearchUser);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtSearchById);
            this.groupBox2.Controls.Add(this.txtSearchByUserName);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 115);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbtnUserNameSearch
            // 
            this.rbtnUserNameSearch.AutoSize = true;
            this.rbtnUserNameSearch.Location = new System.Drawing.Point(15, 65);
            this.rbtnUserNameSearch.Name = "rbtnUserNameSearch";
            this.rbtnUserNameSearch.Size = new System.Drawing.Size(14, 13);
            this.rbtnUserNameSearch.TabIndex = 54;
            this.rbtnUserNameSearch.TabStop = true;
            this.rbtnUserNameSearch.UseVisualStyleBackColor = true;
            this.rbtnUserNameSearch.CheckedChanged += new System.EventHandler(this.rdbtnUserNameSearch_CheckedChanged);
            // 
            // rbtnIDSearch
            // 
            this.rbtnIDSearch.AutoSize = true;
            this.rbtnIDSearch.Location = new System.Drawing.Point(15, 29);
            this.rbtnIDSearch.Name = "rbtnIDSearch";
            this.rbtnIDSearch.Size = new System.Drawing.Size(14, 13);
            this.rbtnIDSearch.TabIndex = 53;
            this.rbtnIDSearch.TabStop = true;
            this.rbtnIDSearch.UseVisualStyleBackColor = true;
            this.rbtnIDSearch.CheckedChanged += new System.EventHandler(this.rbtnIDSearch_CheckedChanged);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearchUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchUser.Location = new System.Drawing.Point(230, 87);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUser.TabIndex = 11;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(35, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 16);
            this.label19.TabIndex = 52;
            this.label19.Text = "User Name";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(35, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 16);
            this.label18.TabIndex = 51;
            this.label18.Text = "ID";
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(131, 26);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(100, 20);
            this.txtSearchById.TabIndex = 9;
            this.txtSearchById.Tag = "false";
            // 
            // txtSearchByUserName
            // 
            this.txtSearchByUserName.Location = new System.Drawing.Point(131, 61);
            this.txtSearchByUserName.Name = "txtSearchByUserName";
            this.txtSearchByUserName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchByUserName.TabIndex = 10;
            this.txtSearchByUserName.Tag = "false";
            // 
            // gbInfromation
            // 
            this.gbInfromation.Controls.Add(this.txtFindEmail);
            this.gbInfromation.Controls.Add(this.txtFindPhone);
            this.gbInfromation.Controls.Add(this.txtFindID);
            this.gbInfromation.Controls.Add(this.progressTotalFind);
            this.gbInfromation.Controls.Add(this.dtFindDateOfBirth);
            this.gbInfromation.Controls.Add(this.txtFindAddress);
            this.gbInfromation.Controls.Add(this.txtFindFirstName);
            this.gbInfromation.Controls.Add(this.txtFindLastName);
            this.gbInfromation.Controls.Add(this.txtFindUserName);
            this.gbInfromation.Controls.Add(this.txtFindPassword);
            this.gbInfromation.Controls.Add(this.label1);
            this.gbInfromation.Controls.Add(this.label10);
            this.gbInfromation.Controls.Add(this.label11);
            this.gbInfromation.Controls.Add(this.label12);
            this.gbInfromation.Controls.Add(this.label13);
            this.gbInfromation.Controls.Add(this.label14);
            this.gbInfromation.Controls.Add(this.label15);
            this.gbInfromation.Controls.Add(this.label16);
            this.gbInfromation.Controls.Add(this.label17);
            this.gbInfromation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInfromation.ForeColor = System.Drawing.Color.White;
            this.gbInfromation.Location = new System.Drawing.Point(6, 6);
            this.gbInfromation.Name = "gbInfromation";
            this.gbInfromation.Size = new System.Drawing.Size(759, 223);
            this.gbInfromation.TabIndex = 48;
            this.gbInfromation.TabStop = false;
            this.gbInfromation.Text = "Infromation";
            // 
            // txtFindEmail
            // 
            this.txtFindEmail.Location = new System.Drawing.Point(414, 68);
            this.txtFindEmail.Name = "txtFindEmail";
            this.txtFindEmail.Size = new System.Drawing.Size(100, 20);
            this.txtFindEmail.TabIndex = 3;
            this.txtFindEmail.Tag = "false";
            this.txtFindEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtFindPhone
            // 
            this.txtFindPhone.Location = new System.Drawing.Point(414, 192);
            this.txtFindPhone.Name = "txtFindPhone";
            this.txtFindPhone.Size = new System.Drawing.Size(100, 20);
            this.txtFindPhone.TabIndex = 5;
            this.txtFindPhone.Tag = "false";
            this.txtFindPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtFindID
            // 
            this.txtFindID.Location = new System.Drawing.Point(199, 71);
            this.txtFindID.Name = "txtFindID";
            this.txtFindID.Size = new System.Drawing.Size(100, 20);
            this.txtFindID.TabIndex = 0;
            this.txtFindID.Tag = "false";
            this.txtFindID.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // progressTotalFind
            // 
            this.progressTotalFind.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressTotalFind.AnimationSpeed = 500;
            this.progressTotalFind.BackColor = System.Drawing.Color.Transparent;
            this.progressTotalFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressTotalFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressTotalFind.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressTotalFind.InnerMargin = 2;
            this.progressTotalFind.InnerWidth = -1;
            this.progressTotalFind.Location = new System.Drawing.Point(0, 19);
            this.progressTotalFind.MarqueeAnimationSpeed = 2000;
            this.progressTotalFind.Name = "progressTotalFind";
            this.progressTotalFind.OuterColor = System.Drawing.Color.DimGray;
            this.progressTotalFind.OuterMargin = 3;
            this.progressTotalFind.OuterWidth = -8;
            this.progressTotalFind.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressTotalFind.ProgressWidth = 5;
            this.progressTotalFind.SecondaryFont = new System.Drawing.Font("Impact", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressTotalFind.Size = new System.Drawing.Size(100, 93);
            this.progressTotalFind.StartAngle = 270;
            this.progressTotalFind.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressTotalFind.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressTotalFind.SubscriptText = ".23";
            this.progressTotalFind.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressTotalFind.SuperscriptMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressTotalFind.SuperscriptText = "°C";
            this.progressTotalFind.TabIndex = 59;
            this.progressTotalFind.Text = "0%";
            this.progressTotalFind.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressTotalFind.Value = 68;
            // 
            // dtFindDateOfBirth
            // 
            this.dtFindDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFindDateOfBirth.Location = new System.Drawing.Point(636, 193);
            this.dtFindDateOfBirth.Name = "dtFindDateOfBirth";
            this.dtFindDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dtFindDateOfBirth.TabIndex = 8;
            this.dtFindDateOfBirth.Value = new System.DateTime(2024, 2, 10, 10, 2, 15, 0);
            // 
            // txtFindAddress
            // 
            this.txtFindAddress.Location = new System.Drawing.Point(414, 128);
            this.txtFindAddress.Name = "txtFindAddress";
            this.txtFindAddress.Size = new System.Drawing.Size(100, 20);
            this.txtFindAddress.TabIndex = 4;
            this.txtFindAddress.Tag = "false";
            this.txtFindAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtFindFirstName
            // 
            this.txtFindFirstName.Location = new System.Drawing.Point(636, 68);
            this.txtFindFirstName.Name = "txtFindFirstName";
            this.txtFindFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFindFirstName.TabIndex = 6;
            this.txtFindFirstName.Tag = "false";
            this.txtFindFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtFindLastName
            // 
            this.txtFindLastName.Location = new System.Drawing.Point(636, 124);
            this.txtFindLastName.Name = "txtFindLastName";
            this.txtFindLastName.Size = new System.Drawing.Size(100, 20);
            this.txtFindLastName.TabIndex = 7;
            this.txtFindLastName.Tag = "false";
            this.txtFindLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFindUserName
            // 
            this.txtFindUserName.Location = new System.Drawing.Point(199, 127);
            this.txtFindUserName.Name = "txtFindUserName";
            this.txtFindUserName.Size = new System.Drawing.Size(100, 20);
            this.txtFindUserName.TabIndex = 1;
            this.txtFindUserName.Tag = "false";
            this.txtFindUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtFindPassword
            // 
            this.txtFindPassword.Location = new System.Drawing.Point(199, 188);
            this.txtFindPassword.Name = "txtFindPassword";
            this.txtFindPassword.Size = new System.Drawing.Size(100, 20);
            this.txtFindPassword.TabIndex = 2;
            this.txtFindPassword.Tag = "false";
            this.txtFindPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(534, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Date Of Birth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(326, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 56;
            this.label10.Text = "address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(326, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(326, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 51;
            this.label12.Text = "Phone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(98, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 49;
            this.label13.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(98, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 16);
            this.label14.TabIndex = 47;
            this.label14.Text = "User Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(98, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 16);
            this.label15.TabIndex = 45;
            this.label15.Text = "ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(535, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 16);
            this.label16.TabIndex = 43;
            this.label16.Text = "Last Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(534, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 41;
            this.label17.Text = "First Name";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 363);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "list Users";
            // 
            // ErrrEmpty
            // 
            this.ErrrEmpty.ContainerControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(465, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // userMangmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.x);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userMangmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userMangmentForm";
            this.Load += new System.EventHandler(this.userMangmentForm_Load);
            this.x.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbInfromation.ResumeLayout(false);
            this.gbInfromation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrrEmpty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl x;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.Button button1;
        private CircularProgressBar.CircularProgressBar crProgress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider ErrrEmpty;
        private System.Windows.Forms.GroupBox gbInfromation;
        private System.Windows.Forms.TextBox txtFindEmail;
        private System.Windows.Forms.TextBox txtFindPhone;
        private System.Windows.Forms.TextBox txtFindID;
        private CircularProgressBar.CircularProgressBar progressTotalFind;
        private System.Windows.Forms.DateTimePicker dtFindDateOfBirth;
        private System.Windows.Forms.TextBox txtFindAddress;
        private System.Windows.Forms.TextBox txtFindFirstName;
        private System.Windows.Forms.TextBox txtFindLastName;
        private System.Windows.Forms.TextBox txtFindUserName;
        private System.Windows.Forms.TextBox txtFindPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.TextBox txtSearchByUserName;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.RadioButton rbtnUserNameSearch;
        private System.Windows.Forms.RadioButton rbtnIDSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}