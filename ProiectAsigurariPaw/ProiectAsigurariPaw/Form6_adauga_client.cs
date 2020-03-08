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
using static ProiectAsigurariPaw.FormaJuridica;

namespace ProiectAsigurariPaw
{ 
    public partial class Form6_adauga_client : Form
    {
        Utilizator user;
        Form2_Clienti frm_clienti;
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = asigurari.accdb";

        public Form6_adauga_client(Utilizator u, Form2_Clienti frm)
        {
            user = u;
            frm_clienti = frm;
            InitializeComponent();
            listBox1.SelectedIndex = 0;

            foreach (string forma in Enum.GetNames(typeof(FormaJuridica.formaJuridica)))
            cbFormaJurPJ.Items.Add(forma);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem.ToString() == "Persoana fizica")
            {   //persoana fizica
                tbNumePF.Visible = true;
                tbPrenumePF.Visible = true;
                tbCNPPF.Visible = true;
                tbAdresaPF.Visible = true;
                tbNrTelPF.Visible = true;
                tbEmailPF.Visible = true;
                label1PF.Visible = true;
                label2PF.Visible = true;
                label3PF.Visible = true;
                label4PF.Visible = true;
                label5PF.Visible = true;
                label6PF.Visible=true;
                button1.Visible = true;

                //persoana juridica
                label1PJ.Visible = false;
                label2PJ.Visible = false;
                label3PJ.Visible = false;
                label4PJ.Visible = false;
                label5PJ.Visible = false;
                label6PJ.Visible = false;
                label7PJ.Visible = false;
                label8PJ.Visible = false;
                tbCUIPJ.Visible = false;
                tbNrRegComPJ.Visible = false;
                tbNumeFirmaPJ.Visible = false;
                cbFormaJurPJ.Visible = false;
                tbRepPJ.Visible = false;
                tbAdresaPJ.Visible = false;
                tbNrTelPJ.Visible = false;
                tbEmailPJ.Visible = false;
            }
            else
            {   //persoana fizica
                tbNumePF.Visible = false;
                tbPrenumePF.Visible = false;
                tbCNPPF.Visible = false;
                tbAdresaPF.Visible = false;
                tbNrTelPF.Visible = false;
                tbEmailPF.Visible = false;
                label1PF.Visible = false;
                label2PF.Visible = false;
                label3PF.Visible = false;
                label4PF.Visible = false;
                label5PF.Visible = false;
                label6PF.Visible = false;
                button1.Visible = true;

                //persoana juridica
                int x = tbNumePF.Location.X;
                tbCUIPJ.Location = new Point(x + 60,tbCUIPJ.Location.Y);
                tbNrRegComPJ.Location = new Point(x + 60, tbNrRegComPJ.Location.Y);
                tbNumeFirmaPJ.Location = new Point(x + 60, tbNumeFirmaPJ.Location.Y);
                cbFormaJurPJ.Location = new Point(x + 60, cbFormaJurPJ.Location.Y);
                tbRepPJ.Location = new Point(x + 60, tbRepPJ.Location.Y);
                tbAdresaPJ.Location = new Point(x + 60, tbAdresaPJ.Location.Y);
                tbNrTelPJ.Location = new Point(x + 60, tbNrTelPJ.Location.Y); ;
                tbEmailPJ.Location = new Point(x + 60, tbEmailPJ.Location.Y); ;

                label1PJ.Location = new Point(x - 40, tbCUIPJ.Location.Y);
                label2PJ.Location = new Point(x - 75, tbNrRegComPJ.Location.Y);
                label3PJ.Location = new Point(x - 75, tbNumeFirmaPJ.Location.Y);
                label4PJ.Location = new Point(x - 85, cbFormaJurPJ.Location.Y);
                label5PJ.Location = new Point(x - 85, tbRepPJ.Location.Y);
                label6PJ.Location = new Point(x - 60, tbAdresaPJ.Location.Y);
                label7PJ.Location = new Point(x - 70, tbNrTelPJ.Location.Y);
                label8PJ.Location = new Point(x - 55, tbEmailPJ.Location.Y);

                label1PJ.Visible = true;
                label2PJ.Visible = true;
                label3PJ.Visible = true;
                label4PJ.Visible = true;
                label5PJ.Visible = true;
                label6PJ.Visible = true;
                label7PJ.Visible = true;
                label8PJ.Visible = true;
                tbCUIPJ.Visible = true;
                tbNrRegComPJ.Visible = true;
                tbNumeFirmaPJ.Visible = true;
                cbFormaJurPJ.Visible = true;
                tbRepPJ.Visible = true;
                tbAdresaPJ.Visible = true;
                tbNrTelPJ.Visible = true;
                tbEmailPJ.Visible = true;
            }
        }

        void insertPF(PersoanaFizica PF)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();

                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT COUNT(cod_client) FROM clienti";
                int nr_clienti = Convert.ToInt32(comanda.ExecuteScalar());
                int cod_cl;
                if (nr_clienti == 0)
                {
                    cod_cl = 1;
                }
                else
                {
                    comanda.CommandText = "SELECT MAX(cod_client) FROM clienti";
                    cod_cl = Convert.ToInt32(comanda.ExecuteScalar());
                    cod_cl++;
                }
                PF.Cod_client = cod_cl;
                comanda.CommandText = "INSERT INTO clienti VALUES (?,?,?,?,?,?)";
                comanda.Parameters.Add("cod_client", OleDbType.Integer).Value = cod_cl;
                comanda.Parameters.Add("cod_agent", OleDbType.Integer).Value = user.Cod;
                comanda.Parameters.Add("adresa", OleDbType.Char, 30).Value = PF.Adresa;
                comanda.Parameters.Add("nr_telefon", OleDbType.Char, 10).Value = PF.NrTelefon;
                comanda.Parameters.Add("email", OleDbType.Char, 50).Value = PF.Email;
                comanda.Parameters.Add("tip_client", OleDbType.Char, 2).Value = "PF";
                comanda.ExecuteNonQuery();

                OleDbCommand comanda2 = new OleDbCommand();
                comanda2.Connection = conexiune;
                comanda2.CommandText = "INSERT INTO clienti_persoane_fizice VALUES (?,?,?,?)";
                comanda2.Parameters.Add("cod_client", OleDbType.Integer).Value = cod_cl;
                comanda2.Parameters.Add("nume", OleDbType.Char, 30).Value = PF.Nume;
                comanda2.Parameters.Add("prenume", OleDbType.Char, 30).Value = PF.Prenume;
                comanda2.Parameters.Add("cnp", OleDbType.Char, 13).Value = PF.CodNumericPersonal;
                comanda2.ExecuteNonQuery();
                user.ListaClienti.Add(PF);

                MessageBox.Show("Client persoana fizica adaugat cu succes!");
                this.Close();
                frm_clienti.Show();
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

        void insertPJ(PersoanaJuridica PJ)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();

                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT COUNT(cod_client) FROM clienti";
                int nr_clienti = Convert.ToInt32(comanda.ExecuteScalar());
                int cod_cl;
                if (nr_clienti == 0)
                {
                    cod_cl = 1;
                }
                else
                {
                    comanda.CommandText = "SELECT MAX(cod_client) FROM clienti";
                    cod_cl = Convert.ToInt32(comanda.ExecuteScalar());
                    cod_cl++;
                }
                PJ.Cod_client = cod_cl;
                comanda.CommandText = "INSERT INTO clienti VALUES (?,?,?,?,?,?)";
                comanda.Parameters.Add("cod_client", OleDbType.Integer).Value = cod_cl;
                comanda.Parameters.Add("cod_agent", OleDbType.Integer).Value = user.Cod;
                comanda.Parameters.Add("adresa", OleDbType.Char, 30).Value = PJ.Adresa;
                comanda.Parameters.Add("nr_telefon", OleDbType.Char, 10).Value = PJ.NrTelefon;
                comanda.Parameters.Add("email", OleDbType.Char, 50).Value = PJ.Email;
                comanda.Parameters.Add("tip_client", OleDbType.Char, 2).Value = "PJ";
                comanda.ExecuteNonQuery();

                OleDbCommand comanda2 = new OleDbCommand();
                comanda2.Connection = conexiune;
                comanda2.CommandText = "INSERT INTO clienti_persoane_juridice VALUES (?,?,?,?,?,?)";
                comanda2.Parameters.Add("cod_client", OleDbType.Integer).Value = cod_cl;
                comanda2.Parameters.Add("CUI", OleDbType.Char, 20).Value = PJ.CodUnicIdentificare;
                comanda2.Parameters.Add("nr_reg_com", OleDbType.Char, 20).Value = PJ.nrRegistruComert;
                comanda2.Parameters.Add("nume_firma", OleDbType.Char, 30).Value = PJ.DenumireFirma;
                comanda2.Parameters.Add("forma_juridica", OleDbType.Char, 3).Value = PJ.FormaJrd.ToString();
                comanda2.Parameters.Add("reprezentant", OleDbType.Char, 50).Value = PJ.NumeReprezentant;


                comanda2.ExecuteNonQuery();
                user.ListaClienti.Add(PJ);
                MessageBox.Show("Client persoana juridica adaugat cu succes!");
                this.Close();
                frm_clienti.Show();
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
            bool error = false;

            if (listBox1.SelectedItem.ToString() == "Persoana fizica")
            {       //nume,prenume,cnp,adresa,tel,email
                if(tbNumePF.Text == "")
                {
                    errorProvider1.SetError(tbNumePF,"Introduceti nume");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbNumePF,"");
                }

                if (tbPrenumePF.Text == "")
                {
                    errorProvider1.SetError(tbPrenumePF, "Introduceti prenume");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbPrenumePF, "");
                }

                if (tbCNPPF.Text == "")
                {
                    errorProvider1.SetError(tbCNPPF, "Introduceti CNP");
                    error = true;
                }
                else if(tbCNPPF.Text.Length != 13)
                {
                    errorProvider1.SetError(tbCNPPF, "CNP-ul are 13 caractere!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbCNPPF, "");
                }

                if (tbAdresaPF.Text == "")
                {
                    errorProvider1.SetError(tbAdresaPF, "Introduceti adresa");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbAdresaPF, "");
                }

                if (tbNrTelPF.Text == "")
                {
                    errorProvider1.SetError(tbNrTelPF, "Introduceti telefon");
                    error = true;
                }
                else if(tbNrTelPF.Text.Length != 10)
                {
                    errorProvider1.SetError(tbNrTelPF,"10 caractere!");
                }
                else
                {
                    errorProvider1.SetError(tbNrTelPF, "");
                }
                if (tbEmailPF.Text == "")
                {
                    errorProvider1.SetError(tbEmailPF, "Introduceti email");
                    error = true;
                }
                else if (!IsValidEmail(tbEmailPF.Text))
                {
                    errorProvider1.SetError(tbEmailPF, "Email invalid");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbEmailPF, "");
                }

                if (!error)
                {
                    string nume = tbNumePF.Text;
                    string prenume = tbPrenumePF.Text;
                    string cnp = tbCNPPF.Text;
                    string adresa = tbAdresaPF.Text;
                    string nrTel = tbNrTelPF.Text;
                    string email = tbEmailPF.Text;

                    PersoanaFizica PF = new PersoanaFizica(0, adresa, nrTel, email, "PF", null, nume, prenume, cnp);
                    insertPF(PF);
                }
            }
            else if (listBox1.SelectedItem.ToString() == "Persoana juridica")
            {
                
                if(tbCUIPJ.Text == "")
                {
                    errorProvider1.SetError(tbCUIPJ,"Introduceti CUI");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbCUIPJ,"");
                }
                if(tbNrRegComPJ.Text=="")
                {
                    errorProvider1.SetError(tbNrRegComPJ,"Introduceti nr. registru comert");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbNrRegComPJ, "");
                }
                if(tbNumeFirmaPJ.Text=="")
                {
                    errorProvider1.SetError(tbNumeFirmaPJ,"Introduceti nume firma");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbNumeFirmaPJ, "");
                }
                
                if(cbFormaJurPJ.Text=="")
                {
                    errorProvider1.SetError(cbFormaJurPJ,"Selectati forma juridica");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(cbFormaJurPJ, "");
                }
                if(tbRepPJ.Text == "")
                {
                    errorProvider1.SetError(tbRepPJ, "Introduceti nume reprezentant");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbRepPJ,"");
                }

                if(tbAdresaPJ.Text=="")
                {
                    errorProvider1.SetError(tbAdresaPJ, "Introduceti adresa");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbAdresaPJ,"");
                }
                if(tbNrTelPJ.Text =="")
                {
                    errorProvider1.SetError(tbNrTelPJ, "Introduceti nr. telefon");
                    error = true;
                }
                else if(tbNrTelPJ.Text.Length != 10)
                {
                    errorProvider1.SetError(tbNrTelPJ, "10 caractere!");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbNrTelPJ,"");
                }
                if(tbEmailPJ.Text =="")
                {
                    errorProvider1.SetError(tbEmailPJ,"Introduceti email");
                    error = true;
                }
                else if(!IsValidEmail(tbEmailPJ.Text))
                {
                    errorProvider1.SetError(tbEmailPJ, "Email invalid");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbEmailPJ,"");
                }

                if (!error)
                {
                    string CUI = tbCUIPJ.Text;
                    string regCom = tbNrRegComPJ.Text;
                    string numeFirma = tbNumeFirmaPJ.Text;
                    formaJuridica formaJrd = (formaJuridica)Enum.Parse(typeof(formaJuridica), cbFormaJurPJ.Text);
                    string reprezentant = tbRepPJ.Text;
                    string adresa = tbAdresaPJ.Text;
                    string nrTel = tbNrTelPJ.Text;
                    string email = tbEmailPJ.Text;

                    PersoanaJuridica PJ = new PersoanaJuridica(0, adresa, nrTel, email, "PJ", null, CUI, regCom, numeFirma, formaJrd, reprezentant);
                    insertPJ(PJ);
                }
            }
        }

        private void Form6_adauga_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_clienti.Show();
        }

        private void tbNumePF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)8 || char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void tbCNPPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

       
    }
}
