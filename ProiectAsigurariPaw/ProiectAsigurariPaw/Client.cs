using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAsigurariPaw
{
    public abstract class Client
    {
        private int cod_client;
        private string adresa;
        private string nrTelefon;
        private string email;
        private string tipClient;
        private ArrayList asigurari;

        public Client()
        {
            cod_client = -1;
            adresa = "---";
            nrTelefon = "---";
            email = "---";
            asigurari = null;
        }

        public Client(int cod,string adresa,string nrTel,string email,string tipClient, ArrayList lista)
        {
            this.cod_client = cod;
            this.adresa = adresa;
            this.nrTelefon = nrTel;
            this.email = email;
            this.tipClient = tipClient;
            this.asigurari = lista;
        }

        public override string ToString()
        {
            string res = "";
            res += "adresa: " + this.adresa + " nr tel: " + this.nrTelefon + " email: " + this.email +
                " are asigurarile: ";
            if(this.asigurari !=null)
            for (int i = 0; i < this.asigurari.Count; i++)
                res += "\n  " + (i + 1) + ":" + this.asigurari[i].ToString();
            return res ;
        }
        
        public void adaugaAsigurare(Asigurare asig)
        {
            this.asigurari.Add(asig);

        }
        public void stergeAsigurare(Asigurare asig)
        {
            this.asigurari.Remove(asig);
        }

        public ArrayList Asigurari
        {
          get{ return this.asigurari; }
            set{ if(value!=null)
                    this.asigurari=value; }
        }
        public object this[int index]
        {
            get
            {
                if (asigurari != null && index >= 0 && index < asigurari.Count)
                    return asigurari[index];
                else return 0;
            }
            set
            {
                if (value!= null && index >= 0 && index < asigurari.Count)
                    asigurari[index] = value;
            }
        }
        public int Cod_client
        {
            get { return this.cod_client; }
            set { this.cod_client = value;}
        }
        public string Adresa {
            get { return this.adresa; }
            set { if (value != null) this.adresa = value; }
        }
        public string NrTelefon
        {
            get { return this.nrTelefon; }
            set { if (value != null) this.nrTelefon = value; }
        }
        public string Email {
            get { return this.email; }
            set { if (value != null)
                    this.email = value;
            }
        }
        public string TipClient
        {
            get { return this.tipClient; }
        }
    }
}
