namespace cs_kolos_parking
{
    internal class Osoba
    {
        public string Imie;
        public string Nazwisko;
        string pesel;

        public override string ToString()
        {
            string result = $"{Imie} {Nazwisko} {pesel}";
            return result;
        }

        public Osoba(string Imie, string Nazwisko, string pesel)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.pesel = pesel;
        }

    }
}
