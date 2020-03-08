using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAsigurariPaw
{
    public class AsigurareViata:Asigurare,IComparable,ICloneable
    {
        private string riscuriAcoperite;
        private string exceptii;
        private string informatii;

        public AsigurareViata():base()
        {
            this.riscuriAcoperite = "---";
            this.exceptii = "---";
            this.informatii = "---";
        }

        public AsigurareViata(int nrAsig, float sumaAsigurata, DateTime dataIncheierePolita, int durata,
            DateTime dataInceput, float prima, int procentComision,string tip, string riscuri, string exceptii,string info) : 
            base(nrAsig,sumaAsigurata,dataIncheierePolita,durata,dataInceput,prima,procentComision,tip)
        {
            this.riscuriAcoperite = riscuri;
            this.exceptii = exceptii;
            this.informatii = info;
        }

        public object Clone()
        {             
            return (AsigurareViata)this.MemberwiseClone(); ;
        }

        public int CompareTo(object obj)
        {
            AsigurareViata asig = (AsigurareViata)obj;
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
                "Riscuri acoperite: " +this.riscuriAcoperite + Environment.NewLine + 
                "_____________________________" + Environment.NewLine + 
                "Exceptii: " +this.Exceptii;
        }

        public string RiscuriAcoperite
        {
            get { return this.riscuriAcoperite; }
            set { if (value != null)
                    this.riscuriAcoperite = value;
            }
        }
        public string Exceptii
        {
            get { return this.exceptii; }
            set { if (value != null)
                    this.exceptii = value;

            }
        }
        public string Informatii
        {
            get { return this.informatii; }
            set
            {
                if (value != null)
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
            set { if (value >= 1)
                    this.durataValabilitate = value;
            }
        }
        public DateTime DataInceput
        {
            get { return this.dataInceput; }
            set { if (value != null)
                    this.dataInceput = value;
            }
        }
    }
}
