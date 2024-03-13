using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlashLearning
{
    public partial class add_a_question : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string qs;

        public add_a_question()
        {
            InitializeComponent();
        }

        private void form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Apps\FlashLearning\FlashLearning\FlashLearningDataBase.mdf;Integrated Security=True");
            con.Open();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIntrebare.Text) || string.IsNullOrEmpty(textRaspuns.Text) || textIntrebare.Text == "Scrie aici intrebarea" || textRaspuns.Text == "Scrie aici raspunsul")
                MessageBox.Show("Missing data!");
            else
            {
                qs = "INSERT INTO FL(Intrebare, Raspuns, Utilizator, Frecventa) VALUES('" + textIntrebare.Text + "', '" + textRaspuns.Text + "', '" + account.nu + "', 2)";
                cmd = new SqlCommand(qs, con);
                int ok = cmd.ExecuteNonQuery();
                if (ok != 0)
                {
                    MessageBox.Show("Question saved!");
                    textIntrebare.Text = "Write here your question";
                    textRaspuns.Text = "Write here the correct answer";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
