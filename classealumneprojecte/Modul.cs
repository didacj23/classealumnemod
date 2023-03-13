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


        //Indexadors

        //Mètode privat index
        private int Index(string possible_nom_nif)
        {
            int index=0;

            for(int i = 0; i<NumAlumnes; i++)
            {
                if (possible_nom_nif == alumnes[i].nif) index=i; //es un nif
                else if (possible_nom_nif == alumnes[i].Nom+" " + alumnes[i].Cognom) index=i; //es un cognom
            }

            return index;
        }


        //Mètodes públics
        public void Afegir(Alumne a)
        {
            if(alumnes.Length==pos_ultim_element-1) Array.Resize(ref alumnes, 1);

            alumnes[pos_ultim_element+1] = a;
            pos_ultim_element++;
        }

        /*public void Modificar(Alumne a)
        {
            int index=0;

            for(int i=0;i<a.NumAlumnes-1;i++)
            {
                if (a.Nom == alumnes[i].Nom)index=i;
            }

            index=alumnes.IndexOf(alumnes,a.Nom==alumnes.Nom);
        }*/



        public string ToString()
        {
            string res="";

            for(int i = 0;i<pos_ultim_element;i++)
            {
                res += alumnes[i]+",";
            }
            return res;
        }

        
    }
}
