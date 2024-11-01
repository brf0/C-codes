using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your phone numbers:");
            string input = Console.ReadLine();

            List<string> phoneNumbers = ExtractValidPhoneNumbers(input); /* ExtractValidPhoneNumbers(input) is a method (or function) that extracts valid phone numbers using input.This method is supposed to process the input and return only valid phone numbers.*/
            //In short, this line of code extracts valid phone numbers from input and stores them in the phoneNumbers variable.

            if (phoneNumbers.Count > 0)
                //The statement if (phoneNumbers.Count > 0) means checking whether the number of elements in the phoneNumbers list is greater than zero or not.
            {
                Console.WriteLine("your phone number is ");
                foreach (string phoneNumber in phoneNumbers)
                  //The foreach keyword is used to iterate through collections(such as arrays, lists, and other enumerable data types). This keyword allows you to easily and safely access any element in an array without needing to use indexes.
                  //The general structure of a foreach loop is foreach (var item in collection).
                
                {
                    Console.WriteLine(phoneNumber);
                }
            }
            else
            {
                Console.WriteLine("the phone number is not valid.");
            }
        }

        static List<string> ExtractValidPhoneNumbers(string input)
        {
            List<string> validPhoneNumbers = new List<string>();

            // Regular expression to find 10-digit numbers starting with 0
            string pattern = @"\b0\d{9}\b";
              // At the beginning of the pattern(b\) indicates the boundary of a word.
              //0 specifies that the string should start with zero.
              //The expression \d{9} represents 9 digits after zero.
              //and \b defines the boundary at the end of the word.
              //Therefore, this pattern recognizes numbers like 0912345678 that start with zero and have exactly 10 digits.
            MatchCollection matches = Regex.Matches(input, pattern);
              //This code looks for matches in the input string using a regular pattern(Regex) and stores all the items that match the pattern in a collection(MatchCollection).

            foreach (Match match in matches)
            {
                string phoneNumber = match.Value;

                // Check if there are at least two different digits
                if (phoneNumber.Distinct().Count() > 1) /*This code checks if the phoneNumber string contains more than one unique character.*/
                {
                    validPhoneNumbers.Add(phoneNumber); /*This command adds the phoneNumber value to an array or list called validPhoneNumbers*/
                }
            }

            return validPhoneNumbers;
        }
    }
}
