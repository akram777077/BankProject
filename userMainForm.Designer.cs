namespace BankProject
{
    partial class userMainForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClientMang = new System.Windows.Forms.Button();
            this.btnUsersMangment = new System.Windows.Forms.Button();
            this.btnLogLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(712, 400);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 38);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClientMang
            // 
            this.btnClientMang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClientMang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClientMang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnClientMang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientMang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientMang.Location = new System.Drawing.Point(321, 127);
            this.btnClientMang.Name = "btnClientMang";
            this.btnClientMang.Size = new System.Drawing.Size(116, 41);
            this.btnClientMang.TabIndex = 0;
            this.btnClientMang.Text = "client Mangment";
            this.btnClientMang.UseVisualStyleBackColor = true;
            this.btnClientMang.Click += new System.EventHandler(this.btnClientMang_Click);
            // 
            // btnUsersMangment
            // 
            this.btnUsersMangment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsersMangment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUsersMangment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUsersMangment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersMangment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsersMangment.Location = new System.Drawing.Point(321, 223);
            this.btnUsersMangment.Name = "btnUsersMangment";
            this.btnUsersMangment.Size = new System.Drawing.Size(116, 41);
            this.btnUsersMangment.TabIndex = 1;
            this.btnUsersMangment.Text = "Users Mangment";
            this.btnUsersMangment.UseVisualStyleBackColor = true;
            this.btnUsersMangment.Click += new System.EventHandler(this.btnUsersMangment_Click);
            // 
            // btnLogLogin
            // 
            this.btnLogLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnLogLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogLogin.Location = new System.Drawing.Point(321, 315);
            this.btnLogLogin.Name = "btnLogLogin";
            this.btnLogLogin.Size = new System.Drawing.Size(116, 41);
            this.btnLogLogin.TabIndex = 2;
            this.btnLogLogin.Text = "Log Login";
            this.btnLogLogin.UseVisualStyleBackColor = true;
            this.btnLogLogin.Click += new System.EventHandler(this.btnLogLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(311, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 55);
            this.label3.TabIndex = 10;
            this.label3.Text = "Main";
            // 
            // userMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogLogin);
            this.Controls.Add(this.btnUsersMangment);
            this.Controls.Add(this.btnClientMang);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClientMang;
        private System.Windows.Forms.Button btnUsersMangment;
        private System.Windows.Forms.Button btnLogLogin;
        private System.Windows.Forms.Label label3;
    }
}

