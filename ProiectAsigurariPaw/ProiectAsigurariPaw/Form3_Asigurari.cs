using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProiectAsigurariPaw
{
    public partial class Form3_Asigurari : Form
    {        
        Utilizator user;
        int cod_client;
        string nume_client;
        Form2_Clienti frm_clienti;
        List<AsigurareBunuri> listaAsigBunuri = new List<AsigurareBunuri>();
        List<AsigurareViata> listaAsigViata = new List<AsigurareViata>();

        void initTreeView()
        {
            TreeNode viata = new TreeNode("Asigurari de viata");
            TreeNode bunuri = new TreeNode("Asigurari de bunuri");
            TreeNode expira = new TreeNode("Polite care expira in urmatoarele 7 zile");

            treeView1.Nodes.Add(viata);
            treeView1.Nodes.Add(bunuri);
            treeView1.Nodes.Add(expira);

                for(int i=0;i<user.ListaClienti.Count;i++)
                {
                if (((Client)user.ListaClienti[i]).Cod_client == cod_client && ((Client)user.ListaClienti[i]).Asigurari != null)
                {
                    for (int j = 0; j < ((Client)user.ListaClienti[i]).Asigurari.Count; j++)
                    {
                        if (((Asigurare)(((Client)user.ListaClienti[i]).Asigurari[j])).TipAsig == "v")
                        {
                            AsigurareViata asigViata = (AsigurareViata)(((Client)user.ListaClienti[i]).Asigurari[j]);

                            TreeNode asigV = new TreeNode("Nr: " + asigViata.NrAsigurare +
                                " / Data inceput: " + asigViata.DataInceput.Day +
                                               "-" + asigViata.DataInceput.Month +
                                               "-" + asigViata.DataInceput.Year +
                                  " / Valabila: " + (asigViata.DurataVal==1?"o luna":asigViata.DurataVal+" luni"));
                            viata.Nodes.Add(asigV);
                            listaAsigViata.Add(asigViata);

                            DateTime dataExpirarii = asigViata.DataInceput.AddMonths(Convert.ToInt32(asigViata.DurataVal));

                            if(dataExpirarii > System.DateTime.Now && dataExpirarii <= System.DateTime.Now.AddDays(7))
                            {
                                TreeNode expV = (TreeNode)asigV.Clone();
                                expira.Nodes.Add(expV);
                            }

                        }
                        else if (((Asigurare)(((Client)user.ListaClienti[i]).Asigurari[j])).TipAsig == "b")
                        {
                            AsigurareBunuri asigBunuri = (AsigurareBunuri)(((Client)user.ListaClienti[i]).Asigurari[j]);

                            TreeNode asigB = new TreeNode("Nr: " + asigBunuri.NrAsigurare +
                        " / Data inceput: " + asigBunuri.DataInceput.Day +
                                       "-" + asigBunuri.DataInceput.Month +
                                       "-" + asigBunuri.DataInceput.Year +
                          " / Valabila: " + (asigBunuri.DurataVal == 1 ? "o luna" : asigBunuri.DurataVal + " luni"));
                            bunuri.Nodes.Add(asigB);
                            listaAsigBunuri.Add(asigBunuri);

                            DateTime dataExpirarii = asigBunuri.DataInceput.AddMonths(Convert.ToInt32(asigBunuri.DurataVal));

                            if (dataExpirarii > System.DateTime.Now && dataExpirarii <= System.DateTime.Now.AddDays(7))
                            {
                                TreeNode expB = (TreeNode)asigB.Clone();
                                expira.Nodes.Add(expB);
                            }
                        }
                    }
                }
            }                
           treeView1.ExpandAll();
        }

        public Form3_Asigurari(int cod_cl,Utilizator u,string numeCl, Form2_Clienti frm)
        {
            frm_clienti = frm;
            cod_client = cod_cl;
            user = u;
            nume_client = numeCl;             
            InitializeComponent();
            label1.Text += " " + numeCl;
            initTreeView();
        }

        private void Form3_Asigurari_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_clienti.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            TreeNode nodSelectat = treeView1.SelectedNode;
            if (nodSelectat.Parent != null)
            {
                string nr_asig;

                try
                {
                    int gasit = 0;
                    nr_asig = nodSelectat.Text.Split(':', '/')[1];
                    nr_asig = nr_asig.Trim();
                    foreach (AsigurareBunuri ab in listaAsigBunuri)
                    {
                        if (nr_asig == ab.NrAsigurare.ToString())
                        {
                            textBox1.Text = "Client: " + nume_client + Environment.NewLine;
                            textBox1.Text += "_____________________" + Environment.NewLine;
                            textBox1.Text += ab.ToString();
                            gasit = 1;
                            pictureBox1.Visible = true;
                        }

                    }
                    if (gasit == 0)
                    {
                        foreach (AsigurareViata av in listaAsigViata)
                        {
                            if (nr_asig == av.NrAsigurare.ToString())
                            {
                                textBox1.Text = "Client " + nume_client + Environment.NewLine;
                                textBox1.Text += "_____________________" + Environment.NewLine;
                                textBox1.Text += av.ToString();
                                pictureBox1.Visible = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void tb_print(object sender, PrintPageEventArgs e)
        {
            int upperMargin = 50;
            Graphics g = e.Graphics;
            for (int i = 0; i < textBox1.Lines.Length; i++)
                g.DrawString(textBox1.Lines[i],
                    new Font(FontFamily.GenericSansSerif, 14), Brushes.Black,
                    new PointF(e.PageBounds.X + 200, e.PageBounds.Y + (i + 1) * upperMargin));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(tb_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }      
    }
}
