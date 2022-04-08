using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontorllib andmete pikkust eraldi
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit ja perekonnanimes {lastName.Length} sümbolit.");

            if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Seega on sinu perekonnanimi pikem.");
            }
            else if (lastName.Length < firstName.Length)
            {
                Console.WriteLine("Seega on sinu eesnimi pikem.");
            }
            else
            {
                Console.WriteLine("Seega on sinu eesnimi ja perekonnanimi sama pikad.");
            }
                
           
                
            
        }
    }
}
