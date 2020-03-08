using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAsigurariPaw
{
    public partial class Form9_grafice : Form
    {
        const int marg = 10;
        ArrayList listaClienti = new ArrayList();
        public Form9_grafice(ArrayList l)
        {
            listaClienti = l;
            InitializeComponent();            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black,1);
            Rectangle rec = new Rectangle(panel1.Location.X + marg,
                                                panel1.Location.Y + 9 * marg,
                                                panel1.Width - 2 * marg, panel1.Height - 10 * marg);
            Color culoare = Color.Blue;
            Brush br = new SolidBrush(culoare);
            Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

            int tenSeg = panel1.Width / 10;
            int x = panel1.Location.X;
            int y = panel1.Location.Y;
            int fontSize = Convert.ToInt32(font.Size);

            g.DrawString("Persoane fizice", font, br, new Point(x + 2 * tenSeg, y));
            g.DrawString("Persoane juridice", font, br, new Point(x + 6 * tenSeg, y));
            g.DrawString("Asigurari bunuri", font, br, new Point(x + tenSeg, y + 2 * fontSize));
            g.DrawLine(pen, new Point(x + 3*tenSeg, y + 2 * fontSize), new Point(x + 3*tenSeg, y + 4 * fontSize));
            g.DrawString("Asigurari viata", font, br, new Point(x + 3*tenSeg + tenSeg/2, y + 2 * fontSize));

            g.DrawLine(pen, new Point(x + 5 * tenSeg + tenSeg/4 - 5, y), new Point(x + 5 * tenSeg+tenSeg/4 - 5, y + 4 * fontSize));

            g.DrawString("Asigurari bunuri", font, br, new Point(x + 5*tenSeg+tenSeg/5, y + 2 * fontSize));
            g.DrawLine(pen, new Point(x + 7 * tenSeg + tenSeg / 3, y + 2 * fontSize), new Point(x + 7*tenSeg +tenSeg/3, y + 4 * fontSize));
            g.DrawString("Asigurari viata", font, br, new Point(x + 7 * tenSeg + tenSeg / 2, y + 2 * fontSize));

            g.DrawRectangle(pen,rec);
            Rectangle[] recs = new Rectangle[4];
            double latime = rec.Width / 4 / 3;
            double distanta = (rec.Width - 4 * latime) / (4 + 1);           

            double[] vect = new double[4];
            vect[0] = 0;   // primele asig bunuri PF
            vect[1] = 0;   // prime asig viata PF
            vect[2] = 0;  // prime asif bunuri PJ
            vect[3] = 0;  //prime asig viata PJ

            
            foreach(Client c in listaClienti)
            {
                if(c.TipClient == "PF" && c.Asigurari!=null)
                {
                    foreach(Asigurare a in c.Asigurari)
                    {
                        if (a.TipAsig == "b")
                            vect[0] += a.Prima;
                        else if (a.TipAsig == "v")
                            vect[1] += a.Prima;
                    }
                }
                else if(c.TipClient=="PJ" && c.Asigurari != null)
                {
                    foreach(Asigurare a in c.Asigurari)
                    {
                        if (a.TipAsig == "b")
                            vect[2] += a.Prima;
                        else if (a.TipAsig == "v")
                            vect[3] += a.Prima;
                    }
                }
            }

            double vMax = vect.Max();

            for (int i = 0; i < 4; i++)
            {
                recs[i] = new Rectangle((int)(rec.Left + (i + 1) * distanta + i * latime),
                        (int)(rec.Bottom - vect[i] / vMax * rec.Height), (int)latime,
                        (int)(vect[i] / vMax * rec.Height));

                
                    g.DrawString(vect[i].ToString(), font, br,
                        new Point((int)(recs[i].Location.X), (int)(recs[i].Location.Y - font.Height)));
                
            }
            g.FillRectangles(br, recs);

        }
        void pd_print_barchart(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);
            Rectangle rec = new Rectangle(e.PageBounds.X + marg,
                                                e.PageBounds.Y+ 9 * marg,
                                                e.PageBounds.Width - 2 * marg, e.PageBounds.Height - 10 * marg);
            Color culoare = Color.Blue;
            Brush br = new SolidBrush(culoare);
            Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

            int tenSeg = e.PageBounds.Width / 10;
            int x = panel1.Location.X;
            int y = panel1.Location.Y;
            int fontSize = Convert.ToInt32(font.Size);

            g.DrawString("Persoane fizice", font, br, new Point(x + 2 * tenSeg, y));
            g.DrawString("Persoane juridice", font, br, new Point(x + 6 * tenSeg, y));
            g.DrawString("Asigurari bunuri", font, br, new Point(x + tenSeg, y + 2 * fontSize));
            g.DrawLine(pen, new Point(x + 3 * tenSeg, y + 2 * fontSize), new Point(x + 3 * tenSeg, y + 4 * fontSize));
            g.DrawString("Asigurari viata", font, br, new Point(x + 3 * tenSeg + tenSeg / 2, y + 2 * fontSize));

            g.DrawLine(pen, new Point(x + 5 * tenSeg + tenSeg / 4 - 5, y), new Point(x + 5 * tenSeg + tenSeg / 4 - 5, y + 4 * fontSize));

            g.DrawString("Asigurari bunuri", font, br, new Point(x + 5 * tenSeg + tenSeg / 5, y + 2 * fontSize));
            g.DrawLine(pen, new Point(x + 7 * tenSeg + tenSeg / 3, y + 2 * fontSize), new Point(x + 7 * tenSeg + tenSeg / 3, y + 4 * fontSize));
            g.DrawString("Asigurari viata", font, br, new Point(x + 7 * tenSeg + tenSeg / 2, y + 2 * fontSize));

            g.DrawRectangle(pen, rec);
            Rectangle[] recs = new Rectangle[4];
            double latime = rec.Width / 4 / 3;
            double distanta = (rec.Width - 4 * latime) / (4 + 1);

            double[] vect = new double[4];
            vect[0] = 0;   // primele asig bunuri PF
            vect[1] = 0;   // prime asig viata PF
            vect[2] = 0;  // prime asif bunuri PJ
            vect[3] = 0;  //prime asig viata PJ


            foreach (Client c in listaClienti)
            {
                if (c.TipClient == "PF")
                {
                    foreach (Asigurare a in c.Asigurari)
                    {
                        if (a.TipAsig == "b")
                            vect[0] += a.Prima;
                        else if (a.TipAsig == "v")
                            vect[1] += a.Prima;
                    }
                }
                else if (c.TipClient == "PJ")
                {
                    foreach (Asigurare a in c.Asigurari)
                    {
                        if (a.TipAsig == "b")
                            vect[2] += a.Prima;
                        else if (a.TipAsig == "v")
                            vect[3] += a.Prima;
                    }
                }
            }

            double vMax = vect.Max();

            for (int i = 0; i < 4; i++)
            {
                recs[i] = new Rectangle((int)(rec.Left + (i + 1) * distanta + i * latime),
                        (int)(rec.Bottom - vect[i] / vMax * rec.Height), (int)latime,
                        (int)(vect[i] / vMax * rec.Height));


                g.DrawString(vect[i].ToString(), font, br,
                    new Point((int)(recs[i].Location.X), (int)(recs[i].Location.Y - font.Height)));

            }
            g.FillRectangles(br, recs);
        }

        void pd_print_piechart(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
            Brush br = Brushes.White;
            Pen pen = new Pen(br, 4);
            Rectangle rec = new Rectangle(new Point(e.PageBounds.Location.X, e.PageBounds.Location.Y), new Size(e.PageBounds.Width / 2, e.PageBounds.Height));
            g.DrawRectangle(pen, rec);
            Rectangle rec2 = new Rectangle(new Point(e.PageBounds.Location.X + e.PageBounds.Width / 2, e.PageBounds.Location.Y), new Size(e.PageBounds.Width / 2, e.PageBounds.Height));
            g.DrawRectangle(pen, rec2);

            double[] vect = new double[4];
            vect[0] = 0;   // primele asig bunuri PF
            vect[1] = 0;   // prime asig viata PF
            vect[2] = 0;  // prime asif bunuri PJ
            vect[3] = 0;  //prime asig viata PJ


            foreach (Client c in listaClienti)
            {
                if (c.TipClient == "PF")
                {
                    foreach (Asigurare a in c.Asigurari)
                    {
                        if (a.TipAsig == "b")
                            vect[0] += a.Prima;
                        else if (a.TipAsig == "v")
                            vect[1] += a.Prima;
                    }
                }
                else if (c.TipClient == "PJ")
                {
                    foreach (Asigurare a in c.Asigurari)
                    {
                        if (a.TipAsig == "b")
                            vect[2] += a.Prima;
                        else if (a.TipAsig == "v")
                            vect[3] += a.Prima;
                    }
                }
            }

            double sum = vect.Sum();
            
            vect[0] = vect[0] / sum * 100;
            vect[1] = vect[1] / sum * 100;
            vect[2] = vect[2] / sum * 100;
            vect[3] = vect[3] / sum * 100;
            
            int pr1 = Convert.ToInt32(vect[0] / 100 * 360);
            int pr2 = (int)(vect[1] / 100 * 360);
            int pr3 = (int)(vect[2] / 100 * 360);
            int pr4 = (int)(vect[3] / 100 * 360);

            while (pr1 + pr2 + pr3 + pr4 != 360)
            {
                pr4++;
            }

            g.FillPie(Brushes.Red, rec, 0, pr1);
            g.FillPie(Brushes.Blue, rec, pr1, pr2);
            g.FillPie(Brushes.Yellow, rec, pr1 + pr2, pr3);
            g.FillPie(Brushes.Green, rec, pr1 + pr2 + pr3, pr4);

            int marginLeft = 30;
            int marginTop = 50;
            Brush br2 = new SolidBrush(Color.Black);
            g.DrawString("Asigurari bunuri PF", font, br2, new Point(rec2.Location.X + marginLeft, rec2.Location.Y + 2 * marginTop));
            g.FillRectangle(Brushes.Red,
                new Rectangle(new Point(rec2.Location.X + 8 * marginLeft, rec2.Location.Y + 2 * marginTop),
                new Size((int)font.Size * 2, (int)font.Size * 2)));
            g.DrawString("Asigurari viata PF", font, br2, new Point(rec2.Location.X + marginLeft, rec2.Location.Y + 3 * marginTop));
            g.FillRectangle(Brushes.Blue,
                new Rectangle(new Point(rec2.Location.X + 8 * marginLeft, rec2.Location.Y + 3 * marginTop),
                new Size((int)font.Size * 2, (int)font.Size * 2)));
            g.DrawString("Asigurari bunuri PJ", font, br2, new Point(rec2.Location.X + marginLeft, rec2.Location.Y + 4 * marginTop));
            g.FillRectangle(Brushes.Yellow,
                new Rectangle(new Point(rec2.Location.X + 8 * marginLeft, rec2.Location.Y + 4 * marginTop),
                new Size((int)font.Size * 2, (int)font.Size * 2)));
            g.DrawString("Asigurari viata PJ", font, br2, new Point(rec2.Location.X + marginLeft, rec2.Location.Y + 5 * marginTop));
            g.FillRectangle(Brushes.Green,
                new Rectangle(new Point(rec2.Location.X + 8 * marginLeft, rec2.Location.Y + 5 * marginTop),
                new Size((int)font.Size * 2, (int)font.Size * 2)));
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            if (contextMenuStrip1.SourceControl == panel1)
                pd.PrintPage += new PrintPageEventHandler(pd_print_barchart);
            else if(contextMenuStrip1.SourceControl == panel2)
                pd.PrintPage += new PrintPageEventHandler(pd_print_piechart);


            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void barchartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void piechartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
            Brush br = Brushes.White;
            Pen pen = new Pen(br,4);
            Rectangle rec = new Rectangle(new Point(panel2.Location.X, panel2.Location.Y), new Size(panel2.Width/2, panel2.Height));
            g.DrawRectangle(pen,rec);
            Rectangle rec2 = new Rectangle(new Point(panel1.Location.X+panel1.Width/2,panel1.Location.Y),new Size(panel1.Width/2,panel1.Height));
            g.DrawRectangle(pen,rec2);

            double[] vect = new double[4];
            vect[0] = 0;   // primele asig bunuri PF
            vect[1] = 0;   // prime asig viata PF
            vect[2] = 0;  // prime asif bunuri PJ
            vect[3] = 0;  //prime asig viata PJ


            foreach (Client c in listaClienti)
            {
                if (c.TipClient == "PF" && c.Asigurari!=null)
                {
                    foreach (Asigurare a in c.Asigurari)
                    {
                        if (a.TipAsig == "b")
                            vect[0] += a.Prima;
                        else if (a.TipAsig == "v")
                            vect[1] += a.Prima;
                    }
                }
                else if (c.TipClient == "PJ" && c.Asigurari!=null)
                {
                    foreach (Asigurare a in c.Asigurari)
                    {
                        if (a.TipAsig == "b")
                            vect[2] += a.Prima;
                        else if (a.TipAsig == "v")
                            vect[3] += a.Prima;
                    }
                }
            }
            
            double sum = vect.Sum();

            if (sum > 0)
            {
                vect[0] = vect[0] / sum * 100;
                vect[1] = vect[1] / sum * 100;
                vect[2] = vect[2] / sum * 100;
                vect[3] = vect[3] / sum * 100;
                if (vect[1] != 0 && vect[2] != 0 && vect[3] != 0)
                {
                    int pr1 = Convert.ToInt32(vect[0] / 100 * 360);
                    int pr2 = (int)(vect[1] / 100 * 360);
                    int pr3 = (int)(vect[2] / 100 * 360);
                    int pr4 = (int)(vect[3] / 100 * 360);


                    while (pr1 + pr2 + pr3 + pr4 != 360)
                    {
                        pr4++;
                    }

                    g.FillPie(Brushes.Red, rec, 0, pr1);
                    g.FillPie(Brushes.Blue, rec, pr1, pr2);
                    g.FillPie(Brushes.Yellow, rec, pr1 + pr2, pr3);
                    g.FillPie(Brushes.Green, rec, pr1 + pr2 + pr3, pr4);

                    int marginLeft = 30;
                    int marginTop = 50;
                    Brush br2 = new SolidBrush(Color.Black);
                    g.DrawString("Asigurari bunuri PF", font, br2, new Point(rec2.Location.X + marginLeft, rec2.Location.Y + 2 * marginTop));
                    g.FillRectangle(Brushes.Red,
                        new Rectangle(new Point(rec2.Location.X + 8 * marginLeft, rec2.Location.Y + 2 * marginTop),
                        new Size((int)font.Size * 2, (int)font.Size * 2)));
                    g.DrawString("Asigurari viata PF", font, br2, new Point(rec2.Location.X + marginLeft, rec2.Location.Y + 3 * marginTop));
                    g.FillRectangle(Brushes.Blue,
                        new Rectangle(new Point(rec2.Location.X + 8 * marginLeft, rec2.Location.Y + 3 * marginTop),
                        new Size((int)font.Size * 2, (int)font.Size * 2)));
                    g.DrawString("Asigurari bunuri PJ", font, br2, new Point(rec2.Location.X + marginLeft, rec2.Location.Y + 4 * marginTop));
                    g.FillRectangle(Brushes.Yellow,
                        new Rectangle(new Point(rec2.Location.X + 8 * marginLeft, rec2.Location.Y + 4 * marginTop),
                        new Size((int)font.Size * 2, (int)font.Size * 2)));
                    g.DrawString("Asigurari viata PJ", font, br2, new Point(rec2.Location.X + marginLeft, rec2.Location.Y + 5 * marginTop));
                    g.FillRectangle(Brushes.Green,
                        new Rectangle(new Point(rec2.Location.X + 8 * marginLeft, rec2.Location.Y + 5 * marginTop),
                        new Size((int)font.Size * 2, (int)font.Size * 2)));
                }
            }
            else
            {
                MessageBox.Show("Pie Chart poate fi afisat doar daca exista asigurari in baza de date!");
                this.Close();
            }
        }
    }
}
