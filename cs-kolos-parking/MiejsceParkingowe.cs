﻿using System;

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
        public MiejsceParkingowe()
        {
            // kod

            numerMiejsca = ++biezacyNumerMiejsca;
            nrMiesiaca = (int)(DateTime.Now.DayOfWeek - 1);
            wolne = true;
        }

        public MiejsceParkingowe(Osoba wlasciciel)
        {
            wolne = false;
            numerMiejsca = ++biezacyNumerMiejsca;
            this.wlasciciel = wlasciciel;
        }

        public override string ToString()
        {
            string result = $"{numerMiejsca}:";
            // sprawdznie czy miejsce jest wolne czy nie
            if (!wolne)
            {
                result += $" {wlasciciel.ToString()}";
            }
            else
            {
                result += " MIEJSCE WOLNE";
            }
            result += $", {oplata.ToString("C")}";
            return result;
        }

        public string Zaplac(int nrMiesiaca)
        {
            this.nrMiesiaca = nrMiesiaca;
            string result = $"Pan / i {wlasciciel.Imie} {wlasciciel.Nazwisko} uiścil oplate w kwocie: {oplata} za miesiac: {this.nrMiesiaca}";
            return result;
        }

        public void Zwolnij()
        {
            wolne = true;
            wlasciciel = null;
        }
    }
}
