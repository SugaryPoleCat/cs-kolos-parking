using System;

namespace cs_kolos_parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba maciek = new Osoba("maciej", "nowak", "32984743928");
            Osoba dupa = new Osoba("dupa", "cycki", "98765432112");
            MiejsceParkingowe miejsce1 = new MiejsceParkingowe();
            MiejsceParkingowe miejsce2 = new MiejsceParkingowe(maciek);
            MiejsceParkingowe miejsce3 = new MiejsceParkingowe();
            MiejsceParkingowe miejsce4 = new MiejsceParkingowe(dupa);


            Console.WriteLine(maciek.ToString());
            Console.WriteLine(dupa.ToString());

            Console.WriteLine(miejsce1.ToString());
            Console.WriteLine(miejsce2.ToString());
            Console.WriteLine(miejsce3.ToString());
            Console.WriteLine(miejsce4.ToString());

            Console.WriteLine(miejsce2.Zaplac(2));

            miejsce2.Zwolnij();

            Console.WriteLine(miejsce2.ToString());

            Console.ReadKey();
        }
    }
}
