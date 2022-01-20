using System;
using System.Collections.Generic;

namespace cs_kolos_parking
{
    internal class Parking
    {
        string nazwa;
        List<MiejsceParkingowe> MiejscaZajete;
        List<MiejsceParkingowe> MiejscaWolne;

        public Parking()
        {
            MiejscaZajete = new List<MiejsceParkingowe>();
            MiejscaWolne = new List<MiejsceParkingowe>();
        }

        public void DodajMiejsce(MiejsceParkingowe mp)
        {
            if (mp.wolne)
            {
                MiejscaWolne.Add(mp);
            }
            else
            {
                mp.wolne = false;
                MiejscaZajete.Add(mp);
            }
        }
        public void WynajmijMiejsce(Osoba os)
        {
            try
            {
                // sprawdz czy jest minej niz 1 miejsce
                if (MiejscaZajete.Count < 1)
                {
                    throw new Exception();
                }
                MiejsceParkingowe mp = MiejscaWolne.Find(mw => mw.wolne == true);
                // ustaw wlasciiela
                mp.Wlasciciel = os;
                DodajMiejsce(mp);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ZwolnijMiejsce(int nrMiejsca)
        {
            MiejsceParkingowe mp = MiejscaZajete.Find(nrM => nrM.NumerMiejsca == nrMiejsca);
            mp.wolne = true;
            mp.Zwolnij();
            DodajMiejsce(mp);
        }
        public override string ToString()
        {
            string result = $"";
            return result;
        }
    }
}
