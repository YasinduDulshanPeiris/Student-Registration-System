using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentRegistrationSystem
{
    public partial class Registration : Form
    {
        // Centralized Connection String
        private readonly string connectionString =
            @"Data Source=MSI;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True";

        public Registration()
        {
            InitializeComponent();
            this.AutoScroll = false;

            cmbRegNo.DropDownStyle = ComboBoxStyle.DropDown;

            cmbRegNo.SelectedIndexChanged += cmbRegNo_SelectedIndexChanged;
            cmbRegNo.TextChanged += cmbRegNo_TextChanged;   // ADD THIS
            cmbRegNo.Leave += cmbRegNo_Leave;
            cmbRegNo.KeyDown += cmbRegNo_KeyDown;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            LoadRegNo();
            CenterGroupBox();
            cmbRegNo.SelectedIndex = -1;
            ClearFields(); // Start fresh
        }

        private void Registration_Resize(object sender, EventArgs e)
        {
            CenterGroupBox();

            // Make title always stretch properly
            lblCampusOneDigitalAcademy.Left = 20;
            lblCampusOneDigitalAcademy.Width = mainPanel.ClientSize.Width - 40;




        }

        private void CenterGroupBox()
        {
            grpStudentRegistration.Left =
                (mainPanel.ClientSize.Width - grpStudentRegistration.Width) / 2;
        }




        // ====================== HELPER METHODS ======================

        private void LoadRegNo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT regNo FROM Registration ORDER BY regNo", con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        cmbRegNo.Items.Clear();
                        while (dr.Read())
                        {
                            cmbRegNo.Items.Add(dr["regNo"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Registration Numbers: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtHome.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContact.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dtpDOB.Value = DateTime.Now;

            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Triggered when user selects from dropdown
            if (cmbRegNo.SelectedIndex >= 0)
            {
                LoadStudentByRegNo(cmbRegNo.Text.Trim());
            }
        }

        private void LoadStudentByRegNo(string regNo)
        {
            if (string.IsNullOrWhiteSpace(regNo))
            {
                ClearFields();
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM Registration WHERE regNo = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", regNo);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                // Fill fields
                                txtFirstName.Text = dr["firstName"].ToString();
                                txtLastName.Text = dr["lastName"].ToString();
                                txtAddress.Text = dr["address"].ToString();
                                txtEmail.Text = dr["email"].ToString();
                                txtMobile.Text = dr["mobilePhone"].ToString();
                                txtHome.Text = dr["homePhone"].ToString();
                                txtParentName.Text = dr["parentName"].ToString();
                                txtNIC.Text = dr["nic"].ToString();
                                txtContact.Text = dr["contactNo"].ToString();
                                dtpDOB.Value = Convert.ToDateTime(dr["dateOfBirth"]);

                                string gender = dr["gender"].ToString().Trim();
                                rbMale.Checked = gender == "Male";
                                rbFemale.Checked = gender == "Female";

                                btnRegister.Enabled = false;
                                btnUpdate.Enabled = true;
                                btnDelete.Enabled = true;
                            }
                            else
                            {
                                // **New Registration Number** → Clear fields
                                ClearFields();
                                btnRegister.Enabled = true;
                                btnUpdate.Enabled = false;

                                // Optional: Focus on first name for new entry
                                txtFirstName.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================== EVENTS ======================

        private void cmbRegNo_TextChanged(object sender, EventArgs e)
        {
            if (!cmbRegNo.Focused)
                return;

            string regNo = cmbRegNo.Text.Trim();

            // If textbox empty
            if (string.IsNullOrWhiteSpace(regNo))
            {
                ClearFields();
                return;
            }

            // Check whether typed regNo exists in ComboBox items
            bool exists = false;

            foreach (var item in cmbRegNo.Items)
            {
                if (item.ToString().Equals(regNo, StringComparison.OrdinalIgnoreCase))
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                // Existing student → autofill
                LoadStudentByRegNo(regNo);
            }
            else
            {
                // New regNo → immediately clear fields
                ClearFields();

                btnRegister.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        private void cmbRegNo_Leave(object sender, EventArgs e)
        {
            // Final check when user leaves the field (most reliable for typing)
            PerformRegNoLookup();
        }

        private void cmbRegNo_KeyDown(object sender, KeyEventArgs e)
        {
            // Allow pressing Enter to trigger lookup immediately
            if (e.KeyCode == Keys.Enter)
            {
                PerformRegNoLookup();
                e.Handled = true;
            }
        }

        private void PerformRegNoLookup()
        {
            string regNo = cmbRegNo.Text.Trim();

            if (string.IsNullOrWhiteSpace(regNo))
            {
                ClearFields();
                return;
            }

            LoadStudentByRegNo(regNo);
        }

        // ====================== BUTTON EVENTS ======================

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check if RegNo already exists
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Registration WHERE regNo=@regNo", con))
                    {
                        checkCmd.Parameters.AddWithValue("@regNo", cmbRegNo.Text.Trim());
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This student already exists!\nPlease use UPDATE instead.",
                                "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert New Record
                    string gender = rbMale.Checked ? "Male" : "Female";

                    string query = @"INSERT INTO Registration 
                        (regNo, firstName, lastName, dateOfBirth, gender, address, email, 
                         mobilePhone, homePhone, parentName, nic, contactNo) 
                        VALUES 
                        (@regNo,@fname,@lname,@dob,@gender,@address,@email,@mobile,@home,@parent,@nic,@contact)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        AddParameters(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record Added Successfully", "Register Student",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadRegNo();        // Refresh dropdown
                ClearFields();      // Clear form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check if record exists
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Registration WHERE regNo=@regNo", con))
                    {
                        checkCmd.Parameters.AddWithValue("@regNo", cmbRegNo.Text.Trim());
                        if ((int)checkCmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("Student not found! Please register first.",
                                "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string gender = rbMale.Checked ? "Male" : "Female";

                    string query = @"UPDATE Registration SET 
                        firstName=@fname, lastName=@lname, dateOfBirth=@dob, gender=@gender,
                        address=@address, email=@email, mobilePhone=@mobile, homePhone=@home,
                        parentName=@parent, nic=@nic, contactNo=@contact 
                        WHERE regNo=@regNo";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        AddParameters(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record Updated Successfully", "Update Student",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbRegNo.Text = "";
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbRegNo.Text))
            {
                MessageBox.Show("Please select a student to delete.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Confirmation Message
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Delete this Record...?",
                "Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand(
                            "DELETE FROM Registration WHERE regNo=@id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", cmbRegNo.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Success Message
                    MessageBox.Show(
                        "Record Deleted Successfully",
                        "Delete Student",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadRegNo();
                    cmbRegNo.Text = "";
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Delete failed: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // ====================== HELPER METHODS ======================

        private void AddParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@regNo", cmbRegNo.Text.Trim());
            cmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@lname", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
            cmd.Parameters.AddWithValue("@gender", rbMale.Checked ? "Male" : "Female");
            cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim());
            cmd.Parameters.AddWithValue("@home", txtHome.Text.Trim());
            cmd.Parameters.AddWithValue("@parent", txtParentName.Text.Trim());
            cmd.Parameters.AddWithValue("@nic", txtNIC.Text.Trim());
            cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(cmbRegNo.Text))
            {
                MessageBox.Show("Please enter Registration Number.", "Validation Error");
                return false;
            }



            return true;
        }

        // ====================== LINK LABELS ======================


        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?",
                                "Logout",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Close();        // Changed from Hide() to Close()
            }
        }
    }
}