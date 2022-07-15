using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        class Fib
        {

            public void obl()
            {
                int x = 0;
                int y = 1;
                int z;

                Console.WriteLine("Jeżeli chcesz odczytać z konsoli wpisz: 1");
                Console.WriteLine("Jeżeli chcesz odczytać z pliku wpisz: 2");

                string a = Console.ReadLine();

                if(a == "1")
                {
                    Console.WriteLine("Podaj ilość wykonania obliczeń: ");
                    string pom = Console.ReadLine(); 
                    Console.WriteLine("0 znak ciągu to: 0");
                    Console.WriteLine("1 znak ciągu to: 1");
                    for (int i = 2; i <= Int32.Parse(pom); i++)
                    {
                        Console.WriteLine(i.ToString() + " znak ciągu to: " + (x + y).ToString());
                        z = x;
                        x = y;
                        y = z + y;

                    }
                }
                else if (a == "2")
                {
                    Console.WriteLine("Dane proszę umieścić w pliku plik.txt znajdującym się w folderze Debug");
                    string pom = File.ReadAllText(@"C:\Users\buzz\source\repos\ConsoleApp3\ConsoleApp3\bin\Debug\plik.txt", Encoding.UTF8);
                    Console.WriteLine("0 znak ciągu to: 0");
                    Console.WriteLine("1 znak ciągu to: 1");
                    for (int i = 2; i <= Int32.Parse(pom); i++)
                    {
                        Console.WriteLine(i.ToString() + " znak ciągu to: " + (x + y).ToString());
                        z = x;
                        x = y;
                        y = z + y;

                    }
                }
                else
                {
                    Console.WriteLine("Podano zły znak ");
                    Environment.Exit(0);
                }



            }
        }
        static void Main(string[] args)
        {
            Fib zad4 = new Fib();
            zad4.obl();

        }
    }
}
