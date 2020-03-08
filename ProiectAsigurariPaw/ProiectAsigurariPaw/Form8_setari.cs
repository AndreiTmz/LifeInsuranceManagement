using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAsigurariPaw
{
    public partial class Form8_setari : Form
    {
        Utilizator user;
        Form2_Clienti frm_clienti;
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = asigurari.accdb";
        
        public Form8_setari(Form2_Clienti frm,Utilizator u)
        {
            user = u;
            frm_clienti = frm;
            InitializeComponent();
            tbEmailVechi.Text = user.Email;
            tbTelVechi.Text = user.Telefon;
        }

        private void Form8_setari_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_clienti.Show();
           
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                bool error = false;

                if (tbEmailNou.Text == "")
                {
                    errorProvider1.SetError(tbEmailNou, "Introduceti email");
                    error = true;
                }
                else if (!IsValidEmail(tbEmailNou.Text))
                {
                    errorProvider1.SetError(tbEmailNou, "Email invalid");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbEmailNou, "");
                }
                if (!error)
                {
                    string emailNou = tbEmailNou.Text;
                    OleDbCommand updateEmail = new OleDbCommand("UPDATE utilizatori SET email = '" +
                        emailNou + "' WHERE email = '" + user.Email + "'", conexiune);
                    updateEmail.ExecuteNonQuery();

                    user.Email = emailNou;
                    MessageBox.Show("E-mail actualizat cu succes");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool error = false;

            if (tbTelNou.Text == "")
            {
                errorProvider1.SetError(tbTelNou, "Introduceti nr telefon");
                error = true;
            }
            else
            {
                errorProvider1.SetError(tbTelNou, "");
            }
            if (!error)
            {
                OleDbConnection conexiune = new OleDbConnection(connString);
                try
                {



                    string nrTelNou = tbTelNou.Text;
                    conexiune.Open();
                    OleDbCommand updateTel = new OleDbCommand("UPDATE utilizatori SET telefon = '" +
                        nrTelNou + "' WHERE telefon = '" + user.Telefon + "'", conexiune);
                    updateTel.ExecuteNonQuery();

                    user.Telefon = nrTelNou;
                    MessageBox.Show("Nr. de telefon actualizat cu succes");
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool error = false;
            if(tbParolaNoua.Text=="")
            {
                errorProvider1.SetError(tbParolaNoua, "Introduceti parola!");
                error = true;
            }
            else if(tbParolaNoua.Text.Length <5)
            {
                errorProvider1.SetError(tbParolaNoua, "Minim 5 caractere!");
                error = true;
            }
            else
            {
                errorProvider1.SetError(tbParolaNoua,"");
            }
            if (!error)
            {
                OleDbConnection conexiune = new OleDbConnection(connString);

                try
                {
                    string parolaNoua = tbParolaNoua.Text;
                    conexiune.Open();
                    OleDbCommand cautaParolaVeche = new OleDbCommand("SELECT parola FROM utilizatori WHERE " +
                        "parola = '" + tbParolaVeche.Text + "' AND username = '" + user.User + "'", conexiune);
                    OleDbDataReader reader = cautaParolaVeche.ExecuteReader();
                    int gasit = 0;
                    while (reader.Read())
                    {
                        gasit++;
                    }
                    if (gasit == 1)
                    {
                        OleDbCommand updatePass = new OleDbCommand("UPDATE utilizatori SET parola= '" +
                            parolaNoua + "' WHERE username = '" + user.User + "'", conexiune);
                        updatePass.ExecuteNonQuery();
                        user.Parola = parolaNoua;
                        MessageBox.Show("Parola a fost modificata!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Parola veche introdusa este gresita");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                }
            }
        }

       
    }
}
