using System;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        class Fibonacci
        {
            public void CalculateFibonacci()
            {
                int x = 0;
                int y = 1;
                int z;

                Console.WriteLine("Jeżeli chcesz odczytać z konsoli wpisz: 1");
                Console.WriteLine("Jeżeli chcesz odczytać z pliku wpisz: 2");

                string userInputMode = Console.ReadLine();

                if(userInputMode == "1")
                {
                    Console.WriteLine("Podaj ilość wykonania obliczeń: ");
                    string numberOfCalculations = Console.ReadLine(); 
                    Console.WriteLine("0 znak ciągu to: 0");
                    Console.WriteLine("1 znak ciągu to: 1");
                    for (int i = 2; i <= Int32.Parse(numberOfCalculations); i++)
                    {
                        Console.WriteLine(i.ToString() + " znak ciągu to: " + (x + y).ToString());
                        z = x;
                        x = y;
                        y = z + y;

                    }
                }
                else if (userInputMode == "2")
                {
                    Console.WriteLine("Dane proszę umieścić w pliku plik.txt znajdującym się w folderze Debug");
                    try
                    {
                        string textFromFile = File.ReadAllText(@"C:\Users\buzz\source\repos\zad4\ConsoleApp3\bin\Debug\plik.txt", Encoding.UTF8);
                        Console.WriteLine("0 znak ciągu to: 0");
                        Console.WriteLine("1 znak ciągu to: 1");
                        try
                        {
                            for (int i = 2; i <= Int32.Parse(textFromFile); i++)
                            {
                                Console.WriteLine(i.ToString() + " znak ciągu to: " + (x + y).ToString());
                                z = x;
                                x = y;
                                y = z + y;

                            }
                        }
                        catch
                        {
                            Console.WriteLine("W pliku powinna znajdować się liczba całkowita");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Wystąpił błąd. Jeżeli plik.txt nie nie istnieje proszę go utworzyć w folderze Debug");
                        Environment.Exit(0);
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
            Fibonacci zad4 = new Fibonacci();
            zad4.CalculateFibonacci();
        }
    }
}
