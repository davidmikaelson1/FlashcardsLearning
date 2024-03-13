using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace FlashLearning
{
    public partial class cont : Form
    {
        public static string nu = string.Empty;
        SqlConnection con;
        SqlCommand cmd;
        string qs;
        public cont()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\caval\OneDrive\Desktop\FlashLearning\FlashLearning\FlashLearningDataBase.mdf;Integrated Security=True");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lipsa nume de utilizator
            if(textNumeUtilizator.Text == string.Empty)
            {
                MessageBox.Show("Introdu numele de utilizator!");
                return;
            }


            // nume de utilizator introdus
            if(parola.Enabled == false)
            {
                string aux = textNumeUtilizator.Text;
                qs = "SELECT COUNT(Id) FROM utilizatori WHERE NumeUtilizator = '" + aux +"'";
                cmd = new SqlCommand(qs, con);
                int nr = (int)cmd.ExecuteScalar();
                if (nr!=0)
                {
                    parola.Enabled = true;
                    textParola.Enabled = true;
                    parola.Visible = true;
                    textParola.Visible = true;
                    textNumeUtilizator.Enabled = false;
                }
                else
                {
                    parola.Enabled = true;
                    textParola.Enabled = true;
                    parola.Visible = true;
                    textParola.Visible = true;
                    confirmaParola.Enabled = true;
                    textConfirmaParola.Enabled = true;
                    confirmaParola.Visible = true;
                    textConfirmaParola.Visible = true;
                    textNumeUtilizator.Enabled = false;
                    IntraInCont.Text = "Creare cont";
                }
                return;
            }

            // parola lipsa
            if (textParola.Text == string.Empty)
            {
                MessageBox.Show("Introdu parola!");
                return;
            }

            // intra in cont
            if(confirmaParola.Enabled == false)
            {
                string aux = textNumeUtilizator.Text;
                qs = "SELECT Parola FROM utilizatori WHERE NumeUtilizator = '" + aux + "'";
                cmd = new SqlCommand(qs, con);
                string parola = (string)cmd.ExecuteScalar();
                if(parola == textParola.Text)
                {
                    nu = textNumeUtilizator.Text;
                    MessageBox.Show("Bine ai revenit " + textNumeUtilizator.Text + "!");
                    this.Close();
                }

                // parola gresita
                else
                {
                    MessageBox.Show("Parola incorecta");
                    textParola.Text = string.Empty;
                }
                return;
            }

            // lipsa confirmare parola
            if (textConfirmaParola.Text == string.Empty)
            {
                MessageBox.Show("Confirma parola!");
                return;
            }

            // parola si confirma parola sunt diferite
            if (textParola.Text != textConfirmaParola.Text)
            {
                MessageBox.Show("Cele doua parole difera!");
                return;
            }

            // creare cont
            
            qs = "INSERT INTO utilizatori(NumeUtilizator, Parola)VALUES ('"+textNumeUtilizator.Text+ "', '"+textParola.Text+ "')";
            cmd = new SqlCommand(qs, con);
            int ok = cmd.ExecuteNonQuery();
            
            if (ok != 0)
            {
                nu = textNumeUtilizator.Text;
                MessageBox.Show("Cont creat!");
                this.Close();
            }            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
