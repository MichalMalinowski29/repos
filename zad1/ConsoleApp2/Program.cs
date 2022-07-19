using System;
using System.IO;

namespace ConsoleApp2
{

    public class DistanceCalculator
    {
        public void ConvertToKilometers()
        {
            Console.WriteLine("Podaj odległośc w kilometrach: ");
            string km = Console.ReadLine();
            Console.WriteLine("Odległość w metrach wynosi: ");
            Console.WriteLine(Int32.Parse(km) * 1000);
            File.WriteAllText("plik.txt", "Odległość w metrach wynosi: " + (Int32.Parse(km) * 1000).ToString());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DistanceCalculator example = new DistanceCalculator();
            example.ConvertToKilometers();
        }
    }
}
