using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAsigurariPaw
{
    public abstract class Asigurare
    {
        private int nrAsigurare;
        private float sumaAsigurata;
        protected DateTime dataIncheierePolita;
        protected int durataValabilitate;
        protected DateTime dataInceput;
        private float primaDeAsigurare;
        private int procentComision;
        private string tipAsig;

        public Asigurare()
        {
            this.nrAsigurare = 0;
            this.sumaAsigurata = 0;
            this.dataIncheierePolita = DateTime.Parse("Jan 1, 1000");
            this.durataValabilitate = 0;
            this.dataInceput = Convert.ToDateTime("Jan 1, 1000");
            this.primaDeAsigurare = 0;
            this.procentComision = 0;
            this.tipAsig = "---";
        }

        public Asigurare(int nrAsig, float sumaAsigurata, DateTime dataIncheierePolita, int durata,
            DateTime dataInceput, float prima, int procentComision,string tip)
        {
            this.nrAsigurare = nrAsig;
            this.sumaAsigurata = sumaAsigurata;
            this.dataIncheierePolita = dataIncheierePolita;
            this.durataValabilitate = durata;
            this.dataInceput = dataInceput;
            this.primaDeAsigurare = prima;
            this.procentComision = procentComision;
            this.tipAsig = tip;
        }

        public override string ToString()
        {
            return 
                Environment.NewLine + 
                "Asigurarea nr. " + this.nrAsigurare + Environment.NewLine + 
                "____________________________ " + Environment.NewLine +
                "Valabilitate: " + (this.durataValabilitate==1?"o luna":this.durataValabilitate + " luni") + Environment.NewLine +
                "____________________________ " + Environment.NewLine +
                "Suma asigurata: " + this.sumaAsigurata + Environment.NewLine + 
                "____________________________ " + Environment.NewLine + 
                "Prima: " + this.primaDeAsigurare + Environment.NewLine + 
                "____________________________ " + Environment.NewLine +
                "Data inceput: " + this.dataInceput.Day + "/" + this.dataInceput.Month + "/" + this.dataInceput.Year;
        }
        public int NrAsigurare {
            get { return this.nrAsigurare; }
            set { if (value > 0)
                    this.nrAsigurare = value;
            }
        }
       
        public int ProcentComision
        {
            get { return this.procentComision; }
            set { if (value > 0 && value < 100)
                    this.procentComision = value;
                     }
        }
        public float Prima{
            get { return this.primaDeAsigurare; }
            set { if (value > 0)
                    this.primaDeAsigurare = value;
            }
        }

        public float SumaAsigurata
        {
            get { return this.sumaAsigurata; }
            set { if (value > 0)
                    this.sumaAsigurata = value;
            }
        }
        public string TipAsig
        {
            get { return this.tipAsig; }
        }
    }
}
