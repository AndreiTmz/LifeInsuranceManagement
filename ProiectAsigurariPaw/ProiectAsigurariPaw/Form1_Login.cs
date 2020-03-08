using System;
using System.Collections;
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

    public partial class Form1_Login : Form
    {
        ArrayList listaClienti = new ArrayList();
        ArrayList listaUtilizatori = new ArrayList();
        int id;
        string nume;
        string prenume;
        string email;
        string tel;
        string adresa;
        string admin;
       
        public Form1_Login()
        {
            InitializeComponent();
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar >= 'a' && e.KeyChar <= 'z'
               || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "" || tbParola.Text == "")
                MessageBox.Show("Introduceti datele de conectare!");
            else
            {
                string username = tbUser.Text;
                string parola = tbParola.Text;
                string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = asigurari.accdb";
                OleDbConnection conexiune = new OleDbConnection(connString);
                OleDbCommand comanda = new OleDbCommand("SELECT * FROM utilizatori " +
                    "WHERE username= '" + username + "' AND parola='" + parola + "'", conexiune);
                try
                {
                    conexiune.Open();
                    OleDbDataReader reader = comanda.ExecuteReader();

                    int nr = 0;
                    while (reader.Read())
                    {
                        nr++;
                        id = (int)reader["cod_agent"];
                        nume = reader["nume"].ToString();
                        prenume = reader["prenume"].ToString();
                        email = reader["email"].ToString();
                        tel = reader["telefon"].ToString();
                        adresa = reader["adresa"].ToString();
                        admin = reader["admin"].ToString();
                    }

                    if (nr == 0)
                    {
                        MessageBox.Show("Ati introdus date incorecte!");
                    }
                    else if (nr == 1)
                    {
                        listaClienti.Clear();
                        OleDbCommand comandaPF = new OleDbCommand("SELECT * FROM clienti c, clienti_persoane_fizice pf" +
                            " WHERE cod_agent=" + id + " AND c.cod_client=pf.cod_client", conexiune);
                        OleDbDataReader readPF = comandaPF.ExecuteReader();
                        while (readPF.Read())
                        {
                                    int cod = Convert.ToInt32(readPF["c.cod_client"]);
                                    string adresa = readPF["adresa"].ToString();
                                    string nrTel = readPF["nr_telefon"].ToString();
                                    string email = readPF["email"].ToString();
                                    string tipCl = readPF["tip_client"].ToString();
                                    string nume = readPF["nume"].ToString();
                                    string prenume = readPF["prenume"].ToString();
                                    string cnp = readPF["cnp"].ToString();

                                    PersoanaFizica pf = new PersoanaFizica(cod, adresa, nrTel, email, tipCl, null, nume, prenume, cnp);
                                   
                                    listaClienti.Add(pf);                            
                        }
                        readPF.Close();

                        OleDbCommand comandaPJ = new OleDbCommand("SELECT * FROM clienti c,clienti_persoane_juridice pj " +
                            "WHERE cod_agent=" + id + " AND c.cod_client=pj.cod_client", conexiune);
                        OleDbDataReader readPJ = comandaPJ.ExecuteReader();
                        while (readPJ.Read())
                        {
                            int cod = Convert.ToInt32(readPJ["c.cod_client"]);
                            string adresa = readPJ["adresa"].ToString();
                            string nrTel = readPJ["nr_telefon"].ToString();
                            string email = readPJ["email"].ToString();
                            string tipCl = readPJ["tip_client"].ToString();
                            string CUI = readPJ["CUI"].ToString();
                            string nrRegCom = readPJ["nr_reg_com"].ToString();
                            string numeFirma = readPJ["nume_firma"].ToString();
                            formaJuridica formaJrd = (formaJuridica)Enum.Parse(typeof(formaJuridica), readPJ["forma_juridica"].ToString());
                            string rep = readPJ["reprezentant"].ToString();
                            PersoanaJuridica pj = new PersoanaJuridica(cod, adresa, nrTel, email, tipCl, 
                                null,CUI,nrRegCom, numeFirma, formaJrd,rep);
                            listaClienti.Add(pj);
                        }
                        readPJ.Close();


                        foreach (Client c in listaClienti)
                        {
                            ArrayList listaAsig = new ArrayList();
                            OleDbCommand comandaAV = new OleDbCommand("SELECT * FROM asigurari a, asigurari_viata av" +
                " WHERE a.cod_agent=" + id + " AND a.cod_client=" + c.Cod_client + "AND a.nr_asigurare=av.nr_asigurare", conexiune);

                            OleDbDataReader readAV = comandaAV.ExecuteReader();
                            while (readAV.Read())
                            {
                                int nrAsig = Convert.ToInt32(readAV["a.nr_asigurare"]);
                                float sumaAsig = (float)Convert.ToDouble(readAV["suma_asigurata"]);
                                DateTime dataIncheiere = (DateTime)readAV["data_incheiere"];
                                int durata = Convert.ToInt32(readAV["durata_valabilitate"]);                                
                                DateTime dataInceput = (DateTime)readAV["data_inceput"];
                                float prima = (float)Convert.ToUInt32(readAV["prima_asigurare"]);
                                int comision = Convert.ToInt32(readAV["proc_comision"]);
                                string riscuri = readAV["riscuri_acoperite"].ToString();
                                string exceptii = readAV["exceptii"].ToString();
                                string info = readAV["informatii"].ToString();
                                AsigurareViata asigViata = new AsigurareViata(nrAsig, sumaAsig, dataIncheiere,
                                     durata, dataInceput, prima, comision, "v", riscuri, exceptii,info);
                                listaAsig.Add(asigViata);
                            }
                            readAV.Close();
                            OleDbCommand comandaAB = new OleDbCommand("SELECT * FROM asigurari a, asigurari_bunuri ab" +
               " WHERE a.cod_agent=" + id + " AND a.cod_client=" + c.Cod_client + "AND a.nr_asigurare=ab.nr_asigurare", conexiune);
                            OleDbDataReader readAB = comandaAB.ExecuteReader();

                            while (readAB.Read())
                            {
                                int nrAsig = Convert.ToInt32(readAB["a.nr_asigurare"]);
                                float sumaAsig = (float)Convert.ToDouble(readAB["suma_asigurata"]);
                                DateTime dataIncheiere = (DateTime)readAB["data_incheiere"];
                                int durata = Convert.ToInt32(readAB["durata_valabilitate"]);
                                DateTime dataInceput = (DateTime)readAB["data_inceput"];
                                float prima = (float)Convert.ToUInt32(readAB["prima_asigurare"]);
                                int comision = Convert.ToInt32(readAB["proc_comision"]);
                                string bunuriAsigurate = readAB["bunuri_asigurate"].ToString();
                                string info = readAB["informatii"].ToString();
                                AsigurareBunuri asigBunuri = new AsigurareBunuri(nrAsig, sumaAsig, dataIncheiere, durata,
                                    dataInceput, prima, comision, "b", bunuriAsigurate,info);
                                listaAsig.Add(asigBunuri);
                            }
                                c.Asigurari = listaAsig;

                            readAV.Close();
                        }

                        Utilizator u = new Utilizator(id,nume,prenume,username,
                            parola,email,tel,adresa,admin,listaClienti);

                        Form frm = new Form2_Clienti(u,this);
                        tbUser.Clear();
                        tbParola.Clear();
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Exista o eroare in baza de date!");
                    }

                    reader.Close();
                    
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form10_emailPass frm = new Form10_emailPass();
            frm.ShowDialog();
        }
    }
}
