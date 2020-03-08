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

namespace ProiectAsigurariPaw
{
    public partial class Form7_adauga_asigurare : Form
    {
        int cod_client;
        Utilizator user;
        Form2_Clienti frm_clienti;
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = asigurari.accdb"; 
        

        void insertAsigBunuri(AsigurareBunuri ab)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            try
            {
                conexiune.Open();

                comanda.CommandText = "INSERT INTO asigurari VALUES (?,?,?,?,?,?,?,?,?)";
                comanda.Parameters.Add("nr_asigurare", OleDbType.Integer).Value = ab.NrAsigurare;
                comanda.Parameters.Add("cod_client", OleDbType.Integer).Value = cod_client;
                comanda.Parameters.Add("cod_agent", OleDbType.Integer).Value = user.Cod;
                comanda.Parameters.Add("suma_asigurata", OleDbType.Double).Value = ab.SumaAsigurata;
                comanda.Parameters.Add("data_incheiere", OleDbType.DBDate).Value = ab.DataIncheierePolita;
                comanda.Parameters.Add("data_inceput", OleDbType.DBDate).Value = ab.DataInceput;
                comanda.Parameters.Add("durata_valabilitate", OleDbType.Char, 8).Value = ab.DurataVal;
                comanda.Parameters.Add("prima_asigurare", OleDbType.Double).Value = ab.Prima;
                comanda.Parameters.Add("proc_comision", OleDbType.Integer).Value = ab.ProcentComision;
                comanda.ExecuteNonQuery();

                OleDbCommand comanda2 = new OleDbCommand();
                comanda2.Connection = conexiune;
                comanda2.CommandText = "INSERT INTO asigurari_bunuri VALUES (?,?,?)";
                comanda2.Parameters.Add("nr_asigurare", OleDbType.Integer).Value = ab.NrAsigurare;
                comanda2.Parameters.Add("bunuri_asigurate", OleDbType.Char, 30).Value = ab.BunuriAsigurate;
                comanda2.Parameters.Add("informatii", OleDbType.Char, 30).Value = ab.Informatii;

                comanda2.ExecuteNonQuery();               

                foreach(Client c in user.ListaClienti)
                {
                    if (c.Cod_client == cod_client)
                    {
                        if (c.Asigurari == null)
                            c.Asigurari = new ArrayList();
                        c.Asigurari.Add(ab);
                    }
                }

                MessageBox.Show("Asigurare adaugata cu succes in baza de date!");
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

        void insertAsigurareViata(AsigurareViata av)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;

            try
            {
                conexiune.Open();

                comanda.CommandText = "INSERT INTO asigurari VALUES (?,?,?,?,?,?,?,?,?)";
                comanda.Parameters.Add("nr_asigurare", OleDbType.Integer).Value = av.NrAsigurare;
                comanda.Parameters.Add("cod_client", OleDbType.Integer).Value = cod_client;
                comanda.Parameters.Add("cod_agent", OleDbType.Integer).Value = user.Cod;
                comanda.Parameters.Add("suma_asigurata", OleDbType.Double).Value = av.SumaAsigurata;
                comanda.Parameters.Add("data_incheiere", OleDbType.DBDate).Value = av.DataIncheierePolita;
                comanda.Parameters.Add("data_inceput", OleDbType.DBDate).Value = av.DataInceput;
                comanda.Parameters.Add("durata_valabilitate", OleDbType.Char, 8).Value = av.DurataVal;
                comanda.Parameters.Add("prima_asigurare", OleDbType.Double).Value = av.Prima;
                comanda.Parameters.Add("proc_comision", OleDbType.Integer).Value = av.ProcentComision;

                comanda.ExecuteNonQuery();

                OleDbCommand comanda2 = new OleDbCommand();
                comanda2.Connection = conexiune;
                comanda2.CommandText = "INSERT INTO asigurari_viata VALUES (?,?,?,?)";
                comanda2.Parameters.Add("nr_asigurare", OleDbType.Integer).Value = av.NrAsigurare;
                comanda2.Parameters.Add("riscuri_acoperite", OleDbType.Char, 30).Value = av.RiscuriAcoperite;
                comanda2.Parameters.Add("exceptii", OleDbType.Char, 30).Value = av.Exceptii;
                comanda2.Parameters.Add("informatii", OleDbType.Char, 30).Value = av.Informatii;

                comanda2.ExecuteNonQuery();            

                foreach (Client c in user.ListaClienti)
                {
                    if (c.Cod_client == cod_client)
                    {
                        if (c.Asigurari == null)
                            c.Asigurari = new ArrayList();
                        c.Asigurari.Add(av);
                    }
                }

                MessageBox.Show("Asigurare adaugata cu succes in baza de date!");
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

        public Form7_adauga_asigurare(int cod_cl,Utilizator u,Form2_Clienti frm)
        {
            frm_clienti = frm;
             cod_client = cod_cl;
             user = u;

            InitializeComponent();
            dtpDataInceput.MinDate = dtpDataIncheiere.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                tbBunuriAsig.Visible = true;
                label7Bunuri.Visible = true;
                
                tbRiscuriAcoperite.Visible = false;
                tbExceptii.Visible = false;
                tbRiscuriAcoperite.Text = "";
                tbExceptii.Text = "";

                label7Viata.Visible = false;
                label9Viata.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                tbBunuriAsig.Visible = false;
                tbBunuriAsig.Text = "";
                label7Bunuri.Visible = false;

                tbRiscuriAcoperite.Visible = true;
                tbExceptii.Visible = true;
                label7Viata.Visible = true;
                label9Viata.Visible = true;
            }
        }

        private void Form7_adauga_asigurare_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_clienti.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            bool error = false;
            conexiune.Open();
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT COUNT(nr_asigurare) FROM asigurari";
            int nr_asigurari = Convert.ToInt32(comanda.ExecuteScalar());
            int cod_asig;
            if (nr_asigurari == 0)
            {
                cod_asig = 1;
            }
            else
            {
                comanda.CommandText = "SELECT MAX(nr_asigurare) FROM asigurari";
                cod_asig = Convert.ToInt32(comanda.ExecuteScalar());
                cod_asig++;
            }

            if(tbSumaAsig.Text == "")
            {
                errorProvider1.SetError(tbSumaAsig, "Care este suma asigurata?");
                error = true;
            }
            else
            {
                errorProvider1.SetError(tbSumaAsig, "");
            }
            if(tbPrima.Text == "")
            {
                errorProvider1.SetError(tbPrima,"Introduceti prima pe asigurare");
                error = true;
            }
            else
            {
                errorProvider1.SetError(tbPrima,"");
            }

            if(tbComision.Text=="")
            {
                errorProvider1.SetError(tbComision, "Introduceti procent comision!");
                error = true;
            }
            else
            {
                errorProvider1.SetError(tbComision, "");
            }
            if(tbInfo.Text=="")
            {
                errorProvider1.SetError(tbInfo,"Adaugati detalii aferente asigurarii");
                error = true;
            }
            else
            {
                errorProvider1.SetError(tbInfo,"");
            }

            if (!error)
            {
                float sumaAsigurata = (float)Convert.ToDouble(tbSumaAsig.Text);
                DateTime dataIncheiere = dtpDataIncheiere.Value;
                DateTime dataInceput = dtpDataInceput.Value;
                int valabilitate = Convert.ToInt32(nmrValabilitate.Text);
                float prima = (float)Convert.ToDouble(tbPrima.Text);
                int procentCms = Convert.ToInt32(tbComision.Text);
                string info = tbInfo.Text;

                if (radioButton1.Checked == true) //Bunuri
                {

                    if(tbBunuriAsig.Text=="")
                    {
                        errorProvider1.SetError(tbBunuriAsig,"Care sunt bunurile asigurate?");
                        error = true;
                    }
                    else
                    {
                        errorProvider1.SetError(tbBunuriAsig,"");
                    }
                    if (!error)
                    {
                        string bunuriAsig = tbBunuriAsig.Text;


                        AsigurareBunuri ab = new AsigurareBunuri(cod_asig, sumaAsigurata, dataIncheiere,
                            valabilitate, dataInceput, prima, procentCms, "b", bunuriAsig, info);
                        insertAsigBunuri(ab);
                    }
                }
                else if (radioButton2.Checked == true) //Viata
                {
                    if(tbRiscuriAcoperite.Text=="")
                    {
                        errorProvider1.SetError(tbRiscuriAcoperite, "Care sunt riscurile acoperite?");
                        error = true;
                    }
                    else
                    {
                        errorProvider1.SetError(tbRiscuriAcoperite, "");
                    }
                    if(tbExceptii.Text == "" )
                    {
                        errorProvider1.SetError(tbExceptii,"Care sunt exceptiile?");
                        error = true;
                    }
                    else
                    {
                        errorProvider1.SetError(tbExceptii,"");
                    }
                    if (!error)
                    {
                        string riscuri = tbRiscuriAcoperite.Text;
                        string exceptii = tbExceptii.Text;

                        AsigurareViata av = new AsigurareViata(cod_asig, sumaAsigurata, dataIncheiere, valabilitate, dataInceput,
                            prima, procentCms, "v", riscuri, exceptii, info);
                        insertAsigurareViata(av);
                    }
                }
            }
        }

        private void tbSumaAsig_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void dtpDataIncheiere_ValueChanged(object sender, EventArgs e)
        {
            dtpDataInceput.MinDate = dtpDataIncheiere.Value;
        }
    }
}
