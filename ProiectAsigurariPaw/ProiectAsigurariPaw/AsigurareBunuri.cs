using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAsigurariPaw
{
    public class AsigurareBunuri : Asigurare, IComparable, ICloneable
    {
        private string bunuriAsigurate;
        private string informatii;

        public AsigurareBunuri() : base()
        {
            this.bunuriAsigurate = "---";
            this.informatii = "---";
        }
        public AsigurareBunuri(int nrAsig, float sumaAsigurata, DateTime dataIncheierePolita, int durata,
            DateTime dataInceput, float prima, int procentComision, string tip, string bunuriAsig, string info) :
            base(nrAsig, sumaAsigurata, dataIncheierePolita, durata, dataInceput, prima, procentComision, tip)
        {
            this.bunuriAsigurate = bunuriAsig;
            this.informatii = info;
        }

        public object Clone()
        {
            return (AsigurareBunuri)this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            AsigurareBunuri asig = (AsigurareBunuri)obj;
            if (this.dataIncheierePolita < asig.dataIncheierePolita)
                return -1;
            else if (this.dataIncheierePolita > asig.dataIncheierePolita)
                return 1;
            else if (this.NrAsigurare < asig.NrAsigurare)
                return -1;
            else if (this.NrAsigurare > asig.NrAsigurare)
                return 1;
            else return 0;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "_____________________________" + Environment.NewLine +
                "Bunuri asigurate: " + this.bunuriAsigurate;
        }

        public string BunuriAsigurate
        {
            get
            {
                return this.bunuriAsigurate;
            }
            set
            {
                if (value != null)
                    this.bunuriAsigurate = value;
            }
        }
        public string Informatii{
            get{ return this.informatii; }
            set { if (value != null)
                    this.informatii = value;
            }
    }
        public DateTime DataIncheierePolita
        {
            get { return this.dataIncheierePolita; }
            set { if (value != null) this.dataIncheierePolita = value; }
        }
        public int DurataVal
        {
            get { return this.durataValabilitate; }
            set
            {
                if (value >= 1)
                    this.durataValabilitate = value;
            }
        }
        public DateTime DataInceput
        {
            get { return this.dataInceput; }
            set
            {
                if (value != null)
                    this.dataInceput = value;
            }
        }

    }
}
