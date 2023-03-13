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
        Alumne[] alumnes; //array tipus alumne
        int pos_ultim_element;

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
            m2.pos_ultim_element=m1.pos_ultim_element;
        }

        
        //Propietats
        public int NumAlumnes
        {
            get {return pos_ultim_element+1;}
        }

        public string Nom
        {
            get { return  nom; }
            set { nom = value; }
        }

        //Mètodes públics
        public void Afegir(Alumne a)
        {
            if(alumnes.Length==pos_ultim_element-1) Array.Resize(ref alumnes, 1);

            alumnes[pos_ultim_element+1] = a;
            pos_ultim_element++;
        }

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
