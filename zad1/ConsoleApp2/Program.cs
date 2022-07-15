using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{

    public class Zadania
        {
            public void zad1()
            {
                Console.WriteLine("Podaj odległośc w kilometrach: ");
                string km = Console.ReadLine();
                Console.WriteLine("Odległość w metrach wynosi: ");
                int zmienna = Int32.Parse(km) * 1000;
                Console.WriteLine(zmienna);
                File.WriteAllText("plik.txt", "Odległość w metrach wynosi: " + zmienna.ToString());
            }
        }


    internal class Program
    {
        static void Main(string[] args)
        {
            Zadania zadanie1 = new Zadania();
            zadanie1.zad1();
        }
    }
}
