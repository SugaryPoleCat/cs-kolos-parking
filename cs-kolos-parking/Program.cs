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
            MiejsceParkingowe miejsce5 = new MiejsceParkingowe(dupa);
            MiejsceParkingowe miejsce6 = new MiejsceParkingowe(maciek);


            Console.WriteLine(maciek.ToString());
            Console.WriteLine(dupa.ToString());

            Console.WriteLine(miejsce1.ToString());
            Console.WriteLine(miejsce2.ToString());
            Console.WriteLine(miejsce3.ToString());
            Console.WriteLine(miejsce4.ToString());

            Console.WriteLine(miejsce2.Zaplac(2));

            miejsce2.Zwolnij();

            Console.WriteLine(miejsce2.ToString());

            Parking p1 = new Parking("Jebix");
            Parking p2 = new Parking("Chujex");

            p1.DodajMiejsce(miejsce1);
            p2.DodajMiejsce(miejsce2);
            p1.DodajMiejsce(miejsce3);
            p2.DodajMiejsce(miejsce4);
            p2.DodajMiejsce(miejsce5);
            p2.DodajMiejsce(miejsce6);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            p1.WynajmijMiejsce(maciek);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(miejsce1.ToString());
            Console.WriteLine(miejsce3.ToString());

            p2.ZwolnijMiejsce(104);

            Console.WriteLine(p2.ToString());
            Console.WriteLine(miejsce2.ToString());
            Console.WriteLine(miejsce4.ToString());

            var aaa = Parking.Sortuj(p2);
            foreach (MiejsceParkingowe p in aaa)
            {
                Console.WriteLine(p);
            }

            p1.ZapiszBIN("Jebix");
            p1.WynajmijMiejsce(dupa);

            Console.WriteLine(p1.ToString());

            p1.OdczytajBIN("Jebix");

            Console.ReadKey();
        }
    }
}
