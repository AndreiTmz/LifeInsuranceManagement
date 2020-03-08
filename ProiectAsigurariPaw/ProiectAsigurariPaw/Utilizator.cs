using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAsigurariPaw
{
    public class Utilizator:IComparable,ICloneable
    {
        private int codAgent;
        private string nume, prenume, username, parola, email, telefon, adresa, admin;
        private ArrayList listaClienti;
        
        public Utilizator()
        {
            this.codAgent = 0;
            this.nume = "---";
            this.prenume = "---";
            this.username = "";
            this.parola = "";
            this.email = "---";
            this.telefon = "---";
            this.adresa = "---";
            this.admin = "nu";
            this.listaClienti = null;
        }
        public Utilizator(int cod, string nume,string prenume,string user, string pass, string email,
            string tel, string adresa,string admin, ArrayList listaClienti)
        {
            this.codAgent = cod;
            this.nume = nume;
            this.prenume = prenume;
            this.username = user;
            this.parola = pass;
            this.email = email;
            this.telefon = tel;
            this.adresa = adresa;
            this.admin = admin;
            if (listaClienti != null)
                this.listaClienti = listaClienti;
            else listaClienti = null;

        }

        public object Clone()
        {
            Utilizator clona = (Utilizator)this.MemberwiseClone();
            ArrayList utilizatoriClona = (ArrayList)listaClienti.Clone();
            clona.listaClienti = utilizatoriClona;
            return clona;
        }

        public int CompareTo(object obj)
        {
            Utilizator u = (Utilizator)obj;
            if(string.Compare(this.nume, u.nume) == 0)
            {
                if (this.codAgent < u.codAgent)
                    return -1;
                else if (this.codAgent > u.codAgent)
                    return 1;
                else
                    return 0;
            }
            else
                   return string.Compare(this.nume, u.nume);
        }

        public override string ToString()
        {
            string res = "Agentul" + this.nume + " " + this.prenume + " cu codul " + this.codAgent +
                " are urmatorii clienti: ";
            if (this.listaClienti != null)
                for (int i = 0; i < this.listaClienti.Count; i++)
                    res += "\n" + this.listaClienti[i].ToString();
            return res;
        }

        public int Cod
        {
            get { return this.codAgent; }
            set
            {
                if (value > 0)
                    this.codAgent = value;
            }
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
            set
            {
                if (value != null)
                    this.prenume = value;
            }
        }
        public string User
        {
            get { return this.username; }
            set
            {
                if (value != null)
                    this.username = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null)
                    this.email = value;
            }
        }
        public string Parola
        {
            get { return this.parola; }
            set
            {
                if (value != null)
                    this.parola= value;
            }
        }
        public string Telefon
        {
            get { return this.telefon; }
            set
            {
                if (value != null)
                    this.telefon = value;
            }
        }
        public string Adresa
        {
            get { return this.adresa; }
            set
            {
                if (value != null)
                    this.adresa = value;
            }
        }
        public string Admin
        {
            get { return this.admin; }
            set { if (value != null)
                    this.admin = value;
            }
        }
        public ArrayList ListaClienti
        {
            get { return this.listaClienti; }
            set
            {
                if (value != null)
                    this.listaClienti = value;
            }
        }

        public object this[int index]
        {
            get
            {
                if (listaClienti != null && index >= 0 && index < listaClienti.Count)
                    return listaClienti[index];
                else return 0;
            }
            set
            {
                if (value != null && index >= 0 && index < listaClienti.Count)
                    listaClienti[index] = value;
            }
        }
    }
}
