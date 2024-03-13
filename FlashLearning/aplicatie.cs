using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FlashLearning
{
    public partial class aplicatie : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string qs;
        int st, dr, contor=-1, frmax=0;

        public aplicatie()
        {
            InitializeComponent();
        }
        // functie pentru initializarea variabilei contor
        private void initializeaza_contor()
        {
            try
            {
                if(cont.nu != string.Empty)
                {
                    qs = "SELECT MIN(Id) FROM FL WHERE Utilizator = '" + cont.nu + "' AND Frecventa!=0";
                    cmd = new SqlCommand(qs, con);
                    st = (int)(cmd.ExecuteScalar());
                    qs = "SELECT MAX(Id) FROM FL WHERE Utilizator = '" + cont.nu + "' AND Frecventa!=0";
                    cmd = new SqlCommand(qs, con);
                    dr = (int)(cmd.ExecuteScalar());
                    contor = st;
                    incepeSaInveti.Enabled = true;
                }
                // daca nu esti conectat
                else
                {
                    MessageBox.Show("Intra in contul tau inainte de a incepe procesul de invatare!");
                }
            }
            catch
            {
                incepeSaInveti.Enabled = false;
                MessageBox.Show("Nu ai intrebari in baze de date!");
                restart_interfata();
            }
        }

        // functie pentru verificarea existentei id-ului cu valoarea contor
        private bool exista_id(int i)
        {
            qs = "SELECT Intrebare FROM FL WHERE Utilizator = '" + cont.nu + "' AND Id = '" + i ;
            cmd = new SqlCommand(qs, con);
            string aux= (string)cmd.ExecuteScalar();
            if(aux!=string.Empty)
                return true;
            else
                return false;
        }

        // cauta cel mai mic id mai mare decat ultimul
        // functie pentru generarea urmatorii valori a variabilei contor
        private void creste_contor()
        {
            calculeaza_frmax();
            if(contor==dr)
                initializeaza_contor();
            else if(contor!=-1)
            {
                qs = "SELECT MIN(Id) FROM FL WHERE Utilizator = '" + cont.nu + "' AND Id>" + contor + "AND Id<="+ dr;
                cmd = new SqlCommand(qs, con);
                contor = (int)cmd.ExecuteScalar();
            }
            
        }

        // afiseaza intrebarea cu id-ul contor, daca aceasta are acelasi user ca cel conectat
        private void afisare()
        {
            qs = "SELECT Frecventa FROM FL WHERE Id= " + contor;
            cmd = new SqlCommand(qs, con);
            int fr= Convert.ToInt32(cmd.ExecuteScalar());
            /*
            if(fr==0)
            {
                MessageBox.Show("Felicitari! Ai finalizat procesul de invatare.");
                restart_interfata();
                incepeSaInveti.Enabled = false;
                return;
            }*/
            qs = "SELECT Intrebare FROM FL WHERE Id = " + contor;
            cmd = new SqlCommand(qs, con);
            textIntrebare.Text = (string)cmd.ExecuteScalar();
            textRaspuns.Text = "Scrie aici raspunsul";
        }

        // calculeaza noua frecventa maxima a intrebarii 
        
        private void calculeaza_frmax()
        {
            if(contor==-1)
            {
                incepeSaInveti.Enabled = false;
                restart_interfata();
                return;
            }
            try
            {
                qs = "SELECT MAX(Frecventa) FROM FL WHERE Utilizator = '" + cont.nu + "'";
                cmd = new SqlCommand (qs, con);
                frmax = (int)cmd.ExecuteScalar();
            }
            catch
            {
                frmax = 0;
                contor = -1;
            }
            if (frmax == 0)
            {
                MessageBox.Show("Felicitari! Ai finalizat procesul de invatare.");
                incepeSaInveti.Enabled = false;
                restart_interfata();
            }
        }
        //aduce interfata programului la starea initiala dar pastreaza contul utilizatorului
        private void restart_interfata()
        {
            textIntrebare.Text = "Esti gata pentru o noua sesiune de invatare inteligenta?";
            textRaspuns.Enabled = false;
            textRaspuns.Visible = false;
            verifica.Enabled = false;
            stergeIntrebarea.Enabled = false;
            verifica.Visible = false;
            maiDeparte.Visible = false;
            stergeIntrebarea.Visible = false;
            if(cont.nu != string.Empty && contor!=-1)
                incepeSaInveti.Enabled = true;
        }
        // sterge intrebarea curenta
        private void sterge()
        {
            qs = "DELETE FROM FL WHERE Id = " + contor;
            cmd = new SqlCommand(qs, con);
            cmd.ExecuteNonQuery();
            textIntrebare.Text = string.Empty;
            textRaspuns.Visible = false;
            textRaspuns.Enabled = false;
            textRaspuns.Text = "Scrie aici raspunsul tau";
            verifica.Enabled = false;
            stergeIntrebarea.Enabled = false;
            maiDeparte.Enabled = true;
        }
        // sfarsit functii ajutatoare

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\caval\OneDrive\Desktop\FlashLearning\FlashLearning\FlashLearningDataBase.mdf;Integrated Security=True");
            con.Open();
        }

        private void adaugaUnFlashcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instructiuni vizuale
            textRaspuns.Enabled = true;
            textRaspuns.Visible = true;
            textIntrebare.Text = string.Empty;
            textRaspuns.Text = "Scrie aici raspunsul";
            verifica.Enabled = true;
            stergeIntrebarea.Enabled = true;
            verifica.Visible = true;
            maiDeparte.Visible = true;
            stergeIntrebarea.Visible = true;
            incepeSaInveti.Enabled = false;

            // afiseaza prima intrebare 
            initializeaza_contor();
            calculeaza_frmax();
            if(frmax>0)
                afisare();
            else
            {
                incepeSaInveti.Enabled = false;
                MessageBox.Show("Nu ai intrebari in baze de date!");
                restart_interfata();
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
            if(textRaspuns.Text != "Scrie aici raspunsul" && textRaspuns.Text != string.Empty)
            {
                qs = "SELECT Raspuns FROM FL WHERE Id = " + contor;
                cmd = new SqlCommand(qs, con);
                string rasp = (string)cmd.ExecuteScalar();
                if (rasp == textRaspuns.Text)
                {
                    MessageBox.Show("Raspuns corect!");
                    verifica.Enabled = false;
                    textRaspuns.Enabled = false;
                    // decremenatam frecventa
                    qs = "UPDATE FL SET Frecventa = Frecventa-1 WHERE Id = " + contor;
                    cmd = new SqlCommand(qs, con);
                    cmd.ExecuteNonQuery();
                    qs = "SELECT Frecventa FROM FL WHERE Id =" + contor;
                    cmd = new SqlCommand(qs, con);
                    int aux = (int)cmd.ExecuteScalar();
                    if (aux == 0)
                        sterge();
                }
                else
                {
                    MessageBox.Show("Raspuns gresit!");
                    textRaspuns.Text = "Raspunsul corect este: " + rasp;
                    textRaspuns.Enabled = false;
                    // incrementam frecventa
                    qs = "UPDATE FL SET Frecventa = Frecventa+1 WHERE Id = " + contor;
                    cmd = new SqlCommand(qs, con);
                    cmd.ExecuteNonQuery();
                    qs = "SELECT Frecventa FROM FL WHERE Id =" + contor;
                    cmd = new SqlCommand(qs, con);
                }
                verifica.Enabled = false;
                maiDeparte.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nu ai introdus raspunsul!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creste_contor();
            afisare();
            textRaspuns.Visible = true;
            textRaspuns.Enabled = true;
            textIntrebare.Visible = true;
            verifica.Enabled = true;
            stergeIntrebarea.Enabled = true;

            maiDeparte.Enabled = false;
        }

        private void intraInContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont formular = new cont();
            formular.ShowDialog();
            if (cont.nu != string.Empty)
            {
                label1.Text = cont.nu;
                intraInCont.Enabled = false;
                adaugaUnFlashcard.Enabled = true;
                iesiDinCont.Enabled = true;
                restart_interfata();
                initializeaza_contor();
                calculeaza_frmax();
            }
        }

        private void iesiDinContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contor = -1;
            cont.nu = string.Empty;
            label1.Text = string.Empty;
            intraInCont.Enabled = true;
            incepeSaInveti.Enabled = false;
            adaugaUnFlashcard.Enabled = false;
            iesiDinCont.Enabled = false;
            restart_interfata();
            frmax = 0;
        }

        private void stergeIntrebarea_Click(object sender, EventArgs e)
        {

        }

        private void stergeIntrebarea_Click_1(object sender, EventArgs e)
        {
            sterge();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajutor_Click(object sender, EventArgs e)
        {
            ajutor formular = new ajutor();
            formular.ShowDialog();
            restart_interfata();
        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adaugaUnFlashcardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adaugare formular = new adaugare();
            formular.ShowDialog();
            initializeaza_contor();
            restart_interfata();
            calculeaza_frmax();
            
        }
    }
}
