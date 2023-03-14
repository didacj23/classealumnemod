using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classealumneprojecte
{
    internal class Modul
    {
        //Atributs
        private string nom;
        private const int mida_per_defecte=5; //mida màxima per defecte
        private Alumne[] alumnes; //array tipus alumne
        private int pos_ultim_element;


        //Constructors
        public Modul(int mida)
        {
            alumnes = new Alumne[mida];
            pos_ultim_element=-1;
        }

        public Modul():this(mida_per_defecte)
        {
            
        }

        public Modul(Modul m1)
        {
            Console.WriteLine("Nom del nou objecte: ");
            string nomNou=Console.ReadLine();

            Modul m2 = new Modul(m1.NumAlumnes);

            m2.Nom=m1.Nom;
            m2.alumnes=m1.alumnes;
            m2.NumAlumnes=m1.NumAlumnes;
        }

        
        //Propietats
        public int NumAlumnes
        {
            get {return pos_ultim_element+1;}
            set { pos_ultim_element=value;}
        }

        public string Nom
        {
            get { return  nom; }
            set { nom = value; }
        }


        //Mètode privat index
        private int Index(string possible_nom_nif)
        {
            int index=-1;

            for(int i = 0; i<NumAlumnes; i++)
            {
                if (possible_nom_nif == alumnes[i].nif) index=i; //es un nif
                else if (possible_nom_nif == alumnes[i].Nom+" " + alumnes[i].Cognom) index=i; //es un nom complet
            }

            return index;
        }


        //Indexadors
        public Alumne this[string possible_nom_nif]
        {            
            get{
                int index=0;
                index=Index(possible_nom_nif);                
                return alumnes[index];
            }
        }


        //Mètodes públics
        public void Afegir(Alumne a)
        {
            if(alumnes.Length==pos_ultim_element-1) Array.Resize(ref alumnes, 1);

            alumnes[pos_ultim_element+1] = a;
            pos_ultim_element++;
        }

        public void Modificar(Alumne a)
        {
            int index=Index(a.Nom+" "+a.Cognom); //?

            if(index!=-1)
            {
                alumnes[index] = a;
            }

        }

        public void Eliminar(string nom_complet)
        {
            int index=Index(nom_complet);

            for(int i=index; i<pos_ultim_element-1; i++)
            {
                alumnes[i] = alumnes[i+1];
                pos_ultim_element--;
            }
        }

        public void Consultar(string nom_complet)
        {
            int index = 0;
            index = Index(nom_complet);

            return alumnes[nom_complet];

        }

        public string GetTelefon(string nom_alumne)
        {
            string telefon="";
            int index=Index(nom_alumne);

            if(index!=-1) telefon = alumnes[index].Telefon;            

            return telefon;
        }


        //SOBREESCRIPTURA DE MÈTODES
        public override string ToString()
        {
            string res="";

            for(int i = 0;i<pos_ultim_element;i++)
            {
                res += alumnes[i]+",";
            }
            return res;
        }        

        public /*override*/ bool Equals(Modul m) //em fa treure el override
        {
            bool iguals=false;

            if(Nom==m.Nom)iguals=true;

            return iguals;
        }

        //public override int GetHashCode();
        
    }
}
