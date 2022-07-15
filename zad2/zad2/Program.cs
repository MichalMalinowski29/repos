using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {

        class FizzBuzz
        {
            public void func1()
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        if (i % 5 == 0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else
                        {
                            Console.WriteLine("Fizz");
                        }
                        
                    }
                    else if (i % 5 == 0)
                    {

                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                    
                }
            }
        }

        static void Main(string[] args)
        {
            FizzBuzz zad2 = new FizzBuzz();
            zad2.func1();
        }
    }
}
