using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            List<int> allNumbers = new List<int>();
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            Console.WriteLine("Enter 12 numbers");
            for (int i = 0; i < 12; i++)
            {
                int number;
                while (true)
                {
                    Console.Write($"Number {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        allNumbers.Add(number);
                        if (number % 2 == 0)
                            evenList.Add(number);
                        else
                            oddList.Add(number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
            }
            Console.WriteLine("\nAll Entered Numbers (Original):");
            Console.WriteLine(string.Join(", ", allNumbers));

            Console.WriteLine("\nEven Numbers:");
            Console.WriteLine(string.Join(", ", evenList));

            Console.WriteLine("\nOdd Numbers:");
            Console.WriteLine(string.Join(", ", oddList));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
        

    
