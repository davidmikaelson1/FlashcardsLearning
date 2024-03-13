using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlashLearning
{
    public partial class account : Form
    {
        public static string nu = string.Empty;
        SqlConnection con;
        SqlCommand cmd;
        string qs;
        public account()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Apps\FlashLearning\FlashLearning\FlashLearningDataBase.mdf;Integrated Security=True");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check the username
            if (username.Text == string.Empty)
            {
                MessageBox.Show("Enter your username!");
                return;
            }
            if (password.Enabled == false)
            {
                string aux = username.Text;
                qs = "SELECT COUNT(Id) FROM utilizatori WHERE NumeUtilizator = '" + aux + "'";
                cmd = new SqlCommand(qs, con);
                int nb = (int)cmd.ExecuteScalar();
                if (nb != 0)
                {
                    password.Enabled = true;
                    password_text.Enabled = true;
                    password.Visible = true;
                    password_text.Visible = true;
                    username.Enabled = false;
                }
                else
                {
                    password.Enabled = true;
                    password_text.Enabled = true;
                    password.Visible = true;
                    password_text.Visible = true;
                    reenter_password.Enabled = true;
                    reenter_password_text.Enabled = true;
                    reenter_password.Visible = true;
                    reenter_password_text.Visible = true;
                    username.Enabled = false;
                    log_in.Text = "Create account";
                }
                return;
            }

            // Missing password
            if (password_text.Text == string.Empty)
            {
                MessageBox.Show("Enter password!");
                return;
            }

            // Log in
            if (reenter_password.Enabled == false)
            {
                string aux = username.Text;
                qs = "SELECT Parola FROM utilizatori WHERE NumeUtilizator = '" + aux + "'";
                cmd = new SqlCommand(qs, con);
                string password = (string)cmd.ExecuteScalar();
                if (password == password_text.Text)
                {
                    nu = username.Text;
                    MessageBox.Show("Welcome " + username.Text + "!");
                    this.Close();
                }
                // Wrong password
                else
                {
                    MessageBox.Show("Wrong password!");
                    password_text.Text = string.Empty;
                }
                return;
            }
            if (reenter_password_text.Text == string.Empty)
            {
                MessageBox.Show("Reenter your password!");
                return;
            }
            if (password_text.Text != reenter_password_text.Text)
            {
                MessageBox.Show("The two password are different!");
                return;
            }

            // Create account
            qs = "INSERT INTO utilizatori(NumeUtilizator, Parola)VALUES ('" + username.Text + "', '" + password_text.Text + "')";
            cmd = new SqlCommand(qs, con);
            int ok = cmd.ExecuteNonQuery();
            if (ok != 0)
            {
                nu = username.Text;
                MessageBox.Show("Account created!");
                this.Close();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textConfirmaParola_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmaParola_Click(object sender, EventArgs e)
        {

        }
    }
}
