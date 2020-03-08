using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProiectAsigurariPaw
{
    public partial class Form2_Clienti : Form
    {
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = asigurari.accdb";
        string numeCl = "";
        Form1_Login frm_login;
        Utilizator user;
      
      

        void initializareListaClientiPF()
        {
            
            listViewClienti.Columns.Add("Cod", 50);
            listViewClienti.Columns.Add("Nume", 100);
            listViewClienti.Columns.Add("Prenume", 100);
            listViewClienti.Columns.Add("CNP", 90);
            listViewClienti.Columns.Add("Adresa", 150);
            listViewClienti.Columns.Add("Nr. telefon", 90);
            listViewClienti.Columns.Add("Email", 150);

            for (int i = 0; i < user.ListaClienti.Count; i++)
            {

                if (((Client)user.ListaClienti[i]).TipClient == "PF")
                {
                    PersoanaFizica pf = (PersoanaFizica)user.ListaClienti[i];
                    ListViewItem item = new ListViewItem(pf.Cod_client.ToString());
                    item.SubItems.Add(pf.Nume);
                    item.SubItems.Add(pf.Prenume);
                    item.SubItems.Add(pf.CodNumericPersonal.ToString());
                    item.SubItems.Add(pf.Adresa);
                    item.SubItems.Add(pf.NrTelefon);
                    item.SubItems.Add(pf.Email);
                    listViewClienti.Items.Add(item);
                }
            }           
        }
        
        void initializareListaCLientiPJ()
        {
            listViewClienti.Columns.Add("Cod", 50);
            listViewClienti.Columns.Add("Nume firma", 100);
            listViewClienti.Columns.Add("Forma juridica", 50);
            listViewClienti.Columns.Add("CUI", 100);
            listViewClienti.Columns.Add("Nr.reg.com.", 90);
            listViewClienti.Columns.Add("Reprezentant", 150);
            listViewClienti.Columns.Add("Adresa", 90);
            listViewClienti.Columns.Add("Nr.tel", 100);
            listViewClienti.Columns.Add("Email", 150);

            for (int i = 0; i < user.ListaClienti.Count; i++)
            {

                if (((Client)user.ListaClienti[i]).TipClient == "PJ")
                {
                    PersoanaJuridica pj = (PersoanaJuridica)user.ListaClienti[i];
                    ListViewItem item = new ListViewItem(pj.Cod_client.ToString());
                    item.SubItems.Add(pj.DenumireFirma);
                    item.SubItems.Add(pj.FormaJrd.ToString());
                    item.SubItems.Add(pj.CodUnicIdentificare);
                    item.SubItems.Add(pj.nrRegistruComert);
                    item.SubItems.Add(pj.NumeReprezentant);
                    item.SubItems.Add(pj.Adresa);
                    item.SubItems.Add(pj.NrTelefon);
                    item.SubItems.Add(pj.Email);
                    listViewClienti.Items.Add(item);
                }
            }
        }


        public Form2_Clienti(Utilizator u, Form1_Login frm)
        {
            frm_login = frm;
            user = u;
            InitializeComponent();

            this.search.Conn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = asigurari.accdb";
            this.search.Tabela1 = "clienti";
            this.search.Tabela2 = "clienti_persoane_fizice";
            this.search.Coloana = "nume";
            this.search.JoinCol = "cod_client";

            if (user.Admin == "da")
            {
                btnVeziUtilizatori.Visible = true;
                btnAdaugaUtilizator.Visible = true;
            }
            if (radioButton1.Checked == true)
                initializareListaClientiPF();
            else if (radioButton2.Checked == true)
                initializareListaCLientiPJ();

            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand getName = new OleDbCommand("SELECT nume, prenume FROM utilizatori " +
                "WHERE cod_agent=" + user.Cod, conexiune);
                OleDbDataReader reader = getName.ExecuteReader();
                string nume = "";
                if (reader.Read())
                     nume = reader["nume"] + " " + reader["prenume"];

                label2.Text += " " + nume;
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
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form6_adauga_client(user, this);
            this.Hide();
            frm.ShowDialog();            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            listViewClienti.Clear();
            if (radioButton1.Checked == true)
                initializareListaClientiPF();
            else if (radioButton2.Checked == true)
                initializareListaCLientiPJ();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                listViewClienti.Clear();
                initializareListaClientiPF();
                this.search.Tabela2 = "clienti_persoane_fizice";
                this.search.Coloana = "nume";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                listViewClienti.Clear();
                initializareListaCLientiPJ();
                this.search.Tabela2 = "clienti_persoane_juridice";
                this.search.Coloana = "nume_firma";
            }
        }

        private void btnVeziUtilizatori_Click(object sender, EventArgs e)
        {
            Form frm = new Form5_vezi_utilizatori(this);
            this.Hide();
            frm.ShowDialog();          
        }

        private void btnAdaugaUtilizator_Click(object sender, EventArgs e)
        {
            Form frm = new Form4_adauga_utilizator(this);
            this.Hide();
            frm.ShowDialog();
        }

        private void veziAsigurariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cod_client = 0;
            foreach (ListViewItem item in listViewClienti.Items)
                if (item.Selected)
                {
                    cod_client = Convert.ToInt32(item.SubItems[0].Text);
                    numeCl = item.SubItems[1].Text + " " + item.SubItems[2].Text;
                }
            Form frm = new Form3_Asigurari(cod_client,user,numeCl,this); //cod = cod_agent
            this.Hide();
            frm.ShowDialog();            
        }

        private void adaugaAsigurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cod_client = 0;
            foreach (ListViewItem item in listViewClienti.Items)
                if (item.Selected)
                    cod_client = Convert.ToInt32(item.SubItems[0].Text);
            Form frm = new Form7_adauga_asigurare(cod_client,user,this); //cod = cod_agent
            this.Hide();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();            
            frm_login.Show();            
        }

        private void Form2_Clienti_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_login.Show();
        }

        private void listViewClienti_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
                int cod_client = Convert.ToInt32(item.ListView.SelectedItems[0].SubItems[0].Text);
                string tip_client;
                item.ListView.Items.Remove(item);

                for (int i = 0; i < user.ListaClienti.Count; i++)
                {
                    if (((Client)(user.ListaClienti[i])).Cod_client == cod_client)
                    {
                        Client c = (Client)(user.ListaClienti[i]);
                        user.ListaClienti.Remove(c);

                    }
                }

                OleDbConnection conexiune = new OleDbConnection(connString);

                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT tip_client FROM clienti WHERE cod_client=" + cod_client;
                    tip_client = comanda.ExecuteScalar().ToString();

                    comanda.CommandText = "DELETE FROM clienti WHERE cod_client=" + cod_client;
                    comanda.ExecuteNonQuery();

                    if(tip_client=="PF")
                    {
                        comanda.CommandText = "DELETE FROM clienti_persoane_fizice WHERE cod_client=" + cod_client;
                    }
                    else if(tip_client=="PJ")
                    {
                        comanda.CommandText = "DELETE FROM clienti_persoane_juridice WHERE cod_client=" + cod_client;
                    }
                    comanda.ExecuteNonQuery();

                    OleDbCommand comanda2 = new OleDbCommand(connString);
                    comanda2.Connection = conexiune;
                    comanda2.CommandText = "SELECT nr_asigurare FROM asigurari WHERE cod_client=" + cod_client;
                    OleDbDataReader reader = comanda2.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        int nr = Convert.ToInt32(reader["nr_asigurare"]);
                        comanda.CommandText = "DELETE FROM asigurari_viata WHERE nr_asigurare=" + nr;
                        comanda.ExecuteNonQuery();                        
                        comanda.CommandText = "DELETE FROM asigurari_bunuri WHERE nr_asigurare=" + nr;
                        comanda.ExecuteNonQuery();
                    }
                    reader.Close();
                    comanda.CommandText = "DELETE FROM asigurari WHERE cod_client=" + cod_client;
                    comanda.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.Source);
                }
                finally
                {
                    conexiune.Close();
                }
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;

            }
        }

        private void informatiiContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Nume utilizator: " + user.User + Environment.NewLine +
                "Email: "           + user.Email + Environment.NewLine +
                "Nr. telefon: "     + user.Telefon + Environment.NewLine +
                "Adresa:"           + user.Adresa + Environment.NewLine +
                "Admin:"            + user.Admin
                );
        }

        private void setariContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8_setari frm = new Form8_setari(this,user);
            this.Hide();
            frm.ShowDialog();
            
        }

       

        private void graficeToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            Form9_grafice frm = new Form9_grafice(user.ListaClienti);
            frm.ShowDialog();
        }

        private void exportClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream,Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

                    writer.WriteStartElement(user.Nume + user.Prenume);
            if (user.ListaClienti != null)
            {
                foreach (Client c in user.ListaClienti)
                {
                    int nrAsig = 1;
                    if (c.TipClient == "PF")
                    {
                        PersoanaFizica pf = (PersoanaFizica)c;
                        writer.WriteStartElement(pf.Nume.Replace(" ",string.Empty) + pf.Prenume.Replace(" ",string.Empty));
                        
                        if(pf.Asigurari != null)
                        {
                            foreach(Asigurare a in pf.Asigurari)
                            {
                                if(a.TipAsig=="b")
                                {
                                    AsigurareBunuri ab = (AsigurareBunuri)a;
                                    writer.WriteStartElement("Asig " + nrAsig++);
                                    writer.WriteAttributeString("data_inceput",ab.DataInceput.ToString());
                                    writer.WriteAttributeString("prima", ab.Prima.ToString());
                                    writer.WriteAttributeString("comision", (ab.ProcentComision/100 * ab.Prima).ToString());
                                    writer.WriteAttributeString("valabilitate", ab.DurataVal + " luni");
                                    writer.WriteValue("Asigurare bunuri");
                                    writer.WriteEndElement();
                                }
                                else if(a.TipAsig=="v")
                                {
                                    AsigurareViata av = (AsigurareViata)a;
                                    writer.WriteStartElement("Asig " + nrAsig++);
                                    writer.WriteAttributeString("data_inceput", av.DataInceput.ToString());
                                    writer.WriteAttributeString("prima", av.Prima.ToString());
                                    writer.WriteAttributeString("comision", (av.ProcentComision / 100 * av.Prima).ToString());
                                    writer.WriteAttributeString("valabilitate", av.DurataVal + " luni");
                                    writer.WriteValue("Asigurare viata");
                                    writer.WriteEndElement();
                                }
                            }
                        }
                        writer.WriteEndElement();
                    }
                    else if(c.TipClient == "PJ")
                    {
                        PersoanaJuridica pj = (PersoanaJuridica)c;
                        writer.WriteStartElement(pj.DenumireFirma.Replace(" ",string.Empty));

                        if (pj.Asigurari != null)
                        {
                            foreach (Asigurare a in pj.Asigurari)
                            {
                                if (a.TipAsig == "b")
                                {
                                    AsigurareBunuri ab = (AsigurareBunuri)a;
                                    writer.WriteStartElement("Asig " + nrAsig++);
                                    writer.WriteAttributeString("data_inceput", ab.DataInceput.ToString());
                                    writer.WriteAttributeString("prima", ab.Prima.ToString());
                                    writer.WriteAttributeString("comision", (ab.ProcentComision / 100 * ab.Prima).ToString());
                                    writer.WriteAttributeString("valabilitate", ab.DurataVal + " luni");
                                    writer.WriteValue("Asigurare bunuri");
                                    writer.WriteEndElement();
                                }
                                else if (a.TipAsig == "v")
                                {
                                    AsigurareViata av = (AsigurareViata)a;
                                    writer.WriteStartElement("Asig " + nrAsig++);
                                    writer.WriteAttributeString("data_inceput", av.DataInceput.ToString());
                                    writer.WriteAttributeString("prima", av.Prima.ToString());
                                    writer.WriteAttributeString("comision", (av.ProcentComision / 100 * av.Prima).ToString());
                                    writer.WriteAttributeString("valabilitate", av.DurataVal + " luni");
                                    writer.WriteValue("Asigurare viata");
                                    writer.WriteEndElement();
                                }
                            }
                        }
                        writer.WriteEndElement();
                    }
                }
            }
                              
                    writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            string str = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();
            string numeFisier = user.User + ".xml";

            StreamWriter sw = new StreamWriter(numeFisier);
            sw.WriteLine(str);
            sw.Close();
            MessageBox.Show("Fisier generat!");
        }
    }
}
