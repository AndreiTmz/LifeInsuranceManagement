using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProiectAsigurariPaw.FormaJuridica;

namespace ProiectAsigurariPaw
{
    public class PersoanaJuridica : Client,IComparable,ICloneable
    {
        private string CUI;
        private string nrRegCom;
        private string numeFirma;
        private formaJuridica frmJur;
        private  string reprezentant;
        // tip polita obligatorie

        public PersoanaJuridica() : base()
        {
            this.CUI = "";
            this.nrRegCom = "";
            this.numeFirma = "---";
            this.frmJur = formaJuridica.SRL;
            this.reprezentant = "---";
        }
        public PersoanaJuridica(int cod,string adresa, string nrTel, string email, string tipCl,
            ArrayList lista, string CUI, string regCom,
            string nume, formaJuridica frmJuridica, string reprezentant) :
            base(cod,adresa, nrTel, email,tipCl, lista)
        {
            this.CUI = CUI;
            this.nrRegCom = regCom;
            this.numeFirma = nume;
            this.frmJur = frmJuridica;
            this.reprezentant = reprezentant;
        }

        public object Clone()
        {
            PersoanaJuridica clona = (PersoanaJuridica)this.MemberwiseClone();
            ArrayList asigurariClona = (ArrayList)Asigurari.Clone();
            clona.Asigurari = asigurariClona;
            return clona;
        }

        public int CompareTo(object obj)
        {
            PersoanaJuridica pj = (PersoanaJuridica)obj;
            return string.Compare(this.numeFirma, pj.numeFirma);
        }

        public override string ToString()
        {
            string res = "Firma  " + this.numeFirma + " " + this.frmJur +
                ", cu CUI " + this.CUI + " reprezentata de " + this.reprezentant + "," + base.ToString();

            return res;
        }

        public string CodUnicIdentificare
        {
            get { return this.CUI; }
            set { if (value != null)
                    this.CUI = value;
            }
        }
        public string nrRegistruComert
        {
            get { return this.nrRegCom; }
            set { if (value != null)
                    this.nrRegCom = value;
            }
        }
        public string DenumireFirma
        {
            get { return this.numeFirma; }
            set { if (value != null)
                    this.numeFirma = value;
            }
        }
        public formaJuridica FormaJrd
        {
            get { return this.frmJur; }
            set {
                this.frmJur = value;
                    }
        }
        public string NumeReprezentant
        {
            get { return this.reprezentant; }
            set { if (value != null)
                    this.reprezentant = value;
                }
        }

    }
}
