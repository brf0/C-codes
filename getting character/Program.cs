using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getting_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter a character: ");

                // Read a single key from the console
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                char inputChar = keyInfo.KeyChar; /*This line of code stores the character that the user pressed on the keyboard in the inputChar variable*/
                //Console.ReadKey is a method that waits for the user to press a key on the keyboard and then returns information about that key.
                //The parameter intercept: true tells the ReadKey method not to display the pressed key if this option is true, otherwise the pressed key will be displayed in the console.

                // Check if the input is a letter (character)
                if (char.IsLetter(inputChar)) /* it is a static method of the char class that checks whether the input character(inputChar here) is an alphabet letter(such as A-Z or a-z) or not.This method returns true if the character is a letter, otherwise it returns false.*/
                {
                    Console.WriteLine($"\nYou entered the character {inputChar}");
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a character (A-Z or a-z).");
                }
            }
        }
    }
}
