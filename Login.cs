using Microsoft.Data.SqlClient;

namespace StudentRegistrationSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlConnection con = new SqlConnection(
                @"Data Source=MSI;
                Initial Catalog=Student;
                Integrated Security=True;
                TrustServerCertificate=True");

            con.Open();

            string query = "SELECT COUNT(*) FROM Logins WHERE username=@u AND password=@p";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);

            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                Registration reg = new Registration();
                reg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Login Credentials, please check Username and Password and try again",
                    "Invalid Login Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
}