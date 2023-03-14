using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace classealumneprojecte
{
    internal class Alumne
    {

        private String nom;
        private String cognom;
        private String nif;
        private DateTime dataNaixement;
        private char sexe;
        private String email;
        private int telefon;
        private int numAlumnes = 0;

        //constructors
        public Alumne()
        {
            this.nom = "";
            this.cognom = "";
            this.nif = "";
            this.dataNaixement = DateTime.MinValue;
            this.sexe = ' ';
            this.email = "";
            this.telefon = 0;
            this.numAlumnes = 0;
        }

        public Alumne(string nom, string cognom, string nif)
        {
            Nom = nom;
            Cognom = cognom;
            Nif = nif;
        }

        public Alumne(string nom, string cognom, string nif, DateTime dataNaixement, char sexe, string email, int telefon, int numAlumnes)
        {
            this.nom = nom;
            this.cognom = cognom;
            this.nif = nif;
            this.dataNaixement = dataNaixement;
            this.sexe = sexe;
            this.email = email;
            this.telefon = telefon;
            this.numAlumnes = numAlumnes;
        }

        public Alumne(Alumne altreAlumne)
        {
            Nom = altreAlumne.Nom;
            Cognom = altreAlumne.Cognom;
            Nif = altreAlumne.Nif;
            dataNaixement = altreAlumne.dataNaixement;
            Sexe = altreAlumne.Sexe;
            Email = altreAlumne.Email;
            Telefon = altreAlumne.Telefon;
            NumAlumnes = altreAlumne.NumAlumnes;
        }



        //propietats

        public string Nom
        {
            get { return nom; }
            set
            {
                foreach (char i in value)
                {
                    if (Char.IsDigit(i))
                    {
                        throw new ArgumentException("El nom no pot contenir números");
                    }
                }
                nom = value;
            }
        }


        public string Cognom
        {
            get { return cognom; }
            set
            {
                foreach (char i in value)
                {
                    if (Char.IsDigit(i))
                    {
                        throw new ArgumentException("El Cognom no pot contenir números");
                    }
                }
                nom = value;
            }
        }

        public string Nif
        {
            get { return nif; }
            set
            {
                string patro = @"^\d{8}[A-Z]$";
                if (Regex.IsMatch(value, patro))
                {
                    nif = value;
                }
                else
                {
                    throw new ArgumentException("El valor del NIF no té el format correcte.");
                }
            }

        }

        //Per a la propietat de data de naixament he escollit un rang d'edat d'entre 0 a 20 anys

        public DateTime DataNaixament
        {
            get { return dataNaixement; }
            set
            {
                DateTime avui = DateTime.Today;
                DateTime fa20Anys = avui.AddYears(-20);
                if (value >= fa20Anys && value <= avui)
                {
                    dataNaixement = value;
                }
                else
                {
                    throw new ArgumentException("La data de data naixement ha de ser dins dels últims 20 anys.");
                }
            }
        }

        public char Sexe
        {
            get { return sexe; }
            set
            {
                if(sexe != 'H' || sexe != 'D')
                {
                    throw new ArgumentException("El valor ha de ser H o D, recorda que s'ha d'escriure amb majúscules");
                }
                else
                {
                    sexe = value;
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                string patro = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|cat|es)$";
                if (Regex.IsMatch(value, patro))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("El format de l'email no és vàlid.");
                }
            }
        }

        public int Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public int NumAlumnes
        {
            get { return numAlumnes; }
            set { numAlumnes = value; }
        }


    }
}
