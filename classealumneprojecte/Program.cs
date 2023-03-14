namespace classealumneprojecte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prova 1
            Console.WriteLine("Prova 1:");
            Alumne alumne1 = new Alumne();
            Console.Write("Introdueix el nom: ");
            alumne1.Nom = Console.ReadLine();
            Console.Write("Introdueix el cognom: ");
            alumne1.Cognom = Console.ReadLine();
            Console.Write("Introdueix la data de naixement (dd/mm/yyyy): ");
            alumne1.DataNaixement = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Edat: " + alumne1.Edat());
            Console.WriteLine("Introdueix el NIF: ");
            alumne1.Nif = Console.ReadLine();
            Console.WriteLine("Introdueix el email: ");
            alumne1.Email = Console.ReadLine();
            Console.WriteLine("Introduexi el Telefon: ");
            alumne1.Telefon = Console.ReadLine();
            Console.WriteLine("Introdueix el sexe: (H|D)");
            alumne1.Sexe = Convert.ToChar(Console.ReadLine());
            //prova 1

            //prova 2
            Console.WriteLine('\n');
            Console.WriteLine("Prova 2:");
            Alumne alumne2 = new Alumne("Joan", "Pons", "12345678A");
            Console.Write("Introdueix la data de naixement (dd/mm/yyyy): ");
            alumne2.DataNaixement = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Edat: " + alumne2.Edat());
            Console.WriteLine("Introdueix el email: ");
            alumne2.Email = Console.ReadLine();
            Console.WriteLine("Introdueix el telefon: ");
            alumne2.Telefon = Console.ReadLine();
            Console.WriteLine("Introdueix el sexe: (H|D)");
            alumne2.Sexe = Convert.ToChar(Console.ReadLine());
            //prova 2

            //prova 3
            Console.WriteLine('\n');
            Console.WriteLine("Prova 3:");
            Alumne alumne3 = new Alumne("Maria", "Garcia", "12345678A", new DateTime(1996, 5, 23), 'D', "maria.garcia@gmail.com", "666888999", 0);

            Alumne alumne4 = new Alumne(alumne3);
            Alumne alumne5 = new Alumne(alumne3);
            Alumne alumne6 = new Alumne(alumne3);

            Console.WriteLine("Alumnes creats: " + alumne3.NumALumnes);

            Console.WriteLine(" \n Primer copia:");
            Console.WriteLine(alumne4.ToString());
            Console.WriteLine(" \n Segona copia:");
            Console.WriteLine(alumne5.ToString());
            Console.WriteLine(" \n Tercera copia:");
            Console.WriteLine(alumne6.ToString());

            Console.WriteLine('\n');

            Console.WriteLine("Els alumnes 2 i 3 són iguals? " + alumne2.Equals(alumne3));
            Console.WriteLine("Els alumnes 4 i 5 són iguals? " + alumne4.Equals(alumne5));
            Console.WriteLine("Els alumnes 5 i 6 són iguals? " + alumne5.Equals(alumne6));
            Console.WriteLine("Els alumnes 3 i 4 són iguals? " + alumne3.Equals(alumne4));





            //prova 3



        }
    }
}