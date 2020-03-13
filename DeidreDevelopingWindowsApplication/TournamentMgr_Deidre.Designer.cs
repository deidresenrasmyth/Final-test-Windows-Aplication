namespace DeidreDevelopingWindowsApplication
{
    partial class teamFrm
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
            this.teamsGridView = new System.Windows.Forms.DataGridView();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameTxt = new System.Windows.Forms.TextBox();
            this.directorNameTxt = new System.Windows.Forms.TextBox();
            this.coachNameTxt = new System.Windows.Forms.TextBox();
            this.contactNumberTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.postCodeTxt = new System.Windows.Forms.TextBox();
            this.addressLine2Txt = new System.Windows.Forms.TextBox();
            this.addressLine1Txt = new System.Windows.Forms.TextBox();
            this.emailAddressTxt = new System.Windows.Forms.TextBox();
            this.teamNameLbl = new System.Windows.Forms.Label();
            this.contactNumberLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.PostCodeLbl = new System.Windows.Forms.Label();
            this.addressLine2Label = new System.Windows.Forms.Label();
            this.addressLine1Lbl = new System.Windows.Forms.Label();
            this.directorNameLbl = new System.Windows.Forms.Label();
            this.CoachNamelbl = new System.Windows.Forms.Label();
            this.emailAddressLbl = new System.Windows.Forms.Label();
            this.insertUpdateBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teamsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teamsGridView
            // 
            this.teamsGridView.AllowUserToAddRows = false;
            this.teamsGridView.AllowUserToDeleteRows = false;
            this.teamsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamId,
            this.TeamName,
            this.CoachName,
            this.DirectorName,
            this.AddressLine1,
            this.AddressLine2,
            this.PostCode,
            this.City,
            this.ContactNumber,
            this.EmailAddress});
            this.teamsGridView.Location = new System.Drawing.Point(12, 12);
            this.teamsGridView.MultiSelect = false;
            this.teamsGridView.Name = "teamsGridView";
            this.teamsGridView.ReadOnly = true;
            this.teamsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.teamsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teamsGridView.Size = new System.Drawing.Size(776, 150);
            this.teamsGridView.TabIndex = 0;
            this.teamsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeamsGridView_CellClick);
            this.teamsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeamsGridView_CellContentClick);
            // 
            // TeamId
            // 
            this.TeamId.DataPropertyName = "TeamId";
            this.TeamId.HeaderText = "TeamId";
            this.TeamId.Name = "TeamId";
            this.TeamId.ReadOnly = true;
            this.TeamId.Visible = false;
            // 
            // TeamName
            // 
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "TeamName";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            // 
            // CoachName
            // 
            this.CoachName.DataPropertyName = "CoachName";
            this.CoachName.HeaderText = "CoachName";
            this.CoachName.Name = "CoachName";
            this.CoachName.ReadOnly = true;
            // 
            // DirectorName
            // 
            this.DirectorName.DataPropertyName = "DirectorName";
            this.DirectorName.HeaderText = "DirectorName";
            this.DirectorName.Name = "DirectorName";
            this.DirectorName.ReadOnly = true;
            // 
            // AddressLine1
            // 
            this.AddressLine1.DataPropertyName = "AddressLine1";
            this.AddressLine1.HeaderText = "AddressLine1";
            this.AddressLine1.Name = "AddressLine1";
            this.AddressLine1.ReadOnly = true;
            // 
            // AddressLine2
            // 
            this.AddressLine2.DataPropertyName = "AddressLine2";
            this.AddressLine2.HeaderText = "AddressLine2";
            this.AddressLine2.Name = "AddressLine2";
            this.AddressLine2.ReadOnly = true;
            // 
            // PostCode
            // 
            this.PostCode.DataPropertyName = "PostCode";
            this.PostCode.HeaderText = "PostCode";
            this.PostCode.Name = "PostCode";
            this.PostCode.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "ContactNumber";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            // 
            // teamNameTxt
            // 
            this.teamNameTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.teamNameTxt.Location = new System.Drawing.Point(95, 180);
            this.teamNameTxt.Name = "teamNameTxt";
            this.teamNameTxt.Size = new System.Drawing.Size(100, 20);
            this.teamNameTxt.TabIndex = 1;
            this.teamNameTxt.TextChanged += new System.EventHandler(this.TeamNameTxt_TextChanged);
            // 
            // directorNameTxt
            // 
            this.directorNameTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.directorNameTxt.Location = new System.Drawing.Point(289, 182);
            this.directorNameTxt.Name = "directorNameTxt";
            this.directorNameTxt.Size = new System.Drawing.Size(100, 20);
            this.directorNameTxt.TabIndex = 2;
            // 
            // coachNameTxt
            // 
            this.coachNameTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.coachNameTxt.Location = new System.Drawing.Point(506, 183);
            this.coachNameTxt.Name = "coachNameTxt";
            this.coachNameTxt.Size = new System.Drawing.Size(100, 20);
            this.coachNameTxt.TabIndex = 3;
            // 
            // contactNumberTxt
            // 
            this.contactNumberTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contactNumberTxt.Location = new System.Drawing.Point(506, 263);
            this.contactNumberTxt.Name = "contactNumberTxt";
            this.contactNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.contactNumberTxt.TabIndex = 9;
            // 
            // cityTxt
            // 
            this.cityTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cityTxt.Location = new System.Drawing.Point(289, 263);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(100, 20);
            this.cityTxt.TabIndex = 8;
            // 
            // postCodeTxt
            // 
            this.postCodeTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.postCodeTxt.Location = new System.Drawing.Point(506, 223);
            this.postCodeTxt.MaxLength = 9;
            this.postCodeTxt.Name = "postCodeTxt";
            this.postCodeTxt.Size = new System.Drawing.Size(100, 20);
            this.postCodeTxt.TabIndex = 6;
            this.postCodeTxt.TextChanged += new System.EventHandler(this.PostCodeTxt_TextChanged);
            // 
            // addressLine2Txt
            // 
            this.addressLine2Txt.AcceptsReturn = true;
            this.addressLine2Txt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addressLine2Txt.Location = new System.Drawing.Point(95, 219);
            this.addressLine2Txt.Name = "addressLine2Txt";
            this.addressLine2Txt.Size = new System.Drawing.Size(100, 20);
            this.addressLine2Txt.TabIndex = 4;
            // 
            // addressLine1Txt
            // 
            this.addressLine1Txt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addressLine1Txt.Location = new System.Drawing.Point(289, 221);
            this.addressLine1Txt.Name = "addressLine1Txt";
            this.addressLine1Txt.Size = new System.Drawing.Size(100, 20);
            this.addressLine1Txt.TabIndex = 5;
            // 
            // emailAddressTxt
            // 
            this.emailAddressTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailAddressTxt.Location = new System.Drawing.Point(94, 260);
            this.emailAddressTxt.Name = "emailAddressTxt";
            this.emailAddressTxt.Size = new System.Drawing.Size(100, 20);
            this.emailAddressTxt.TabIndex = 7;
            // 
            // teamNameLbl
            // 
            this.teamNameLbl.AutoSize = true;
            this.teamNameLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.teamNameLbl.Location = new System.Drawing.Point(25, 183);
            this.teamNameLbl.Name = "teamNameLbl";
            this.teamNameLbl.Size = new System.Drawing.Size(65, 13);
            this.teamNameLbl.TabIndex = 12;
            this.teamNameLbl.Text = "Team Name";
            // 
            // contactNumberLbl
            // 
            this.contactNumberLbl.AutoSize = true;
            this.contactNumberLbl.Location = new System.Drawing.Point(416, 270);
            this.contactNumberLbl.Name = "contactNumberLbl";
            this.contactNumberLbl.Size = new System.Drawing.Size(84, 13);
            this.contactNumberLbl.TabIndex = 13;
            this.contactNumberLbl.Text = "Contact Number";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(259, 267);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(24, 13);
            this.cityLbl.TabIndex = 14;
            this.cityLbl.Text = "City";
            // 
            // PostCodeLbl
            // 
            this.PostCodeLbl.AutoSize = true;
            this.PostCodeLbl.Location = new System.Drawing.Point(442, 228);
            this.PostCodeLbl.Name = "PostCodeLbl";
            this.PostCodeLbl.Size = new System.Drawing.Size(56, 13);
            this.PostCodeLbl.TabIndex = 15;
            this.PostCodeLbl.Text = "Post Code";
            // 
            // addressLine2Label
            // 
            this.addressLine2Label.AutoSize = true;
            this.addressLine2Label.Location = new System.Drawing.Point(12, 222);
            this.addressLine2Label.Name = "addressLine2Label";
            this.addressLine2Label.Size = new System.Drawing.Size(77, 13);
            this.addressLine2Label.TabIndex = 16;
            this.addressLine2Label.Text = "Address Line 2";
            // 
            // addressLine1Lbl
            // 
            this.addressLine1Lbl.AutoSize = true;
            this.addressLine1Lbl.Location = new System.Drawing.Point(208, 226);
            this.addressLine1Lbl.Name = "addressLine1Lbl";
            this.addressLine1Lbl.Size = new System.Drawing.Size(77, 13);
            this.addressLine1Lbl.TabIndex = 17;
            this.addressLine1Lbl.Text = "Address Line 1";
            // 
            // directorNameLbl
            // 
            this.directorNameLbl.AutoSize = true;
            this.directorNameLbl.Location = new System.Drawing.Point(208, 187);
            this.directorNameLbl.Name = "directorNameLbl";
            this.directorNameLbl.Size = new System.Drawing.Size(75, 13);
            this.directorNameLbl.TabIndex = 18;
            this.directorNameLbl.Text = "Director Name";
            // 
            // CoachNamelbl
            // 
            this.CoachNamelbl.AutoSize = true;
            this.CoachNamelbl.Location = new System.Drawing.Point(437, 186);
            this.CoachNamelbl.Name = "CoachNamelbl";
            this.CoachNamelbl.Size = new System.Drawing.Size(69, 13);
            this.CoachNamelbl.TabIndex = 19;
            this.CoachNamelbl.Text = "Coach Name";
            // 
            // emailAddressLbl
            // 
            this.emailAddressLbl.AutoSize = true;
            this.emailAddressLbl.Location = new System.Drawing.Point(54, 263);
            this.emailAddressLbl.Name = "emailAddressLbl";
            this.emailAddressLbl.Size = new System.Drawing.Size(32, 13);
            this.emailAddressLbl.TabIndex = 20;
            this.emailAddressLbl.Text = "Email";
            // 
            // insertUpdateBtn
            // 
            this.insertUpdateBtn.Location = new System.Drawing.Point(661, 210);
            this.insertUpdateBtn.Name = "insertUpdateBtn";
            this.insertUpdateBtn.Size = new System.Drawing.Size(127, 23);
            this.insertUpdateBtn.TabIndex = 21;
            this.insertUpdateBtn.Text = "Insert / Update";
            this.insertUpdateBtn.UseVisualStyleBackColor = true;
            this.insertUpdateBtn.Click += new System.EventHandler(this.InsertUpdateBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Delete Row";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(661, 262);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(127, 23);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearBtn.Location = new System.Drawing.Point(661, 183);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(127, 23);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.Text = "Clear fields";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // teamFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(803, 296);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.insertUpdateBtn);
            this.Controls.Add(this.emailAddressLbl);
            this.Controls.Add(this.CoachNamelbl);
            this.Controls.Add(this.directorNameLbl);
            this.Controls.Add(this.addressLine1Lbl);
            this.Controls.Add(this.addressLine2Label);
            this.Controls.Add(this.PostCodeLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.contactNumberLbl);
            this.Controls.Add(this.teamNameLbl);
            this.Controls.Add(this.emailAddressTxt);
            this.Controls.Add(this.addressLine1Txt);
            this.Controls.Add(this.addressLine2Txt);
            this.Controls.Add(this.postCodeTxt);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.contactNumberTxt);
            this.Controls.Add(this.coachNameTxt);
            this.Controls.Add(this.directorNameTxt);
            this.Controls.Add(this.teamNameTxt);
            this.Controls.Add(this.teamsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "teamFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Management System";
            this.Load += new System.EventHandler(this.TeamFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView teamsGridView;
        private System.Windows.Forms.TextBox teamNameTxt;
        private System.Windows.Forms.TextBox directorNameTxt;
        private System.Windows.Forms.TextBox coachNameTxt;
        private System.Windows.Forms.TextBox contactNumberTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.TextBox postCodeTxt;
        private System.Windows.Forms.TextBox addressLine2Txt;
        private System.Windows.Forms.TextBox addressLine1Txt;
        private System.Windows.Forms.TextBox emailAddressTxt;
        private System.Windows.Forms.Label teamNameLbl;
        private System.Windows.Forms.Label contactNumberLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label PostCodeLbl;
        private System.Windows.Forms.Label addressLine2Label;
        private System.Windows.Forms.Label addressLine1Lbl;
        private System.Windows.Forms.Label directorNameLbl;
        private System.Windows.Forms.Label CoachNamelbl;
        private System.Windows.Forms.Label emailAddressLbl;
        private System.Windows.Forms.Button insertUpdateBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.Button clearBtn;
    }
}

