using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace decision_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
                Console.WriteLine("Were you born in the second half of the year? (yes/no)");
                string response = GetYesOrNoResponse();
                   //response is the name of a variable that can be used to store user responses, messages, or any type of text you need in your application.

                if (response == "yes")
                {
                    Console.WriteLine("Were you born in autumn? (yes/no)");
                    response = GetYesOrNoResponse();

                    if (response == "yes")
                    {
                        Console.WriteLine("Were you born in October? (yes/no)");
                        response = GetYesOrNoResponse();

                        if (response == "yes")
                        {
                            Console.WriteLine("You were born in October.");
                        }
                        else
                        {
                            Console.WriteLine("Were you born in November? (yes/no)");
                            response = GetYesOrNoResponse();

                            if (response == "yes")
                            {
                                Console.WriteLine("You were born in November.");
                            }
                            else
                            {
                                Console.WriteLine("You were born in December.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Were you born in January? (yes/no)");
                        response = GetYesOrNoResponse();

                        if (response == "yes")
                        {
                            Console.WriteLine("You were born in January.");
                        }
                        else
                        {
                            Console.WriteLine("Were you born in February? (yes/no)");
                            response = GetYesOrNoResponse();

                            if (response == "yes")
                            {
                                Console.WriteLine("You were born in February.");
                            }
                            else
                            {
                                Console.WriteLine("You were born in March.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Were you born in spring? (yes/no)");
                    response = GetYesOrNoResponse();

                    if (response == "yes")
                    {
                        Console.WriteLine("Were you born in April? (yes/no)");
                        response = GetYesOrNoResponse();

                        if (response == "yes")
                        {
                            Console.WriteLine("You were born in April.");
                        }
                        else
                        {
                            Console.WriteLine("Were you born in May? (yes/no)");
                            response = GetYesOrNoResponse();

                            if (response == "yes")
                            {
                                Console.WriteLine("You were born in May.");
                            }
                            else
                            {
                                Console.WriteLine("You were born in June.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Were you born in July? (yes/no)");
                        response = GetYesOrNoResponse();

                        if (response == "yes")
                        {
                            Console.WriteLine("You were born in July.");
                        }
                        else
                        {
                            Console.WriteLine("Were you born in August? (yes/no)");
                            response = GetYesOrNoResponse();

                            if (response == "yes")
                            {
                                Console.WriteLine("You were born in August.");
                            }
                            else
                            {
                                Console.WriteLine("You were born in September.");
                            }
                        }
                    }
                }

                Console.WriteLine("End of the quiz.");
            }

           static string GetYesOrNoResponse()
          {
            string response;
            while (true)
            {
                response = Console.ReadLine().ToLower();
                  //The ToLower method is applied to the input string(received from Console.ReadLine()) and converts all uppercase letters to lowercase.This allows you to do case -insensitive comparisons and avoid input processing errors.
                if (response == "yes" || response == "no")
                {
                    return response;
                }
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no':");
            }
          }
    }
}
