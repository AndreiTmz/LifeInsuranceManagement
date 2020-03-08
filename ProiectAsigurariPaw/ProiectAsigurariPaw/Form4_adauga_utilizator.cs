using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAsigurariPaw
{
    public partial class Form4_adauga_utilizator : Form
    {
        Form2_Clienti frm_clienti;
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = asigurari.accdb";
        public Form4_adauga_utilizator(Form2_Clienti frm)
        {
            frm_clienti = frm;
            InitializeComponent();
        }

        void insertUser(Utilizator u)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                int nrUseri = 0;
                OleDbCommand checkUniqueUser = new OleDbCommand("SELECT username FROM utilizatori WHERE username='"+u.User+"'",conexiune);
                OleDbDataReader readUsers = checkUniqueUser.ExecuteReader();
                while(readUsers.Read())
                {
                    nrUseri++;
                }

                if (nrUseri > 0)
                {
                    MessageBox.Show("Exista deja un utilizator cu acest username!");
                }
                else
                {
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT MAX(cod_agent) FROM utilizatori";
                    int cod_user = Convert.ToInt32(comanda.ExecuteScalar());
                    cod_user++;

                    u.Cod = cod_user;

                    comanda.CommandText = "INSERT INTO utilizatori VALUES(?,?,?,?,?,?,?,?,?)";
                    comanda.Parameters.Add("cod_agent", OleDbType.Integer).Value = u.Cod;
                    comanda.Parameters.Add("nume", OleDbType.Char, 30).Value = u.Nume;
                    comanda.Parameters.Add("prenume", OleDbType.Char, 30).Value = u.Prenume;
                    comanda.Parameters.Add("username", OleDbType.Char, 30).Value = u.User;
                    comanda.Parameters.Add("parola", OleDbType.Char, 30).Value = u.Parola;
                    comanda.Parameters.Add("email", OleDbType.Char, 50).Value = u.Email;
                    comanda.Parameters.Add("telefon", OleDbType.Char, 10).Value = u.Telefon;
                    comanda.Parameters.Add("adresa", OleDbType.Char, 50).Value = u.Adresa;
                    comanda.Parameters.Add("admin", OleDbType.Char, 2).Value = "nu";

                    comanda.ExecuteNonQuery();

                    MessageBox.Show("Utilizator nou adaugat cu succes!");
                    this.Close();
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
            try
            {
                bool error = false;
                if (tbNume.Text == "")
                {
                    errorProvider1.SetError(tbNume, "Introduceti nume");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbNume,"");
                }
                if (tbPrenume.Text == "")
                {
                    errorProvider1.SetError(tbPrenume, "Introduceti prenume");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbPrenume, "");
                }
                if (tbUser.Text == "")
                {
                    errorProvider1.SetError(tbUser, "Introduceti username");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbUser,"");
                }
                if (tbPass.Text == "" || tbPass.Text.ToString().Length < 5)
                {
                    errorProvider1.SetError(tbPass, "Minim 5 caractere");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbPass,"");
                }
                if (tbEmail.Text == "")
                {
                    errorProvider1.SetError(tbEmail, "Introduceti email");
                    error = true;
                }
                else if(!IsValidEmail(tbEmail.Text))
                {
                    errorProvider1.SetError(tbEmail,"Email invalid");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbEmail,"");
                }
                if (tbTel.Text == "")
                {
                    errorProvider1.SetError(tbTel, "Introduceti nr telefon");
                    error = true;
                }
                else if(tbTel.Text.Length != 10)
                {
                    errorProvider1.SetError(tbTel,"10 caractere!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbTel, "");
                }
                if (tbAdresa.Text == "")
                {
                    errorProvider1.SetError(tbAdresa, "Introducdti adresa");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbAdresa, "");
                }

                if(!error)
                {

                    string nume = tbNume.Text;
                    string prenume = tbPrenume.Text;
                    string user = tbUser.Text;
                    string parola = tbPass.Text;
                    string email = tbEmail.Text;
                    string telefon = tbTel.Text;
                    string adresa = tbAdresa.Text;

                    Utilizator u = new Utilizator(0, nume, prenume, user, parola, email, telefon, adresa, "-", null);

                    insertUser(u);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form4_adauga_utilizator_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_clienti.Show();
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar >= 'a' && e.KeyChar <= 'z'
               || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void tbTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void tbNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }
    }       
}

