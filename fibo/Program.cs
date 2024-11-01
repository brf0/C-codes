using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibo
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Input two starting numbers and the target number
                Console.Write("Enter the first number (a1): ");
                int a1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number (a2): ");
                int a2 = int.Parse(Console.ReadLine());

                Console.Write("Enter the number to check (n): ");
                int n = int.Parse(Console.ReadLine());

                if (IsInFibonacciSeries(a1, a2, n))
                {
                    Console.WriteLine($"{n} is in the Fibonacci series starting with {a1} and {a2}.");
                }
                else
                {
                    Console.WriteLine($"{n} is NOT in the Fibonacci series starting with {a1} and {a2}.");
                }
            }

            static bool IsInFibonacciSeries(int a1, int a2, int n)
            {
                // If n is one of the starting numbers
                if (n == a1 || n == a2) return true;

                // Generate terms in the sequence until reaching or exceeding n
                int prev = a1;
                int current = a2;
            //The names prev and current are commonly used to hold the current and previous values.

                while (current < n)
                {
                    int next = prev + current;
                    prev = current;
                    current = next;

                    if (current == n) return true;
                }

                return false; // n was not found in the series
           
        }
    }
}
