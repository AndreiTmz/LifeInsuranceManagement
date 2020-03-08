using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchUserControl
{
    public partial class Info : Form
    {
        DataTable dtb;
        public Info(DataTable d)
        {
            dtb = d;
            InitializeComponent();
            textBox1.Text += "( ";
            foreach (DataColumn coloana in dtb.Columns)
                textBox1.Text += coloana.ColumnName + "   ";
            textBox1.Text += ")";
            textBox1.Text += Environment.NewLine;
            textBox1.Text +="_____________________________________________________________________________________";
            textBox1.Text += Environment.NewLine;

            foreach (DataRow linie in dtb.Rows)
            {
                foreach (object camp in linie.ItemArray)
                    textBox1.Text += camp + "   ";
                textBox1.Text += Environment.NewLine;
                textBox1.Text += "_____________________________________________________________________________________";
                textBox1.Text += Environment.NewLine;
            }


        }
    }
}
