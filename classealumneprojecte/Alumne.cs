using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
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
        private string telefon;
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
            this.telefon = "";
            this.numAlumnes = 0;
        }

        public Alumne(string nom, string cognom, string nif)
        {
            Nom = nom;
            Cognom = cognom;
            Nif = nif;
        }

        public Alumne(string nom, string cognom, string nif, DateTime dataNaixement, char sexe, string email, string telefon, int numAlumnes)
        {
            this.nom = nom;
            this.cognom = cognom;
            this.nif = nif;
            this.dataNaixement = dataNaixement;
            this.sexe = sexe;
            this.email = email;
            this.telefon = telefon;
            numAlumnes++;
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
            set { nom = NomValid(value); }
        }


        public string Cognom
        {
            get { return cognom; }
            set { cognom = CognomValid(value); }
        }

        public string Nif
        {
            get { return nif; }
            set { nif = NifValid(value); }

        }

        public DateTime DataNaixement
        {
            get { return dataNaixement; }
            set { dataNaixement = DataValid(value); }
        }

        public char Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = EmailValid(value); }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = TelfValid(value); }
        }

        public int NumAlumnes
        {
            get { return numAlumnes; }
            set { numAlumnes = NumALumnes(value); }
        }

        //métodes publics

        public int Edat()
        {
            int edat = DateTime.Today.Year - dataNaixement.Year;
            if(DateTime.Today.Month < dataNaixement.Month || DateTime.Today.Month == dataNaixement.Month && DateTime.Today.Day < dataNaixement.Day)
            {
                edat--;
            }

            return edat;
        }

        public int NumALumnes(int numAlumnes)
        {
            return numAlumnes;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nom: " + Nom);
            Console.WriteLine("Cognom: " + Cognom);
            Console.WriteLine("NIF: " + Nif);
            Console.WriteLine("Data de naixement: " + dataNaixement.ToString("dd/MM/yyyy"));
            Console.WriteLine("Edat: " + Edat() + " anys");
            Console.WriteLine("Sexe: " + Sexe);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Telefon: " + Telefon);
            Console.WriteLine("Nombre d'alumnes: " + NumAlumnes);

        }

        //Sobreescriptura de mètodes

        public override string ToString()
        {
            return $"Nom: {nom}\nCognom: {cognom}\nNIF: {nif}\nData de naixement: {dataNaixement.ToShortDateString()}\nSexe: {sexe}\nEmail: {email}\nTelèfon: {telefon}\n";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Alumne other = (Alumne)obj;
            return Nif == other.Nif;
        }

        //Sobrecarrega operadors

        public static bool operator ==(Alumne a, Alumne b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(Alumne a, Alumne b)
        {
            return !(a == b);
        }



        //métodes privats

        private string NomValid(string nom)
        {

            //Ho he trobat a stackoverflow es una manera de revisar que tots els caracters del string siguin lletres
            //amb l'exclamació invertim el valor de la condicio en cas de que no es compleixi el resultat sera true
            //el .all serveix per agafar tota la cadena la c es la variable que representa tots els caracters i chaar.IsLetter
            //comprova que la variable c en tot moments sigui una lletra

            while (!nom.All(c => char.IsLetter(c)))
            {
                Console.WriteLine("El nom no és valid, introdueix un de nou");
                nom = Console.ReadLine();
            }

            return nom;
        }

        private string CognomValid(string cognom)
        {
            while (!cognom.All(c => char.IsLetter(c)))
            {
                Console.WriteLine("El cognom no és valid, introdueix un de nou");
                cognom = Console.ReadLine();
            }

            return cognom;
        }

        private string NifValid(string nif)
        {
            string patro = @"^\d{8}[A-Z]$";
            while (!Regex.IsMatch(nif, patro))
            {
                Console.WriteLine("Introdueix un NIF vàlid");
                nif = Console.ReadLine();
            }

            return nif;
        }

        private DateTime DataValid(DateTime dataNaixement)
        {
            DateTime avui = DateTime.Now;
            bool valid = true;

            while (valid)
            {
                if (dataNaixement > avui)
                {
                    Console.WriteLine("La data de naixement es incorrecte, torna a introduir-la");
                    dataNaixement = Convert.ToDateTime(Console.ReadLine());
                }
                else
                    valid = false;


            }

            return dataNaixement;
        }

        private string EmailValid(string email)
        {
            string patro = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|cat|es)$";
            
            while(!Regex.IsMatch(email, patro))
            {
                Console.WriteLine("Introdueix un email vàlid");
                email = Console.ReadLine();
            }

            return email;
        }

        private string TelfValid(string telf)
        {
            while(!telf.All(c => char.IsDigit(c)))
            {
                Console.WriteLine("Introdueix un número vàlid");
                telf = Console.ReadLine();
            }

            return telf;
        }

        


    }
}
