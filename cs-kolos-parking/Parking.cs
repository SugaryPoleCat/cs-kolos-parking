using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace cs_kolos_parking
{
    [Serializable]
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

        public Parking(string _nazwa) : this()
        {
            nazwa = _nazwa;
        }

        public void DodajMiejsce(MiejsceParkingowe mp)
        {
            if (mp.wolne && mp.wlasciciel == null)
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
                if (MiejscaWolne.Count < 1)
                {
                    throw new Exception();
                }
                MiejsceParkingowe mp = MiejscaWolne.Find(mw => mw.wolne == true);
                // ustaw wlasciiela
                mp.wlasciciel = os;
                DodajMiejsce(mp);
                MiejscaWolne.Remove(mp);
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
            MiejscaZajete.Remove(mp);
        }

        public static List<MiejsceParkingowe> Sortuj(Parking par) 
        {
            /* MiejscaZajete.Sort(p => p.wlasciciel.Imie && p.wlasciciel.Nazwisko);
             return MiejscaZajete;*/

            var t = par.MiejscaZajete;
            t.Sort();
            return t;
        }
        public override string ToString()
        {
            string result = $"{nazwa} zajete: {MiejscaZajete.Count}, wolne: {MiejscaWolne.Count}";
            return result;
        }

        public void ZapiszBIN(string nazwaPliku)
        {
            try
            {
                FileStream fs = new FileStream(nazwaPliku + ".bin", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, nazwaPliku);
                Console.WriteLine("Plik zapisano");
                fs.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public object OdczytajBIN(string nazwaPliku)
        {
            try
            {
                FileStream fs = new FileStream(nazwaPliku + ".bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object p = bf.Deserialize(fs);
                fs.Close();
                return p;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
