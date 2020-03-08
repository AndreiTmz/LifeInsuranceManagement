using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;

namespace ProiectAsigurariPaw
{
    public partial class Form10_emailPass : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public Form10_emailPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = asigurari.accdb";
            OleDbConnection conexiune = new OleDbConnection(connString);


            if (textBox1.Text == "")
                MessageBox.Show("Introduceti email!");
            else
            {
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand("SELECT parola FROM utilizatori WHERE email = '" + textBox1.Text+"'",conexiune);

                    OleDbDataReader reader = comanda.ExecuteReader();
                    int nr = 0;
                    string userPass = null;
                    while(reader.Read())
                    {
                        userPass = reader["parola"].ToString();
                        nr++;
                    }

                    if(nr==0)
                    {
                        MessageBox.Show("Aceasta adresa nu exista!");
                    }
                    else if(nr>1)
                    {
                        MessageBox.Show("Eroare in baza de date!");
                    }
                    else if(nr==1)
                    {
                        login = new NetworkCredential("yourmail@gmail.com", "yourpass");
                        client = new SmtpClient("smtp.gmail.com");
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Credentials = login;
                        msg = new MailMessage { From = new MailAddress("yourmail@gmail.com", "Asigurari PAW", Encoding.UTF8) };
                        msg.To.Add(new MailAddress(textBox1.Text));
                        msg.Subject = "Recuperare parola";
                        msg.Body = "Parola dv. este: " + userPass + ". Se recomanda schimbarea acesteia dupa primirea acestui mail.";
                        msg.BodyEncoding = Encoding.UTF8;
                        msg.IsBodyHtml = true;
                        msg.Priority = MailPriority.Normal;
                        msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                        client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                        string userstate = "Sending...";
                        client.SendAsync(msg, userstate);
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


            

        }
        private static void SendCompletedCallback(object sender,AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.",e.UserState),"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("E-mail trimis cu succes!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }
}
