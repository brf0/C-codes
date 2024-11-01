using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrimeNumbersBetween
{
    class Program
    {
        static void Main(string[] args)
            //When we define a member as static, the member belongs to the class itself, not to a specific object of that class.
        {
            Console.Write("Enter the first number (m): ");
            int m = int.Parse(Console.ReadLine()); /*دستور Parse برای تبدیل رشته‌ها به نوع دیگری از داده‌ها استفاده می‌شود.*/

            Console.Write("Enter the second number (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {m} and {n}:"); 
            //کاراکتر $ به شما این امکان را می‌دهد که متغیرها و عبارات را مستقیماً درون یک رشته قرار دهید 
            //این کار باعث ساده‌تر شدن قالب‌بندی رشته‌ها و بهبود خوانایی کد می‌شود.

            // Loop through each number between m and n
            for (int i = Math.Min(m, n); i <= Math.Max(m, n); i++) /*The expression(Math.Min(m, n) calculates the smaller value between m and n and places it in variable i.*/
                //And the expression i <= Math.Max(m, n) means that the value of i is compared with the larger value between m and n.This expression checks whether the value of i is less than or equal to the largest value between m and n.
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Function to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++) 
                //The expression i <= Math.Sqrt(number) means that the value of i is compared with the square root of number.This expression checks whether the value of i is less than or equal to the square root of number.
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}