using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kolos_parking
{
    internal class MiejsceParkingowe
    {
        Osoba wlasciciel;
        int numerMiejsca;
        Boolean wolne;
        int nrMiesiaca;
        static double oplata = 20;
        static int biezacyNumerMiejsca = 100;
        MiejsceParkingowe()
        {
            // kod

            biezacyNumerMiejsca++;
            nrMiesiaca = (int)(DateTime.Now.DayOfWeek - 1);
            wolne = true;
        }

        public MiejsceParkingowe(Osoba wlasciciel)
        {
            wolne = false;
            this.wlasciciel = wlasciciel;
        }

        public override string ToString()
        {
            string result = $"{numerMiejsca}: {wlasciciel.ToString()}, {oplata.ToString("C")}";
            return result;
        }
    }
}
