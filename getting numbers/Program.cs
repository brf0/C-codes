using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getting_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter a number: ");
                string input = Console.ReadLine();

                // Try to parse the input as an integer
                if (int.TryParse(input, out int number))
                    //:int.TryParse is a method that tries to convert the input string value to an integer(int).Returns true if successful; otherwise, it returns false.
                    //The statement:out int number stores the numerical value of the input in this number variable if the conversion is successful.The out keyword means that this variable is set as an output from the TryParse method.
                    //The if (int.TryParse(input, out int number)) statement specifically checks whether the input value can be converted to an integer.If the conversion is successful, the numerical value is stored in the number variable and the if block is executed; Otherwise, the if block will not be executed.
                {
                    Console.WriteLine($"You entered the number {number}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
        }
    }
}
