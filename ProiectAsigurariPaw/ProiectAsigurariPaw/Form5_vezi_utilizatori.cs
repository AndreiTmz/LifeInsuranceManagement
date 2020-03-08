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
    public partial class Form5_vezi_utilizatori : Form
    {
    
        Form2_Clienti frm_clienti;
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = asigurari.accdb";

        public Form5_vezi_utilizatori(Form2_Clienti frm_cl)
        {
            frm_clienti = frm_cl;
            

            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM utilizatori", conexiune);
            InitializeComponent();

            this.searchUserControl1.Conn =  "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = asigurari.accdb";
            this.searchUserControl1.Tabela1 = "utilizatori";
            this.searchUserControl1.Coloana = "nume";

            try
            {
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["cod_agent"].ToString());
                    item.SubItems.Add(reader["nume"].ToString());
                    item.SubItems.Add(reader["username"].ToString());
                    item.SubItems.Add(reader["email"].ToString());
                    item.SubItems.Add(reader["telefon"].ToString());
                    item.SubItems.Add(reader["adresa"].ToString());
                    listViewUsers.Items.Add(item);
                }
                reader.Close();
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

        private void Form5_vezi_utilizatori_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_clienti.Show();
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
             if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
                int cod_agent = Convert.ToInt32(item.ListView.SelectedItems[0].SubItems[0].Text);
                

                OleDbConnection conexiune = new OleDbConnection(connString);

                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;

                    comanda.CommandText = "SELECT admin FROM utilizatori WHERE cod_agent = " + cod_agent;
                    string admin = comanda.ExecuteScalar().ToString();
                    if(admin == "da")
                    {
                        MessageBox.Show("Nu puteti sterge un administrator!");
                    }
                    else if(admin=="nu")
                    {
                        item.ListView.Items.Remove(item);
                        comanda.CommandText = "DELETE FROM utilizatori WHERE cod_agent=" + cod_agent;
                        comanda.ExecuteNonQuery();
                    }


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

        private void listViewUsers_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
    }
}
