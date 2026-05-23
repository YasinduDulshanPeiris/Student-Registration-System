using Microsoft.Data.SqlClient;

namespace StudentRegistrationSystem
{
    partial class Registration
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
        /// 





        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            mainPanel = new Panel();
            linkLogout = new LinkLabel();
            lblCampusOneDigitalAcademy = new Label();
            grpStudentRegistration = new GroupBox();
            linkExit = new LinkLabel();
            btnDelete = new Button();
            lblRegNo = new Label();
            btnClear = new Button();
            cmbRegNo = new ComboBox();
            btnUpdate = new Button();
            grpParentDetails = new GroupBox();
            txtNIC = new TextBox();
            txtContact = new TextBox();
            lblContact = new Label();
            lblParentName = new Label();
            lblNIC = new Label();
            txtParentName = new TextBox();
            btnRegister = new Button();
            grpContactDetails = new GroupBox();
            txtHome = new TextBox();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            lblHome = new Label();
            lblAddress = new Label();
            lblMobile = new Label();
            lblEmail = new Label();
            grpBasicDetails = new GroupBox();
            rbFemale = new RadioButton();
            dtpDOB = new DateTimePicker();
            rbMale = new RadioButton();
            txtLastName = new TextBox();
            lblGender = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            lblDOB = new Label();
            lblLastName = new Label();
            mainPanel.SuspendLayout();
            grpStudentRegistration.SuspendLayout();
            grpParentDetails.SuspendLayout();
            grpContactDetails.SuspendLayout();
            grpBasicDetails.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(linkLogout);
            mainPanel.Controls.Add(lblCampusOneDigitalAcademy);
            mainPanel.Controls.Add(grpStudentRegistration);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 10);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(882, 646);
            mainPanel.TabIndex = 0;
            // 
            // linkLogout
            // 
            linkLogout.AutoSize = true;
            linkLogout.Location = new Point(10, 10);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(56, 20);
            linkLogout.TabIndex = 5;
            linkLogout.TabStop = true;
            linkLogout.Text = "Logout";
            linkLogout.LinkClicked += linkLogout_LinkClicked;
            // 
            // lblCampusOneDigitalAcademy
            // 
            lblCampusOneDigitalAcademy.Dock = DockStyle.Top;
            lblCampusOneDigitalAcademy.Font = new Font("Times New Roman", 22F, FontStyle.Bold);
            lblCampusOneDigitalAcademy.Location = new Point(20, 20);
            lblCampusOneDigitalAcademy.Name = "lblCampusOneDigitalAcademy";
            lblCampusOneDigitalAcademy.Size = new Size(821, 50);
            lblCampusOneDigitalAcademy.TabIndex = 0;
            lblCampusOneDigitalAcademy.Text = "Campus One Digital Academy";
            lblCampusOneDigitalAcademy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpStudentRegistration
            // 
            grpStudentRegistration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpStudentRegistration.Controls.Add(linkExit);
            grpStudentRegistration.Controls.Add(btnDelete);
            grpStudentRegistration.Controls.Add(lblRegNo);
            grpStudentRegistration.Controls.Add(btnClear);
            grpStudentRegistration.Controls.Add(cmbRegNo);
            grpStudentRegistration.Controls.Add(btnUpdate);
            grpStudentRegistration.Controls.Add(grpParentDetails);
            grpStudentRegistration.Controls.Add(btnRegister);
            grpStudentRegistration.Controls.Add(grpContactDetails);
            grpStudentRegistration.Controls.Add(grpBasicDetails);
            grpStudentRegistration.Location = new Point(34, 91);
            grpStudentRegistration.Name = "grpStudentRegistration";
            grpStudentRegistration.Size = new Size(804, 950);
            grpStudentRegistration.TabIndex = 0;
            grpStudentRegistration.TabStop = false;
            grpStudentRegistration.Text = "Student Registration";
            // 
            // linkExit
            // 
            linkExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkExit.AutoSize = true;
            linkExit.Location = new Point(732, 927);
            linkExit.Name = "linkExit";
            linkExit.Size = new Size(33, 20);
            linkExit.TabIndex = 7;
            linkExit.TabStop = true;
            linkExit.Text = "Exit";
            linkExit.LinkClicked += linkExit_LinkClicked;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(671, 898);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblRegNo
            // 
            lblRegNo.AutoSize = true;
            lblRegNo.Location = new Point(58, 50);
            lblRegNo.Name = "lblRegNo";
            lblRegNo.Size = new Size(59, 20);
            lblRegNo.TabIndex = 4;
            lblRegNo.Text = "Reg No";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Location = new Point(556, 898);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cmbRegNo
            // 
            cmbRegNo.FormattingEnabled = true;
            cmbRegNo.Location = new Point(184, 50);
            cmbRegNo.Name = "cmbRegNo";
            cmbRegNo.Size = new Size(151, 28);
            cmbRegNo.TabIndex = 3;
            cmbRegNo.Click += cmbRegNo_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(153, 898);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // grpParentDetails
            // 
            grpParentDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpParentDetails.Controls.Add(txtNIC);
            grpParentDetails.Controls.Add(txtContact);
            grpParentDetails.Controls.Add(lblContact);
            grpParentDetails.Controls.Add(lblParentName);
            grpParentDetails.Controls.Add(lblNIC);
            grpParentDetails.Controls.Add(txtParentName);
            grpParentDetails.Location = new Point(30, 711);
            grpParentDetails.Name = "grpParentDetails";
            grpParentDetails.Size = new Size(735, 179);
            grpParentDetails.TabIndex = 2;
            grpParentDetails.TabStop = false;
            grpParentDetails.Text = "Parent Details";
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(154, 93);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(125, 27);
            txtNIC.TabIndex = 2;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(154, 133);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(125, 27);
            txtContact.TabIndex = 3;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(28, 136);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(118, 20);
            lblContact.TabIndex = 6;
            lblContact.Text = "Contact Number";
            // 
            // lblParentName
            // 
            lblParentName.AutoSize = true;
            lblParentName.Location = new Point(28, 51);
            lblParentName.Name = "lblParentName";
            lblParentName.Size = new Size(94, 20);
            lblParentName.TabIndex = 4;
            lblParentName.Text = "Parent Name";
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.Location = new Point(28, 96);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(33, 20);
            lblNIC.TabIndex = 5;
            lblNIC.Text = "NIC";
            // 
            // txtParentName
            // 
            txtParentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtParentName.Location = new Point(154, 44);
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(443, 27);
            txtParentName.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(30, 898);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // grpContactDetails
            // 
            grpContactDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpContactDetails.Controls.Add(txtHome);
            grpContactDetails.Controls.Add(txtMobile);
            grpContactDetails.Controls.Add(txtEmail);
            grpContactDetails.Controls.Add(txtAddress);
            grpContactDetails.Controls.Add(lblHome);
            grpContactDetails.Controls.Add(lblAddress);
            grpContactDetails.Controls.Add(lblMobile);
            grpContactDetails.Controls.Add(lblEmail);
            grpContactDetails.Location = new Point(30, 418);
            grpContactDetails.Name = "grpContactDetails";
            grpContactDetails.Size = new Size(735, 278);
            grpContactDetails.TabIndex = 1;
            grpContactDetails.TabStop = false;
            grpContactDetails.Text = "Contact Details";
            // 
            // txtHome
            // 
            txtHome.Location = new Point(454, 242);
            txtHome.Name = "txtHome";
            txtHome.Size = new Size(131, 27);
            txtHome.TabIndex = 1;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(154, 235);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(125, 27);
            txtMobile.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(154, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(443, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(154, 58);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(443, 71);
            txtAddress.TabIndex = 1;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Location = new Point(329, 242);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(95, 20);
            lblHome.TabIndex = 4;
            lblHome.Text = "Home Phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(28, 61);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Location = new Point(28, 238);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(101, 20);
            lblMobile.TabIndex = 3;
            lblMobile.Text = "Mobile Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(28, 162);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // grpBasicDetails
            // 
            grpBasicDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBasicDetails.Controls.Add(rbFemale);
            grpBasicDetails.Controls.Add(dtpDOB);
            grpBasicDetails.Controls.Add(rbMale);
            grpBasicDetails.Controls.Add(txtLastName);
            grpBasicDetails.Controls.Add(lblGender);
            grpBasicDetails.Controls.Add(txtFirstName);
            grpBasicDetails.Controls.Add(lblFirstName);
            grpBasicDetails.Controls.Add(lblDOB);
            grpBasicDetails.Controls.Add(lblLastName);
            grpBasicDetails.Location = new Point(30, 115);
            grpBasicDetails.Name = "grpBasicDetails";
            grpBasicDetails.Size = new Size(735, 270);
            grpBasicDetails.TabIndex = 0;
            grpBasicDetails.TabStop = false;
            grpBasicDetails.Text = "Basic Details";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(267, 226);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 2;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(154, 171);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 1;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(154, 226);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 1;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(154, 112);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(443, 27);
            txtLastName.TabIndex = 2;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(28, 226);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(154, 54);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(443, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(28, 61);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(28, 171);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(94, 20);
            lblDOB.TabIndex = 3;
            lblDOB.Text = "Date of Birth";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(28, 115);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 666);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(850, 700);
            Name = "Registration";
            Padding = new Padding(0, 10, 0, 10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration - Campus One Digital Academy";
            WindowState = FormWindowState.Maximized;
            Load += Registration_Load;
            Resize += Registration_Resize;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            grpStudentRegistration.ResumeLayout(false);
            grpStudentRegistration.PerformLayout();
            grpParentDetails.ResumeLayout(false);
            grpParentDetails.PerformLayout();
            grpContactDetails.ResumeLayout(false);
            grpContactDetails.PerformLayout();
            grpBasicDetails.ResumeLayout(false);
            grpBasicDetails.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox grpStudentRegistration;
        private GroupBox grpBasicDetails;
        private GroupBox grpParentDetails;
        private GroupBox grpContactDetails;
        private Label lblRegNo;
        private ComboBox cmbRegNo;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDOB;
        private Label lblGender;
        private RadioButton rbFemale;
        private DateTimePicker dtpDOB;
        private RadioButton rbMale;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label lblHome;
        private Label lblAddress;
        private Label lblMobile;
        private Label lblEmail;
        private TextBox txtNIC;
        private TextBox txtContact;
        private Label lblContact;
        private Label lblParentName;
        private Label lblNIC;
        private TextBox txtParentName;
        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnRegister;
        private TextBox txtHome;
        private Label lblCampusOneDigitalAcademy;
        private Panel mainPanel;
        private LinkLabel linkLogout;
        private LinkLabel linkExit;
        private Panel panel1;
    }
}