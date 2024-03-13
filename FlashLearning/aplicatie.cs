using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FlashLearning
{
    public partial class aplicatie : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string qs;
        int left, right, counter = -1, max_fr = 0;

        public aplicatie()
        {
            InitializeComponent();
        }

        // Utils:

        // Function for initializing the counter variable
        private void initialize_counter()
        {
            try
            {
                if (account.nu != string.Empty)
                {
                    qs = "SELECT MIN(Id) FROM FL WHERE Utilizator = '" + account.nu + "' AND Frecventa!=0";
                    cmd = new SqlCommand(qs, con);
                    left = (int)(cmd.ExecuteScalar());
                    qs = "SELECT MAX(Id) FROM FL WHERE Utilizator = '" + account.nu + "' AND Frecventa!=0";
                    cmd = new SqlCommand(qs, con);
                    right = (int)(cmd.ExecuteScalar());
                    counter = left;
                    start_learning.Enabled = true;
                }
                // If you're not connected to your account:
                else
                {
                    MessageBox.Show("Log into your account before starting the learning process!");
                }
            }
            catch
            {
                start_learning.Enabled = false;
                MessageBox.Show("You have no questions in the database!");
                restart_interface();
            }
        }

        // Function for checking the existence of the ID with the counter value
        private bool exista_id(int i)
        {
            qs = "SELECT Intrebare FROM FL WHERE Utilizator = '" + account.nu + "' AND Id = '" + i;
            cmd = new SqlCommand(qs, con);
            string aux = (string)cmd.ExecuteScalar();
            if (aux != string.Empty)
                return true;
            else
                return false;
        }

        // Search for the smallest ID greater than the last one
        // Function for generating the next values ​​of the counter variable.
        private void increase_counter()
        {
            calculate_max_fr();
            if (counter == right)
                initialize_counter();
            else if (counter != -1)
            {
                qs = "SELECT MIN(Id) FROM FL WHERE Utilizator = '" + account.nu + "' AND Id>" + counter + "AND Id<=" + right;
                cmd = new SqlCommand(qs, con);
                counter = (int)cmd.ExecuteScalar();
            }

        }

        // Display the question with the counter ID if it has the same user as the one connected.
        private void print_next_question()
        {
            qs = "SELECT Frecventa FROM FL WHERE Id= " + counter;
            cmd = new SqlCommand(qs, con);
            int fr = Convert.ToInt32(cmd.ExecuteScalar());
            qs = "SELECT Intrebare FROM FL WHERE Id = " + counter;
            cmd = new SqlCommand(qs, con);
            question_text.Text = (string)cmd.ExecuteScalar();
            answer_text.Text = "Scrie aici raspunsul";
        }

        // calculeaza noua frecventa maxima a intrebarii 

        private void calculate_max_fr()
        {
            if (counter == -1)
            {
                start_learning.Enabled = false;
                restart_interface();
                return;
            }
            try
            {
                qs = "SELECT MAX(Frecventa) FROM FL WHERE Utilizator = '" + account.nu + "'";
                cmd = new SqlCommand(qs, con);
                max_fr = (int)cmd.ExecuteScalar();
            }
            catch
            {
                max_fr = 0;
                counter = -1;
            }
            if (max_fr == 0)
            {
                MessageBox.Show("Congratulations! You have completed the learning process.");
                start_learning.Enabled = false;
                restart_interface();
            }
        }
        private void restart_interface()
        {
            question_text.Text = "Are you ready for a new smart learning session?";
            answer_text.Enabled = false;
            answer_text.Visible = false;
            check.Enabled = false;
            delete_question.Enabled = false;
            check.Visible = false;
            go_forward.Visible = false;
            delete_question.Visible = false;
            if (account.nu != string.Empty && counter != -1)
                start_learning.Enabled = true;
        }

        private void delete_current_question()
        {
            qs = "DELETE FROM FL WHERE Id = " + counter;
            cmd = new SqlCommand(qs, con);
            cmd.ExecuteNonQuery();
            question_text.Text = string.Empty;
            answer_text.Visible = false;
            answer_text.Enabled = false;
            answer_text.Text = "Write your answer here";
            check.Enabled = false;
            delete_question.Enabled = false;
            go_forward.Enabled = true;
        }

        // End of utils

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Apps\FlashLearning\FlashLearning\FlashLearningDataBase.mdf;Integrated Security=True");
            con.Open();
        }

        private void add_new_item_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Visuals
            answer_text.Enabled = true;
            answer_text.Visible = true;
            question_text.Text = string.Empty;
            answer_text.Text = "Write your answer here";
            check.Enabled = true;
            delete_question.Enabled = true;
            check.Visible = true;
            go_forward.Visible = true;
            delete_question.Visible = true;
            start_learning.Enabled = false;

            // Print the first question
            initialize_counter();
            calculate_max_fr();
            if (max_fr > 0)
                print_next_question();
            else
            {
                start_learning.Enabled = false;
                MessageBox.Show("There are no question inside the database!");
                restart_interface();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void meniu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answer_text.Text != "Write your answer here" && answer_text.Text != string.Empty)
            {
                qs = "SELECT Raspuns FROM FL WHERE Id = " + counter;
                cmd = new SqlCommand(qs, con);
                string answer = (string)cmd.ExecuteScalar();
                if (answer == answer_text.Text)
                {
                    MessageBox.Show("That is the correct answer!");
                    check.Enabled = false;
                    answer_text.Enabled = false;
                    // Decrease the frequency of the question
                    qs = "UPDATE FL SET Frecventa = Frecventa-1 WHERE Id = " + counter;
                    cmd = new SqlCommand(qs, con);
                    cmd.ExecuteNonQuery();
                    qs = "SELECT Frecventa FROM FL WHERE Id =" + counter;
                    cmd = new SqlCommand(qs, con);
                    int aux = (int)cmd.ExecuteScalar();
                    if (aux == 0)
                        delete_current_question();
                }
                else
                {
                    MessageBox.Show("Wrong answer!");
                    answer_text.Text = "The correct answer is: " + answer;
                    answer_text.Enabled = false;
                    // Increasing the frequence of the question
                    qs = "UPDATE FL SET Frecventa = Frecventa+1 WHERE Id = " + counter;
                    cmd = new SqlCommand(qs, con);
                    cmd.ExecuteNonQuery();
                    qs = "SELECT Frecventa FROM FL WHERE Id =" + counter;
                    cmd = new SqlCommand(qs, con);
                }
                check.Enabled = false;
                go_forward.Enabled = true;
            }
            else
            {
                MessageBox.Show("You didn't write a response!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            increase_counter();
            print_next_question();
            answer_text.Visible = true;
            answer_text.Enabled = true;
            question_text.Visible = true;
            check.Enabled = true;
            delete_question.Enabled = true;

            go_forward.Enabled = false;
        }

        private void enter_account_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account form = new account();
            form.ShowDialog();
            if (account.nu != string.Empty)
            {
                label1.Text = account.nu;
                enter_account.Enabled = false;
                add_a_flashcard.Enabled = true;
                exit_account.Enabled = true;
                restart_interface();
                initialize_counter();
                calculate_max_fr();
            }
        }

        private void exit_account_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = -1;
            account.nu = string.Empty;
            label1.Text = string.Empty;
            enter_account.Enabled = true;
            start_learning.Enabled = false;
            add_a_flashcard.Enabled = false;
            exit_account.Enabled = false;
            restart_interface();
            max_fr = 0;
        }

        private void stergeIntrebarea_Click(object sender, EventArgs e)
        {

        }

        private void stergeIntrebarea_Click_1(object sender, EventArgs e)
        {
            delete_current_question();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void question_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e)
        {
            help formular = new help();
            formular.ShowDialog();
            restart_interface();
        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adaugaUnFlashcardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            add_a_question formular = new add_a_question();
            formular.ShowDialog();
            initialize_counter();
            restart_interface();
            calculate_max_fr();
        }
    }
}
