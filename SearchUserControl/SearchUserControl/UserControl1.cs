using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SearchUserControl
{
    public partial class SearchUserControl : UserControl
    {

        private string conn = null;
        private string tabela1 = null;
        private string tabela2 = null;
        private string coloana = null;
        string joinCol = null;

        public string Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        public string Tabela1
        {
            get { return tabela1; }
            set { tabela1 = value; }
        }
        public string Tabela2
        {
            get { return tabela2; }
            set { tabela2 = value; }
        }
        public string Coloana
        {
            get { return coloana; }
            set { coloana = value; }
        }
        public string JoinCol
        {
            get { return this.joinCol; }
            set { this.joinCol = value; }
        }


        public SearchUserControl()
        {
            InitializeComponent();
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            if (tbNumeDeCautat.Text == "")
            {
                MessageBox.Show("Introduceti un nume!");
            }
            else
            {
                try
                {
                    string query;
                    OleDbConnection conexiune = new OleDbConnection(conn);
                    if (tabela2 == null && joinCol == null)
                    {
                        query = "SELECT * FROM " + this.tabela1 + " WHERE " + this.coloana + "='" + tbNumeDeCautat.Text + "'";
                    }
                    else
                    {
                        query = "SELECT * FROM " + this.tabela1 + " t1," + this.tabela2 + " t2 WHERE " + this.coloana + "='" + tbNumeDeCautat.Text + "'" +
                            " AND t1." + this.joinCol + " = t2." + this.joinCol;


                    }
                    OleDbDataAdapter adaptor = new OleDbDataAdapter(query, conexiune);

                    DataSet ds = new DataSet();
                    adaptor.Fill(ds, this.Tabela1);

                    DataTable dtb = ds.Tables[this.tabela1];
                    if (dtb.Rows.Count == 0)
                    {
                        MessageBox.Show("Nu exista informatii pentru numele introdus!");
                    }
                    else
                    {
                        Info frm = new Info(dtb);
                        frm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void tbNumeDeCautat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)8 || char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
