using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace mirror_number
{
    internal class Program
    {
        static void Main(string[] args)
            //The expression: string[] args is an array of strings that is sent as an input parameter to the Main method.This array is used to receive command line arguments.That is, when you run the program from the command line, you can give the program additional values ​​that are stored in this array.
            //If a method is defined with void , it means that the method does something(such as print some text or perform a calculation) but does not return any data to the place where it was called.
        {
            Console.Write("Enter the first number (m): ");
            int m = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Mirror numbers between {m} and {n}:");

            // Loop through each number between m and n
            for (int i = Math.Min(m, n); i <= Math.Max(m, n); i++)
            {
                if (IsMirrorNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Function to check if a number is a mirror number
        static bool IsMirrorNumber(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            // Reverse the number
            while (number > 0)
            {
                int digit = number % 10;
                //Here, a variable named digit is defined that stores the result number % 10.
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            // A mirror number is equal to its reverse
            return originalNumber == reversedNumber;
            //return is used to exit the function and return a value.

        }
    }
}
