namespace classealumneprojecte
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1. Crear mòdul\n"+
                              "2. Mostrar mòduls\n"+
                              "3. Afegir alumnes al mòdul\n"+                             
                              "4. Modificar alumne del modul\n"+
                              "5. Eliminar alumne del modul\n"+
                              "6. Consultar alumne modul\n"+
                              "7. Mostrar telèfon alumne modul");
            Console.WriteLine("Introdueix una opció: (1-9) ");
            int opcio=Convert.ToInt32(Console.ReadLine());

            switch (opcio)
            {
                case 1:
                    Console.Write("Nom del modul: ");
                    string nomModul=Console.ReadLine();

                    Console.Write("Mida màxima de la taula alumnes: ");
                    int midaMaxima=Convert.ToInt32(Console.ReadLine());

                    Modul m1 = new Modul(midaMaxima);
                    m1.Nom=nomModul;
                    break;
                
                case 2:
                    break;

                case 3:
                    
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 9:
                    break;

            }
        }
    }
}