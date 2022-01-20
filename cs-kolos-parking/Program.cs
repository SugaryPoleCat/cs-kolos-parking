using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kolos_parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba maciek = new Osoba("maciej","nowak","32984743928");
            MiejsceParkingowe miejsce1 =new MiejsceParkingowe();
            MiejsceParkingowe miejsce2 = new MiejsceParkingowe(maciek);

            Console.WriteLine(maciek.ToString());

            Console.WriteLine(miejsce1.ToString());
            Console.WriteLine(miejsce2.ToString());

            Console.ReadKey();
        }
    }
}
