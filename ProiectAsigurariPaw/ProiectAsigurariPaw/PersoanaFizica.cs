using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAsigurariPaw
{
    public class PersoanaFizica:Client,IComparable,ICloneable
    {
        private string nume;
        private string prenume;
        private string CNP;
        
        public PersoanaFizica():base()
        {
            this.nume = "---";
            this.prenume = "---";
            this.CNP = "---";
        }

        public PersoanaFizica(int cod,string adresa, string nrTel, string email,string tipCl, ArrayList lista, string nume, string prenume, string CNP) :base(cod,adresa,nrTel,email,tipCl,lista)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.CNP = CNP;
        }

        public object Clone()
        {
            PersoanaFizica clona = (PersoanaFizica)this.MemberwiseClone();
            //List<Asigurare> asigurariClona = (List)(Asigurari.Clone());
            //clona.Asigurari = asigurariClona;
            return clona;
        }

        public int CompareTo(object obj)
        {
            PersoanaFizica pf = (PersoanaFizica)obj;
            return string.Compare(this.nume, pf.nume);
        }

        public override string ToString()
        {
            string res = "Clientul " + this.nume + " " + this.prenume +
                ", cu CNP " + this.CNP + "," + base.ToString();

            return res;
        }

        public string Nume
        {
            get { return this.nume; }
            set { if (value != null)
                    this.nume = value;
            }
        }
        public string Prenume
        {
            get { return this.prenume; }
            set { if (value != null)
                    this.prenume = value;
            }
        }
        public string CodNumericPersonal
        {
            get { return this.CNP;}
            set { if (value != null)
                    this.CNP = value;
            }
        }
    }
}
