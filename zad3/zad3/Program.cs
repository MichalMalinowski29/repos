using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        public class Aktor
        {
            public string Imie;
            public string Nazwisko;
            public Aktor(string imie, string nazwisko)
            {
                Imie = imie;
                Nazwisko = nazwisko;
            }

        }

        class Film
        {
            public string tytul;
            public List<Aktor> aktorzy = new List<Aktor>();

        }

        class Baza
        {
            public List<Aktor> aktorzyWszyscy = new List<Aktor>();
            public List<Film> filmy = new List<Film>();

            public Baza(List<Aktor> aktorzyWszyscy, List<Film> filmy)
            {
                this.aktorzyWszyscy = aktorzyWszyscy;
                this.filmy = filmy;
            }
        }

        static void Main(string[] args)
        {
            List<Aktor> aktorzyWszyscy = new List<Aktor>();
            aktorzyWszyscy.Add(new Aktor("Michał","Malinowski"));
            aktorzyWszyscy.Add(new Aktor("Mateusz", "Wasilewski"));
            aktorzyWszyscy.Add(new Aktor("Przemysław", "Dudek"));
            aktorzyWszyscy.Add(new Aktor("Jakub", "Malinowski"));

            List<Film> filmy = new List<Film>();

            filmy.Add(new Film)

        }
    }
}
