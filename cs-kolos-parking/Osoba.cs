using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kolos_parking
{
    internal class Osoba
    {
        string Imie;
        string Nazwisko;
        string pesel;


        public override string ToString()
        {
            string result = $"{Imie} {Nazwisko} {pesel}";
            return result;
        }

    }
}
