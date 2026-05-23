namespace StudentRegistrationSystem
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Login));

            lblCampusOneDigitalAcademy = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpLogin = new GroupBox();
            campusOneLogo = new PictureBox();

            grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)campusOneLogo).BeginInit();
            SuspendLayout();

            // -------------------------------------------------
            // Form Settings
            // -------------------------------------------------

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            MinimumSize = new Size(700, 500);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;
            Text = "Login - Campus One Digital Academy";
            Icon = (Icon)resources.GetObject("$this.Icon");

            // -------------------------------------------------
            // Logo
            // -------------------------------------------------

            campusOneLogo.Image = Properties.Resources.download;
            campusOneLogo.Location = new Point(350, 20);
            campusOneLogo.Name = "campusOneLogo";
            campusOneLogo.Size = new Size(180, 110);
            campusOneLogo.SizeMode = PictureBoxSizeMode.Zoom;

            // Center top when resizing
            campusOneLogo.Anchor = AnchorStyles.Top;

            // -------------------------------------------------
            // Main Title
            // -------------------------------------------------

            lblCampusOneDigitalAcademy.AutoSize = true;
            lblCampusOneDigitalAcademy.Font =
                new Font("Times New Roman", 20F, FontStyle.Bold);

            lblCampusOneDigitalAcademy.Location = new Point(210, 145);
            lblCampusOneDigitalAcademy.Name = "lblCampusOneDigitalAcademy";
            lblCampusOneDigitalAcademy.Size = new Size(480, 38);
            lblCampusOneDigitalAcademy.Text =
                "Campus One Digital Academy";

            // Keep centered
            lblCampusOneDigitalAcademy.Anchor = AnchorStyles.Top;

            // -------------------------------------------------
            // GroupBox
            // -------------------------------------------------

            grpLogin.Text = "Login";
            grpLogin.Size = new Size(360, 220);
            grpLogin.Location = new Point(270, 220);

            // Center in form
            grpLogin.Anchor = AnchorStyles.None;

            // -------------------------------------------------
            // Username Label
            // -------------------------------------------------

            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(25, 50);
            lblUsername.Text = "Username";

            // -------------------------------------------------
            // Password Label
            // -------------------------------------------------

            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(25, 105);
            lblPassword.Text = "Password";

            // -------------------------------------------------
            // Username TextBox
            // -------------------------------------------------

            txtUsername.Location = new Point(120, 45);
            txtUsername.Size = new Size(200, 27);

            // -------------------------------------------------
            // Password TextBox
            // -------------------------------------------------

            txtPassword.Location = new Point(120, 100);
            txtPassword.Size = new Size(200, 27);
            txtPassword.UseSystemPasswordChar = true;

            // -------------------------------------------------
            // Clear Button
            // -------------------------------------------------

            btnClear.Location = new Point(40, 160);
            btnClear.Size = new Size(100, 35);
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;

            // -------------------------------------------------
            // Login Button
            // -------------------------------------------------

            btnLogin.Location = new Point(210, 160);
            btnLogin.Size = new Size(100, 35);
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;

            // -------------------------------------------------
            // Exit Button
            // -------------------------------------------------

            btnExit.Size = new Size(100, 35);
            btnExit.Location = new Point(770, 470);
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;

            // Stick to bottom-right
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // -------------------------------------------------
            // Add controls to GroupBox
            // -------------------------------------------------

            grpLogin.Controls.Add(lblUsername);
            grpLogin.Controls.Add(lblPassword);
            grpLogin.Controls.Add(txtUsername);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(btnClear);
            grpLogin.Controls.Add(btnLogin);

            // -------------------------------------------------
            // Add controls to Form
            // -------------------------------------------------

            Controls.Add(campusOneLogo);
            Controls.Add(lblCampusOneDigitalAcademy);
            Controls.Add(grpLogin);
            Controls.Add(btnExit);

            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)campusOneLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCampusOneDigitalAcademy;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClear;
        private Button btnExit;
        private GroupBox grpLogin;
        private PictureBox campusOneLogo;
    }
}